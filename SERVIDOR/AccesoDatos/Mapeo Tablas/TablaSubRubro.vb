Public Class TablaSubRubro
    Public Property idSubRubro As Integer
    Public Property Abrebiatura As String
    Public Property Descripcion As String
    Public Property Eliminado As String
    Public Property ascRubro As TablaRubro
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascRubro = New TablaRubro()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class

