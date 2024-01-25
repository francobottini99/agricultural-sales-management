Public Interface ITransaccionesBancos
    Inherits ITransaccionesGenericas(Of TablaBancos)
    Function verExisteBancoPorNombre(nombre As String) As Boolean
    Function verRegistroPorId(id As Integer) As TablaBancos
End Interface
