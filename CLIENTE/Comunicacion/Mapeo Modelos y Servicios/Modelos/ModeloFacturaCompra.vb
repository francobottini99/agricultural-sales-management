Public Class ModeloFacturaCompra
    Public Property IdFacturaCompra As Integer
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
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscProveedores As ModeloProveedores
    Public Property AscCuentaCorrienteCompra As ModeloCuentaCorrienteCompra
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
        AscProveedores = New ModeloProveedores()
        AscCuentaCorrienteCompra = New ModeloCuentaCorrienteCompra()
    End Sub
End Class
