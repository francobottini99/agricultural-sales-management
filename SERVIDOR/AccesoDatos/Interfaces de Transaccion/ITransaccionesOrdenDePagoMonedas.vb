Public Interface ITransaccionesOrdenDePagoMonedas
    Inherits ITransaccionesGenericas(Of TablaOrdenDePagoMonedas)
    Function verRegistroPorIdOrdenDePago(id As Integer) As List(Of TablaOrdenDePagoMonedas)
    Function elimRegistroPorIdOrdenDePago(id As Integer) As Integer
End Interface
