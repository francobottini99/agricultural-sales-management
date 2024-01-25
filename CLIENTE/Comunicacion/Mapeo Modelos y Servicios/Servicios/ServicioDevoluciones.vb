Public Class ServicioDevoluciones
    Public Property Devoluciones As ModeloDevoluciones
    Public Property CuentaCorritenteVenta As ModeloCuentaCorrienteVenta
    Public Property Numeracion As ModeloNumeracion
    Public Property Stock As List(Of ModeloStock)
    Public Property DetallesDevoluciones As List(Of ModeloDetalleDevoluciones)
    Public Property RemitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos)
    Public Property FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)
    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)

    Public Sub New()
        Devoluciones = New ModeloDevoluciones()
        CuentaCorritenteVenta = New ModeloCuentaCorrienteVenta()
        Numeracion = New ModeloNumeracion()
        Stock = New List(Of ModeloStock)()
        DetallesDevoluciones = New List(Of ModeloDetalleDevoluciones)()
        RemitosVentaMovimientos = New List(Of ModeloRemitosVentaMovimientos)()
        FacturaVentaMovimientos = New List(Of ModeloFacturaVentaMovimientos)()
        Movimientos_Remito_Factura = New List(Of ModeloMovimientos_Remito_Factura)()
    End Sub
End Class
