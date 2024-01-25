Public Class ModeloSubRubro
    Public Property IdSubRubro As Integer
    Public Property Abrebiatura As String
    Public Property Descripcion As String
    Public Property Eliminado As String
    Public Property AscRubro As ModeloRubro
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        AscRubro = New ModeloRubro()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub
End Class
