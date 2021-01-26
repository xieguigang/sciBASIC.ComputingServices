﻿Imports System.IO
Imports System.Reflection
Imports System.Text
#If netcore5 = 1 Then
Imports Microsoft.VisualBasic.ApplicationServices.Development.NetCore5
#End If
Imports Microsoft.VisualBasic.ComponentModel
Imports Microsoft.VisualBasic.MIME.application.json
Imports Microsoft.VisualBasic.MIME.application.json.BSON
Imports Microsoft.VisualBasic.Net.Tcp
Imports Microsoft.VisualBasic.Parallel
Imports Microsoft.VisualBasic.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Public Class TaskBuilder : Implements ITaskDriver

    ReadOnly masterPort As Integer

    Sub New(port As Integer)
        masterPort = port
    End Sub

    Public Function Run() As Integer Implements ITaskDriver.Run
        Dim task As IDelegate = GetMethod()
        Dim api As MethodInfo = task.GetMethod
        Dim target As Object = task.GetMethodTarget
        Dim n As Integer = GetArgumentValueNumber()
        Dim args As New List(Of Object)

        For i As Integer = 0 To n - 1
            args.Add(GetArgumentValue(i))
        Next

        Call Console.WriteLine("run task:")
        Call Console.WriteLine(task.GetJson(indent:=False, simpleDict:=True))

        Dim params As ParameterInfo() = api.GetParameters

        For i As Integer = n To params.Length - 1
            If Not params(i).IsOptional Then
                Return PostError(New Exception($"missing parameter value for [{i}]{params(i).Name}!"))
            Else
                args.Add(params(i).DefaultValue)
            End If
        Next

        ' send debug message
        Call New TcpRequest(masterPort).SendMessage(New RequestStream(IPCSocket.Protocol, Protocols.PostStart))
        Call PostFinished(api.Invoke(target, args.ToArray))
        ' Call PostStdOut(api.Invoke(target, args.ToArray))
        Call Console.WriteLine("job done!")

        Return 0
    End Function

    Private Function GetArgumentValueNumber() As Integer
        Dim resp = New TcpRequest(masterPort).SendMessage(New RequestStream(IPCSocket.Protocol, Protocols.GetArgumentNumber))
        Dim n As Integer = BitConverter.ToInt32(resp.ChunkBuffer, Scan0)

        Return n
    End Function

    Private Function GetMethod() As IDelegate
        Dim resp = New TcpRequest(masterPort).SendMessage(New RequestStream(IPCSocket.Protocol, Protocols.GetTask))
        Dim json As String = resp.GetUTF8String
        Dim target As IDelegate = json.LoadJSON(Of IDelegate)

        Return target
    End Function

    Private Function GetArgumentValue(i As Integer) As Object
        Dim request As New RequestStream(IPCSocket.Protocol, Protocols.GetArgumentByIndex, BitConverter.GetBytes(i))
        Dim resp = New TcpRequest(masterPort).SendMessage(request)
        Dim stream As New ObjectStream(resp.ChunkBuffer)
        Dim type As Type = stream.type.GetType(knownFirst:=True)

#If netcore5 = 1 Then
        Call deps.TryHandleNetCore5AssemblyBugs(package:=type)
#End If

        If stream.method = StreamMethods.BSON Then
            Return BSONFormat.Load(stream.stream).CreateObject(type)
        Else
            Throw New NotImplementedException
        End If
    End Function

    Private Function PostError(err As Exception) As Integer


        Return 500
    End Function

    Friend Const streamDelimiter As String = "------endoftext------"

    ''' <summary>
    ''' 将结果数据写到标准输出上
    ''' </summary>
    ''' <param name="result"></param>
    Private Sub PostStdOut(result As Object)
        Dim type As Type = result.GetType
        Dim element = type.GetJsonElement(result, New JSONSerializerOptions)
        Dim buf As MemoryStream = BSONFormat.SafeGetBuffer(element)
        Dim bufferSize As String = buf.Length
        Dim outstream As Stream = Console.OpenStandardOutput

        Call Console.WriteLine(streamDelimiter)
        Call Console.WriteLine(bufferSize)
        Call Console.Write(vbCrLf)

        Using stdout As New BinaryWriter(outstream)
            Call stdout.Write(buf.ToArray)
            Call stdout.Flush()
        End Using
    End Sub

    Private Sub PostFinished(result As Object)
        Dim type As Type = result.GetType
        Dim element = type.GetJsonElement(result, New JSONSerializerOptions)
        Dim buf As Stream = BSONFormat.SafeGetBuffer(element)
        Dim request As New RequestStream(IPCSocket.Protocol, Protocols.PostResult, New StreamPipe(buf).Read)

        Call Console.WriteLine($"post result: {type.GetObjectJson(result, indent:=False)}")
        Call New TcpRequest(masterPort).SendMessage(request)
    End Sub
End Class
