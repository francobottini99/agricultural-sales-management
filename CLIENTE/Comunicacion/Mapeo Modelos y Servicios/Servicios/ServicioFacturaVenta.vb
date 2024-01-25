Public Class ServicioFacturaVenta
    Public Property FacturaVenta As ModeloFacturaVenta
    Public Property CuentaCorritenteVenta As ModeloCuentaCorrienteVenta
    Public Property FacturaVentaMoneda As ModeloFacturaVentaMonedas
    Public Property FacturaVentaDetalle As List(Of ModeloFacturaVentaDetalle)
    Public Property Numeracion As ModeloNumeracion
    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)
    Public Property Movimientos_Factura_Reserva As List(Of ModeloMovimientos_Factura_Reserva)
    Public Property RemitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos)
    Public Property PedidosMovimientos As List(Of ModeloPedidoMovimientos)
    Public Property FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)

    Public Sub New()
        FacturaVenta = New ModeloFacturaVenta()
        CuentaCorritenteVenta = New ModeloCuentaCorrienteVenta()
        FacturaVentaMoneda = New ModeloFacturaVentaMonedas()
        FacturaVentaDetalle = New List(Of ModeloFacturaVentaDetalle)()
        Numeracion = New ModeloNumeracion()
        Movimientos_Remito_Factura = New List(Of ModeloMovimientos_Remito_Factura)()
        Movimientos_Factura_Reserva = New List(Of ModeloMovimientos_Factura_Reserva)()
        RemitosVentaMovimientos = New List(Of ModeloRemitosVentaMovimientos)()
        PedidosMovimientos = New List(Of ModeloPedidoMovimientos)()
        FacturaVentaMovimientos = New List(Of ModeloFacturaVentaMovimientos)()
    End Sub
End Class
