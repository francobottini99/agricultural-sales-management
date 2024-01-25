Public Class ModeloMovimientos_Factura_Reserva
    Public Property IdMovimientos_Factura_Reseva As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscFacturaVentaMovimientos As ModeloFacturaVentaMovimientos
    Public Property AscPedidoMovimientos As ModeloPedidoMovimientos
    Public Property Err As Errores

    Public Sub New()
        AscFacturaVentaMovimientos = New ModeloFacturaVentaMovimientos()
        AscPedidoMovimientos = New ModeloPedidoMovimientos()
        Err = New Errores()
    End Sub
End Class
