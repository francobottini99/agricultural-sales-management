Public Interface ITransaccionesRemitosVentaMonedas
    Inherits ITransaccionesGenericas(Of ModeloRemitosVentaMonedas)
    Function verRegistroPorIdRemitosVenta(id As Integer) As Task(Of ModeloRemitosVentaMonedas)
    Function elimRegistroPorIdRemitosVenta(id As Integer) As Task
End Interface
