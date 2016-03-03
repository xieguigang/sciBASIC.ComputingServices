﻿Imports System.Text
Imports Microsoft.VisualBasic.ComponentModel
Imports Microsoft.VisualBasic.ComputingServices.TaskHost
Imports Microsoft.VisualBasic.Linq.Framework.Provider
Imports Microsoft.VisualBasic.Linq.Framework.Provider.ImportsAPI
Imports Microsoft.VisualBasic.Serialization.JsonContract
Imports RQL.StorageTek

Namespace Linq

    ''' <summary>
    ''' Repository database
    ''' </summary>
    Public Class Repository : Implements ISaveHandle

        ''' <summary>
        ''' {lower_case.url, type_info}
        ''' </summary>
        ''' <returns></returns>
        Public Property Models As New Dictionary(Of String, EntityProvider)

        ReadOnly __types As TypeRegistry
        ReadOnly __api As APIProvider

        Sub New()
            __api = APIProvider.LoadDefault
            __types = TypeRegistry.LoadDefault
        End Sub

        Public Sub AddLinq(url As String, resource As String, Linq As GetLinqResource)
            Dim res As EntityProvider = LinqSource.Source(resource, Linq)
            If Models.ContainsKey(url.ToLower.ShadowCopy(url)) Then
                Call Models.Remove(url)
            End If
            Call Models.Add(url, res)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="url">大小写不敏感，不需要额外的处理</param>
        ''' <returns></returns>
        Public Function GetRepository(url As String, Optional where As String = "") As IEnumerable
            Dim api As EntityProvider = Models(url.ToLower)
            If String.IsNullOrEmpty(where) Then
                Return api.GetRepository
            Else
                Return api.LinqWhere(where, __types, __api)
            End If
        End Function

        ''' <summary>
        ''' 获取得到的是集合之中的元素的类型
        ''' </summary>
        ''' <param name="url"></param>
        ''' <returns></returns>
        Public Overloads Function [GetType](url As String) As Type
            Dim api As EntityProvider = Models(url.ToLower)
            Return api.GetType
        End Function

        Public Shared Function LoadFile(url As String) As Repository
            Try
                Return LoadJsonFile(Of Repository)(url)
            Catch ex As Exception
                ex = New Exception(url, ex)
                Call App.LogException(ex)

                Dim __new As New Repository
                Call __new.Save(url, Encodings.ASCII)
                Return __new
            End Try
        End Function

        Public Shared Function LoadDefault() As Repository
            Return LoadFile(DefaultFile)
        End Function

        Public Shared ReadOnly Property DefaultFile As String =
            App.ProductSharedDIR & "/RQL.Provider.json"

        Private Function ISaveHandle_Save(Optional Path As String = "", Optional encoding As Encoding = Nothing) As Boolean Implements ISaveHandle.Save
            If String.IsNullOrEmpty(Path) Then
                Path = DefaultFile
            End If
            Return Me.GetJson.SaveTo(Path, encoding)
        End Function

        Public Function Save(Optional Path As String = "", Optional encoding As Encodings = Encodings.UTF8) As Boolean Implements ISaveHandle.Save
            Return ISaveHandle_Save(Path, encoding.GetEncodings)
        End Function
    End Class
End Namespace