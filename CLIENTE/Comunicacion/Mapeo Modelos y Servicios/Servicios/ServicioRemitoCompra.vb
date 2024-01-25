Public Class ServicioRemitoCompra
    Public Property RemitoCompra As ModeloRemitosCompra
    Public Property RemitoCompraMoneda As ModeloRemitoComMonedas
    Public Property DetalleRemitoCompra As List(Of ModeloDetalleRemitoCompra)
    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
    Public Property RemitosCompraMovimientos As List(Of ModeloRemitosCompraMovimientos)
    Public Property FacturaCompraMovimientos As List(Of ModeloFacturaCompraMovimientos)

    Public Sub New()
        RemitoCompra = New ModeloRemitosCompra()
        RemitoCompraMoneda = New ModeloRemitoComMonedas()
        DetalleRemitoCompra = New List(Of ModeloDetalleRemitoCompra)
        Movimientos_Remito_Factura = New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
        RemitosCompraMovimientos = New List(Of ModeloRemitosCompraMovimientos)
        FacturaCompraMovimientos = New List(Of ModeloFacturaCompraMovimientos)()
    End Sub
End Class
