Public Class TablaClientes
    Public Property idCliente As Integer
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
    Public Property CreditoAsignado As Double
    Public Property CreditoConsumido As Double
    Public Property Estado As String
    Public Property Clasificacion As String
    Public Property Eliminado As String
    Public Property ascUsuarios As New TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class