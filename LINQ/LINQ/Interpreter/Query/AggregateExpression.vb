﻿Imports LINQ.Runtime

Namespace Interpreter.Query

    ''' <summary>
    ''' aggregate ... into ...
    ''' </summary>
    Public Class AggregateExpression : Inherits QueryExpression

        Public Overrides Function Exec(env As Environment) As Object
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace