Public Interface ITransaccionesRemitosCompraMovimientos
    Inherits ITransaccionesGenericas(Of TablaRemitosCompraMovimientos)
    Function verRegistrosPorIdRemitosCompra(id As Integer) As List(Of TablaRemitosCompraMovimientos)
    Function verCantidadRemitada(idDetRem As Integer) As TablaRemitosCompraMovimientos
    Function verCantidadDevuelta(idDetRem As Integer) As TablaRemitosCompraMovimientos
    Function verCantidadFacturada(idDetRem As Integer) As TablaRemitosCompraMovimientos
    Function verUltimoId() As TablaRemitosCompraMovimientos
End Interface
