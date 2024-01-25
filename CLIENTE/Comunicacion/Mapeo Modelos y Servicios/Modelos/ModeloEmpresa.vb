Public Class ModeloEmpresa
    Public Property IdEmpresa As Integer
    Public Property RazonSocial As String
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property Provincia As String
    Public Property CodPostal As String
    Public Property Pais As String
    Public Property TE As String
    Public Property Mail As String
    Public Property CUIT As String
    Public Property IIBB As String
    Public Property InicioActividad As Date
    Public Property PrefijoFacturacion As String
    Public Property Web As String
    Public Property CondicionIVA As String
    Public Property Logo As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub
End Class
