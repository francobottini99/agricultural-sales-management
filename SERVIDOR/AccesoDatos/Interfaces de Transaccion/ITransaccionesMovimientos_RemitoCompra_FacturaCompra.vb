Public Interface ITransaccionesMovimientos_RemitoCompra_FacturaCompra
    Inherits ITransaccionesGenericas(Of TablaMovimientos_RemitoCompra_FacturaCompra)
    Function verCantidadRemitada(idDetFac As Integer) As TablaMovimientos_RemitoCompra_FacturaCompra
    Function verCantidadFacturada(idDetRem As Integer) As TablaMovimientos_RemitoCompra_FacturaCompra
    Function verRegistrosPorIdRemitosCompra(id As Integer) As List(Of TablaMovimientos_RemitoCompra_FacturaCompra)
    Function verRegistrosPorIdFacturaCompra(id As Integer) As List(Of TablaMovimientos_RemitoCompra_FacturaCompra)
End Interface
