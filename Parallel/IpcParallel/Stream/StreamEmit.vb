﻿#Region "Microsoft.VisualBasic::e147992baf842713336a08ed275e0487, Parallel\IpcParallel\Stream\StreamEmit.vb"

' Author:
' 
'       asuka (amethyst.asuka@gcmodeller.org)
'       xie (genetics@smrucc.org)
'       xieguigang (xie.guigang@live.com)
' 
' Copyright (c) 2018 GPL3 Licensed
' 
' 
' GNU GENERAL PUBLIC LICENSE (GPL3)
' 
' 
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
' 
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with this program. If not, see <http://www.gnu.org/licenses/>.



' /********************************************************************************/

' Summaries:

'     Class StreamEmit
' 
'         Constructor: (+1 Overloads) Sub New
'         Function: (+2 Overloads) Emit, (+2 Overloads) handleCreate, handleSerialize
' 
' 
' /********************************************************************************/

#End Region

Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.Emit.Delegates
Imports Microsoft.VisualBasic.Linq
Imports Microsoft.VisualBasic.MIME.application.json
Imports Microsoft.VisualBasic.MIME.application.json.BSON
Imports TypeInfo = Microsoft.VisualBasic.Scripting.MetaData.TypeInfo

Namespace IpcStream

    Public Class StreamEmit

        ReadOnly toBuffers As New Dictionary(Of Type, toBuffer)
        ReadOnly loadBuffers As New Dictionary(Of Type, loadBuffer)
        ReadOnly emitCache As New Dictionary(Of Type, IEmitStream)

        Sub New()
            For Each [handle] In EmitHandler.PopulatePrimitiveHandles
                toBuffers(handle.target) = handle.emit
            Next
            For Each [handle] In EmitHandler.PopulatePrimitiveParsers
                loadBuffers(handle.target) = handle.emit
            Next
        End Sub

        Public Function Emit(Of T)(streamAs As Func(Of T, Stream)) As StreamEmit
            toBuffers(GetType(T)) = Function(obj) streamAs(obj)
            Return Me
        End Function

        Public Function Emit(Of T)(fromStream As Func(Of Stream, T)) As StreamEmit
            loadBuffers(GetType(T)) = Function(buf) fromStream(buf)
            Return Me
        End Function

        Public Function handleCreate(stream As ObjectStream) As Object
            Using buf As Stream = stream.openMemoryBuffer
                Return handleCreate(buf, stream.GetUnderlyingType, stream.method)
            End Using
        End Function

        Public Function handleCreate(buf As Stream, type As Type, emit As StreamMethods) As Object
            If emit = StreamMethods.Auto Then
                If loadBuffers.ContainsKey(type) Then
                    Return loadBuffers(type)(buf)
                ElseIf emitCache.ContainsKey(type) Then
                    Return emitCache(type).ReadBuffer(buf)
                Else
                    Dim handler As IEmitStream = getHandler(type)

                    If Not handler Is Nothing Then
                        emitCache.Add(type, handler)
                        Return emitCache(type).ReadBuffer(buf)
                    Else
                        Return BSONFormat.Load(buf).CreateObject(type)
                    End If
                End If
            ElseIf emit = StreamMethods.BSON Then
                Return BSONFormat.Load(buf).CreateObject(type)
            ElseIf loadBuffers.ContainsKey(type) Then
                Return loadBuffers(type)(buf)
            Else
                Throw New NotImplementedException
            End If
        End Function

        Private Function getHandler(type As Type) As IEmitStream
            Dim attr As EmitStreamAttribute = CType(type, System.Reflection.TypeInfo).GetCustomAttributes(Of EmitStreamAttribute).FirstOrDefault

            If attr Is Nothing Then
                Return Nothing
            End If

            type = attr.Handler

            If Not type.ImplementInterface(Of IEmitStream) Then
                Return Nothing
            Else
                Return Activator.CreateInstance(type)
            End If
        End Function

        Public Function handleSerialize(param As Object) As ObjectStream
            Dim type As Type = param.GetType
            Dim method As StreamMethods
            Dim typeinfo As New TypeInfo(type, fullpath:=True)
            Dim buf As Stream

            If toBuffers.ContainsKey(type) Then
                method = StreamMethods.Emit
                buf = toBuffers(type)(param)
            ElseIf emitCache.ContainsKey(type) Then
                method = StreamMethods.Auto
                buf = emitCache(type).WriteBuffer(param)
            Else
                Dim handler As IEmitStream = getHandler(type)

                If Not handler Is Nothing Then
                    emitCache.Add(type, handler)
                    method = StreamMethods.Auto
                    buf = handler.WriteBuffer(param)
                Else
                    buf = type _
                        .GetJsonElement(param, New JSONSerializerOptions) _
                        .DoCall(AddressOf BSONFormat.SafeGetBuffer)
                    method = StreamMethods.BSON
                End If
            End If

            Return New ObjectStream(typeinfo, method, buf)
        End Function
    End Class
End Namespace
