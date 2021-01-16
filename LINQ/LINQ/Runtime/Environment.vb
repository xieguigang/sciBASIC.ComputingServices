﻿Imports Microsoft.VisualBasic.ComponentModel.DataSourceModel

Namespace Runtime

    Public Class Environment

        Protected ReadOnly symbols As New Dictionary(Of String, Symbol)
        Protected ReadOnly parent As Environment

        Public ReadOnly Property IsGlobal As Boolean
            Get
                Return parent Is Nothing
            End Get
        End Property

        Sub New(parent As Environment)
            Me.parent = parent
        End Sub

        Public Function AddSymbol(name As String, type As String) As Symbol
            Dim newSymbol As New Symbol With {
                .SymbolKey = name,
                .type = type
            }

            Call symbols.Add(name, newSymbol)

            Return newSymbol
        End Function

        Public Function FindSymbol(name As String) As Symbol
            If symbols.ContainsKey(name) Then
                Return symbols(name)
            Else
                Return parent.FindSymbol(name)
            End If
        End Function

    End Class

    Public Class GlobalEnvironment : Inherits Environment

        Protected ReadOnly registry As Registry

        Sub New(registry As Registry, ParamArray values As NamedValue(Of Object)())
            Call MyBase.New(Nothing)

            Dim typeCode As String
            Dim symbol As Symbol

            For Each item In values
                typeCode = registry.GetTypeCodeName(item.Value.GetType)
                symbol = AddSymbol(item.Name, typeCode)
                symbol.value = item.Value
            Next

            Me.registry = registry
        End Sub
    End Class
End Namespace