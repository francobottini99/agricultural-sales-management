Public Interface ITransaccionesFacturaComMonedas
    Inherits ITransaccionesGenericas(Of ModeloFacturaComMonedas)
    Function elimRegistroPorIdFacturaCompra(id As Integer) As Task(Of Integer)
    Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of ModeloFacturaComMonedas)
End Interface
