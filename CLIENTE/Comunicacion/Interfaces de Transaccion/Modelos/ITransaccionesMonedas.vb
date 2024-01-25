Public Interface ITransaccionesMonedas
    Inherits ITransaccionesGenericas(Of ModeloMonedas)
    Function verRegistroPorNombre(nombre As String) As Task(Of ModeloMonedas)
End Interface
