Public Class ModeloProveedores
    Public Property IdProveedor As Integer
    Public Property FechaAlta As Date
    Public Property RazonSocial As String
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property Provincia As String
    Public Property CodPostal As String
    Public Property Pais As String
    Public Property Telefono As String
    Public Property Mail As String
    Public Property Web As String
    Public Property CUIT As String
    Public Property IIBB As String
    Public Property SituacionIVA As String
    Public Property Estado As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub
End Class

