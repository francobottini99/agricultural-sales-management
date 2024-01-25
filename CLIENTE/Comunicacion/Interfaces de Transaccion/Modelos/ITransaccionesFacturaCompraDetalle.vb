Public Interface ITransaccionesFacturaCompraDetalle
    Inherits ITransaccionesGenericas(Of ModeloFacturaCompraDetalle)
    Function elimRegistroPorIdFacturaCompra(id As Integer) As Task
    Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of List(Of ModeloFacturaCompraDetalle))
    Function verRegistrosSinRemitar_idProveedor(id As Integer) As Task(Of List(Of ModeloFacturaCompraDetalle))
End Interface
