Public Class TablaMovimientos_Factura_Reserva
    Public Property idMovimientos_Factura_Reseva As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascFacturaVentaMovimientos As TablaFacturaVentaMovimientos
    Public Property ascPedidoMovimientos As TablaPedidoMovimientos

    Public Sub New()
        ascFacturaVentaMovimientos = New TablaFacturaVentaMovimientos()
        ascPedidoMovimientos = New TablaPedidoMovimientos()
    End Sub
End Class
