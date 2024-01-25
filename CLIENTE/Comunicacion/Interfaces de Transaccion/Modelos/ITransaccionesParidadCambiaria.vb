Public Interface ITransaccionesParidadCambiaria
    Inherits ITransaccionesGenericas(Of ModeloParidadCambiaria)
    Function verRegistrosPorIdMonedas(id As Integer) As Task(Of List(Of ModeloParidadCambiaria))
End Interface
