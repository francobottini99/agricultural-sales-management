Public Interface ITransaccionesRemitoComMonedas
    Inherits ITransaccionesGenericas(Of ModeloRemitoComMonedas)
    Function elimRegistroPorIdRemitosCompra(id As Integer) As Task
    Function verRegistroPorIdRemitosCompra(id As Integer) As Task(Of ModeloRemitoComMonedas)
End Interface
