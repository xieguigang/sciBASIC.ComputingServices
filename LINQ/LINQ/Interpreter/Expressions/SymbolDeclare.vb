﻿Imports LINQ.Runtime

Namespace Interpreter.Expressions

    Public Class SymbolDeclare : Inherits Expression

        Public Property symbolName As String
        Public Property type As String

        Public Overrides Function Exec(env As Environment) As Object
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace