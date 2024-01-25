Public Class ModeloDepositos
    Public Property IdDeposito As Integer
    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property Provincia As String
    Public Property CodPostal As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub
End Class
