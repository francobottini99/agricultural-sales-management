Public Interface ITransaccionesFacturaVentaMovimientos
    Inherits ITransaccionesGenericas(Of TablaFacturaVentaMovimientos)
    Function verUltimoId() As TablaFacturaVentaMovimientos
    Function verCantidadFacturada(idDetFac As Integer) As TablaFacturaVentaMovimientos
    Function verCantidadAnulada(idDetFac As Integer) As TablaFacturaVentaMovimientos
    Function verCantidadRemitada(idDetFac As Integer) As TablaFacturaVentaMovimientos
End Interface
