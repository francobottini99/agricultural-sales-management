Public Interface ITransaccionesDatosSistema
    Inherits ITransaccionesGenericas(Of ModeloDatosSistema)
    Function verRegistro() As Task(Of ModeloDatosSistema)
End Interface
