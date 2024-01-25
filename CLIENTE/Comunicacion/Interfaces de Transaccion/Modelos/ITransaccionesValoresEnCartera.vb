Public Interface ITransaccionesValoresEnCartera
    Inherits ITransaccionesGenericas(Of ModeloValoresEnCartera)
    Function verListadoDisponible(disponible As String) As Task(Of List(Of ModeloValoresEnCartera))
    Function verSaldoPesos() As Task(Of Double)
    Function verSaldoDolares() As Task(Of Double)
End Interface
