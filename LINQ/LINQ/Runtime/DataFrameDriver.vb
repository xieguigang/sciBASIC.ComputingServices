﻿Imports Microsoft.VisualBasic.Data.csv.IO
Imports Microsoft.VisualBasic.My.JavaScript

Namespace Runtime

    Public Class DataFrameDriver : Inherits DataSourceDriver

        Public Overrides Iterator Function ReadFromUri(uri As String) As IEnumerable(Of Object)
            Dim dataframe As DataFrame = dataframe.Load(uri).MeasureTypeSchema
            Dim obj As JavaScriptObject
            Dim headers As String() = dataframe.HeadTitles

            For Each row As Object() In dataframe.EnumerateRowObjects
                obj = New JavaScriptObject

                For i As Integer = 0 To headers.Length - 1
                    obj(headers(i)) = row(i)
                Next

                Yield obj
            Next
        End Function
    End Class
End Namespace