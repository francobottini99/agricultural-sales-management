Public Class ServicioRemitoVenta
    Public Property RemitoVenta As ModeloRemitosVenta
    Public Property RemitoVentaMonedas As ModeloRemitosVentaMonedas
    Public Property Numeracion As ModeloNumeracion
    Public Property DetallesRemitosVenta As List(Of ModeloDetalleRemitoVenta)
    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)
    Public Property Movimientos_Reserva_Remito As List(Of ModeloMovimientos_Reserva_Remito)
    Public Property RemitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos)
    Public Property PedidosMovimientos As List(Of ModeloPedidoMovimientos)
    Public Property FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)

    Public Sub New()
        RemitoVenta = New ModeloRemitosVenta()
        RemitoVentaMonedas = New ModeloRemitosVentaMonedas()
        Numeracion = New ModeloNumeracion()
        DetallesRemitosVenta = New List(Of ModeloDetalleRemitoVenta)
        Movimientos_Remito_Factura = New List(Of ModeloMovimientos_Remito_Factura)
        Movimientos_Reserva_Remito = New List(Of ModeloMovimientos_Reserva_Remito)
        RemitosVentaMovimientos = New List(Of ModeloRemitosVentaMovimientos)
        PedidosMovimientos = New List(Of ModeloPedidoMovimientos)
        FacturaVentaMovimientos = New List(Of ModeloFacturaVentaMovimientos)
    End Sub
End Class
