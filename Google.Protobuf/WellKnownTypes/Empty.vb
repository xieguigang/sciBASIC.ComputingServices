﻿' Generated by the protocol buffer compiler.  DO NOT EDIT!
' source: google/protobuf/empty.proto
#Region "Designer generated code"

Imports Microsoft.VisualBasic.Language
Imports pbr = Google.Protobuf.Reflection

Namespace Google.Protobuf.WellKnownTypes

    ''' <summary>Holder for reflection information generated from google/protobuf/empty.proto</summary>
    Public Partial Module EmptyReflection

#Region "Descriptor"
        ''' <summary>File descriptor for google/protobuf/empty.proto</summary>
        Public ReadOnly Property Descriptor As pbr.FileDescriptor
            Get
                Return descriptorField
            End Get
        End Property

        Private descriptorField As pbr.FileDescriptor

        Sub New()
            Dim descriptorData As Byte() = Global.System.Convert.FromBase64String(String.Concat("Chtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8SD2dvb2dsZS5wcm90b2J1", "ZiIHCgVFbXB0eUJ5ChNjb20uZ29vZ2xlLnByb3RvYnVmQgpFbXB0eVByb3Rv", "UAFaJ2dpdGh1Yi5jb20vZ29sYW5nL3Byb3RvYnVmL3B0eXBlcy9lbXB0eaAB", "AfgBAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IG", "cHJvdG8z"))
            descriptorField = pbr.FileDescriptor.FromGeneratedCode(descriptorData, New pbr.FileDescriptor() {}, New pbr.GeneratedClrTypeInfo(Nothing, New pbr.GeneratedClrTypeInfo() {New pbr.GeneratedClrTypeInfo(GetType(Global.Google.Protobuf.WellKnownTypes.Empty), Global.Google.Protobuf.WellKnownTypes.Empty.Parser, Nothing, Nothing, Nothing, Nothing)}))
        End Sub
#End Region

    End Module
#Region "Messages"
    ''' <summary>
    '''  A generic empty message that you can re-use to avoid defining duplicated
    '''  empty messages in your APIs. A typical example is to use it as the request
    '''  or the response type of an API method. For instance:
    '''
    '''      service Foo {
    '''        rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty);
    '''      }
    '''
    '''  The JSON representation for `Empty` is empty JSON object `{}`.
    ''' </summary>
    Public NotInheritable Partial Class Empty
        Implements IMessageType(Of Empty)

        Private Shared ReadOnly _parser As MessageParserType(Of Empty) = New MessageParserType(Of Empty)(Function() New Empty())

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Shared ReadOnly Property Parser As MessageParserType(Of Empty)
            Get
                Return _parser
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Shared ReadOnly Property DescriptorProp As pbr.MessageDescriptor
            Get
                Return Global.Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor.MessageTypes(0)
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private ReadOnly Property Descriptor As pbr.MessageDescriptor Implements IMessage.Descriptor
            Get
                Return DescriptorProp
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            OnConstruction()
        End Sub

        Partial Private Sub OnConstruction()
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New(other As Empty)
            Me.New()
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Function Clone() As Empty Implements IDeepCloneable(Of Empty).Clone
            Return New Empty(Me)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overrides Function Equals(other As Object) As Boolean
            Return Equals(TryCast(other, Empty))
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overloads Function Equals(other As Empty) As Boolean Implements IEquatable(Of Empty).Equals
            If ReferenceEquals(other, Nothing) Then
                Return False
            End If

            If ReferenceEquals(other, Me) Then
                Return True
            End If

            Return True
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overrides Function GetHashCode() As Integer
            Dim hash = 1
            Return hash
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overrides Function ToString() As String
            Return JsonFormatter.ToDiagnosticString(Me)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub WriteTo(output As CodedOutputStream) Implements IMessage.WriteTo
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Function CalculateSize() As Integer Implements IMessage.CalculateSize
            Dim size = 0
            Return size
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub MergeFrom(other As Empty) Implements IMessageType(Of Empty).MergeFrom
            If other Is Nothing Then
                Return
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub MergeFrom(input As CodedInputStream) Implements IMessage.MergeFrom
            Dim tag As New Value(Of UInteger)

            While ((tag = input.ReadTag())) <> 0

                Select Case tag.Value
                    Case Else
                        input.SkipLastField()
                End Select
            End While
        End Sub
    End Class

#End Region

End Namespace
#End Region