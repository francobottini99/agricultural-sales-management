Public Interface ITransaccionesRemitoCompraMovimientos
    Inherits ITransaccionesGenericas(Of ModeloRemitosCompraMovimientos)
    Function verRegistrosPorIdRemitosCompra(id As Integer) As Task(Of List(Of ModeloRemitosCompraMovimientos))
End Interface
