﻿Imports System.Reflection
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.ComponentModel.Collection.Generic

Namespace Framework.Provider

    ''' <summary>
    ''' item in the type registry table
    ''' </summary>
    ''' <remarks></remarks>
    Public Class TypeEntry : Implements sIdEnumerable

        ''' <summary>
        ''' 类型的简称或者别称，即本属性为LINQEntity自定义属性中的构造函数的参数
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <XmlAttribute> Public Property name As String Implements sIdEnumerable.Identifier
        ''' <summary>
        ''' 建议使用相对路径，以防止移动程序的时候任然需要重新注册方可以使用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <XmlAttribute> Public Property Assembly As String
        ''' <summary>
        ''' Full type name for the target LINQ entity type. Assembly!typeFullName (目标LINQEntity集合中的类型全称)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks>Assembly!typeFullName</remarks>
        <XmlAttribute> Public Property TypeId As String
        ''' <summary>
        ''' <see cref="Func"/>方法的声明位置
        ''' </summary>
        ''' <returns></returns>
        <XmlAttribute> Public Property DeclaringType As String
        ''' <summary>
        ''' 函数名称
        ''' </summary>
        ''' <returns></returns>
        <XmlAttribute> Public Property Func As String

        Public Function LoadAssembly() As Assembly
            Dim path As String = FileIO.FileSystem.GetFileInfo(Assembly).FullName
            Dim assm As Assembly = System.Reflection.Assembly.LoadFile(path)
            Return assm
        End Function

        ''' <summary>
        ''' 得到集合之中的元素的类型
        ''' </summary>
        ''' <returns></returns>
        Public Overloads Function [GetType]() As Type
            Dim tokens As String() = Me.TypeId.Split("!"c)
            Dim assmPath As String = FileIO.FileSystem.GetFileInfo(tokens(Scan0)).FullName
            Dim assm As Assembly = System.Reflection.Assembly.LoadFile(assmPath)
            Dim typeId As String = tokens(1)
            Dim type As Type = assm.GetType(TypeId)
            Return type
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("({0}) {1}!{2}", name, Assembly, TypeId)
        End Function
    End Class
End Namespace