Public Class ModeloUsuario
    Public Property IdUsuarios As Integer
    Public Property FechaAlta As Date
    Public Property Nombre As String
    Public Property Tipo As String
    Public Property Contraseña As String
    Public Property Imagen As String
    Public Property Estado As String
    Public Property Token As String
    Public Property Eliminado As String
    Public Property AscPerfilUs As ModeloPerfilUsuario
    Public Property Err As Errores

    Public Sub New()
        AscPerfilUs = New ModeloPerfilUsuario()
        Err = New Errores()
    End Sub
End Class
