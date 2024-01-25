Public Interface ITransaccionesFacturaCompraMovimientos
    Inherits ITransaccionesGenericas(Of ModeloFacturaCompraMovimientos)
    Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of List(Of ModeloFacturaCompraMovimientos))
End Interface
