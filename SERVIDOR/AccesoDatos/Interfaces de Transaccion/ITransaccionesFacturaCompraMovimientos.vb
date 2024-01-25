Public Interface ITransaccionesFacturaCompraMovimientos
    Inherits ITransaccionesGenericas(Of TablaFacturaCompraMovimientos)
    Function verUltimoId() As TablaFacturaCompraMovimientos
    Function verCantidadRemitada(idDetFac As Integer) As TablaFacturaCompraMovimientos
    Function verCantidadAnulada(idDetFac As Integer) As TablaFacturaCompraMovimientos
    Function verCantidadFacturada(idDetFac As Integer) As TablaFacturaCompraMovimientos
    Function verRegistrosPorIdFacturaCompra(id As Integer) As List(Of TablaFacturaCompraMovimientos)
End Interface
