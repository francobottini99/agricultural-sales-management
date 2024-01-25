Public Class TablaFacturaCompra
    Public Property idFacturaCompra As Integer
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
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascProveedores As TablaProveedores
    Public Property ascCuentaCorrienteCompra As TablaCuentaCorrienteCompra

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascProveedores = New TablaProveedores()
        ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra()
    End Sub
End Class
