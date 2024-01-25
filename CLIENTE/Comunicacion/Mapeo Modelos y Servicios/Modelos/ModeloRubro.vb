Public Class ModeloRubro
    Public Property IdRubro As Integer
    Public Property Abrebiatura As String
    Public Property Descripcion As String
    Public Property Eliminado As String
    Public Property AscUsuarios As New ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub
End Class
