Public Interface ITransaccionesMonedas
    Inherits ITransaccionesGenericas(Of TablaMonedas)
    Function verRegistroPorNombre(nombre As String) As TablaMonedas
End Interface
