Public Interface ITransaccionesDatosSistema
    Inherits ITransaccionesGenericas(Of TablaDatosSistema)
    Function verRegistro() As TablaDatosSistema
End Interface
