Public Interface ITransaccionesRemitosVentaMovimientos
    Inherits ITransaccionesGenericas(Of TablaRemitosVentaMovimientos)
    Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaRemitosVentaMovimientos)
    Function verRegistrosPorIdDetalleRemitosVenta(id As Integer) As List(Of TablaRemitosVentaMovimientos)
    Function verUltimoId() As TablaRemitosVentaMovimientos
    Function verCantidadRemitada(idDetRem As Integer) As TablaRemitosVentaMovimientos
    Function verCantidadDevuelta(idDetRem As Integer) As TablaRemitosVentaMovimientos
    Function verCantidadFacturada(idDetRem As Integer) As TablaRemitosVentaMovimientos
End Interface
