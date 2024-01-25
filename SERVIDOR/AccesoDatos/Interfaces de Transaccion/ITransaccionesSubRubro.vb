Public Interface ITransaccionesSubRubro
    Inherits ITransaccionesGenericas(Of TablaSubRubro)
    Function verExisteSubRubroPorIdRubro(id As Integer) As Boolean
    Function verExisteSubRubroPorNombre(nombre As String) As Boolean
    Function verExisteSubRubroPorAbrebiatura(abrebiatura As String) As Boolean
    Function verRegistroPorId(id As Integer) As TablaSubRubro
End Interface
