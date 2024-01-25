Public Class TablaRubro
    Public Property idRubro As Integer
    Public Property Abrebiatura As String
    Public Property Descripcion As String
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
