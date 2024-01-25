Public Interface ITransaccionesOrdenDePagoMonedas
    Inherits ITransaccionesGenericas(Of ModeloOrdenDePagoMonedas)
    Function verRegistroPorIdOrdenDePago(id As Integer) As Task(Of List(Of ModeloOrdenDePagoMonedas))
    Function elimRegistroPorIdOrdenDePago(id As Integer) As Task
End Interface
