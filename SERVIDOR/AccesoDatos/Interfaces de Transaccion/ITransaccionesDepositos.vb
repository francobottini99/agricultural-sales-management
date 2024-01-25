Public Interface ITransaccionesDepositos
    Inherits ITransaccionesGenericas(Of TablaDepositos)
    Function verExisteDepositoPorNombre(nombre As String) As Boolean
    Function verRegistroPorId(id As Integer) As TablaDepositos
End Interface
