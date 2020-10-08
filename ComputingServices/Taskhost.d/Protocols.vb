﻿#Region "Microsoft.VisualBasic::fa83edfe7f64a5afde0ec295eb81ae44, ComputingServices\Taskhost.d\Protocols.vb"

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

'     Module Protocols
' 
' 
'         Enum TaskProtocols
' 
'             [Select], Handshake, InvokeLinq, MoveNext, NodeLoad
'             RemoteFileSystem, Reset
' 
' 
' 
'  
' 
'     Properties: ProtocolEntry
' 
'     Function: GetPortal, LinqReset, Shell
' 
' 
' /********************************************************************************/

#End Region

Imports Microsoft.VisualBasic.CommandLine
Imports Microsoft.VisualBasic.Net.Protocols.Reflection
Imports Microsoft.VisualBasic.Parallel

Namespace TaskHost

    ''' <summary>
    ''' 分布式计算之中的远端调用的堆栈协议
    ''' </summary>
    Public Module Protocols

        ''' <summary>
        ''' Task remotes protocols
        ''' </summary>
        Public Enum TaskProtocols As Long

            ''' <summary>
            ''' Free a object pointer on the remote machine.(释放掉某一个资源)
            ''' </summary>
            Free = -1000L

            ''' <summary>
            ''' 分布式计算的环境初始化的握手协议
            ''' </summary>
            Handshake
            ''' <summary>
            ''' 节点的当前运算负载
            ''' </summary>
            NodeLoad

#Region "Task"
            ''' <summary>
            ''' Invoke a function remotely
            ''' </summary>
            Invoke = 0L
            ''' <summary>
            ''' Invoke a function as a linq data source.
            ''' </summary>
            InvokeLinq
            ''' <summary>
            ''' Gets the portal of the remote FileSystem
            ''' </summary>
            RemoteFileSystem
#End Region

#Region "LINQ supports"
            ''' <summary>
            ''' Linq data source move next
            ''' </summary>
            MoveNext
            ''' <summary>
            ''' Resets the iterator of the remote linq source
            ''' </summary>
            Reset
            ''' <summary>
            ''' The remote linq source reads done! Exit the iterator function.
            ''' </summary>
            ReadsDone = -1000L
            ''' <summary>
            ''' Linq select extension
            ''' </summary>
            [Select]
#End Region
        End Enum

        Public ReadOnly Property ProtocolEntry As Long = New ProtocolAttribute(GetType(TaskProtocols)).EntryPoint

        ''' <summary>
        ''' Resets remote data source by <see cref="IEnumerator.Reset"/>
        ''' </summary>
        ''' <returns></returns>
        Public Function LinqReset() As RequestStream
            Return New RequestStream(ProtocolEntry, TaskProtocols.Reset)
        End Function

        Public Function Shell(exe As String, args As String) As Integer
            Dim proc As New IORedirect(exe, args)
            Return proc.Run
        End Function
    End Module
End Namespace
