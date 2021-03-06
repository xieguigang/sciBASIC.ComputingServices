﻿#Region "Microsoft.VisualBasic::bf9ec6b534ad14cc077ed8a4e0cfad7e, Distribute_computing\HPC_cluster\SlaveParallel.vb"

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

    ' Class SlaveParallel
    ' 
    '     Function: CreateProcessor, CreateSlave, SlaveTask
    ' 
    ' /********************************************************************************/

#End Region

Imports HPC_cluster.CLI
Imports Microsoft.VisualBasic.CommandLine.InteropService
Imports Parallel

Public Class SlaveParallel

    ''' <summary>
    ''' Create a slave task factory
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function CreateSlave(Optional debugPort As Integer? = Nothing, Optional verbose As Boolean = False) As SlaveTask
        Return New SlaveTask(SlaveParallel.CreateProcessor, AddressOf SlaveParallel.SlaveTask, debugPort, verbose:=verbose)
    End Function

    Public Shared Function CreateProcessor() As Taskhost_d
        Return Taskhost_d.FromEnvironment(App.HOME)
    End Function

    Public Shared Function SlaveTask(processor As InteropService, port As Integer) As String
        Dim cli As String = DirectCast(processor, Taskhost_d).GetParallelCommandLine(master:=port)
        Return cli
    End Function
End Class
