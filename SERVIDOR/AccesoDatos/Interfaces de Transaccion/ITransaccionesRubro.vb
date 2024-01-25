Public Interface ITransaccionesRubro
    Inherits ITransaccionesGenericas(Of TablaRubro)
    Function verExisteRubroPorNombre(nombre As String) As Boolean
    Function verExisteRubroPorAbrebiatura(abrebiatura As String) As Boolean
    Function verRegistroPorId(id As Integer) As TablaRubro
End Interface
