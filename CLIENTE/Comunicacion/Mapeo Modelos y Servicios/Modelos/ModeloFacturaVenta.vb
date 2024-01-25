Public Class ModeloFacturaVenta
    Public Property IdFacturaVenta As Integer
    Public Property TipoComprobante As String
    Public Property ClaseComprobante As String
    Public Property Fecha As Date
    Public Property FechaVto As Date
    Public Property Prefijo As String
    Public Property NroComprobante As String
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property Iva As Double
    Public Property ImporteTotal As Double
    Public Property Observaciones As String
    Public Property Remitado As String
    Public Property Eliminado As String
    Public Property CAE As String
    Public Property FechaVtoCAE As Date
    Public Property AscClientes As ModeloCliente
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscCtaCteVenta As ModeloCuentaCorrienteVenta
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
        AscCtaCteVenta = New ModeloCuentaCorrienteVenta()
    End Sub
End Class
