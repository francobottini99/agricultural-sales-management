Public Class ServicioFacturaCompra
    Public Property FacturaCompra As ModeloFacturaCompra
    Public Property CuentaCorritenteCompra As ModeloCuentaCorrienteCompra
    Public Property FacturaCompraMoneda As ModeloFacturaComMonedas
    Public Property FacturaCompraDetalle As List(Of ModeloFacturaCompraDetalle)
    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
    Public Property RemitosCompraMovimientos As List(Of ModeloRemitosCompraMovimientos)
    Public Property FacturaCompraMovimientos As List(Of ModeloFacturaCompraMovimientos)

    Public Sub New()
        FacturaCompra = New ModeloFacturaCompra()
        CuentaCorritenteCompra = New ModeloCuentaCorrienteCompra()
        FacturaCompraMoneda = New ModeloFacturaComMonedas()
        Movimientos_Remito_Factura = New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
        RemitosCompraMovimientos = New List(Of ModeloRemitosCompraMovimientos)
        FacturaCompraMovimientos = New List(Of ModeloFacturaCompraMovimientos)
    End Sub
End Class
