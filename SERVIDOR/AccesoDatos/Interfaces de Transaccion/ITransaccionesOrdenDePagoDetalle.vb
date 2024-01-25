Public Interface ITransaccionesOrdenDePagoDetalle
    Inherits ITransaccionesGenericas(Of TablaOrdenDePagoDetalle)
    Function elimRegistroPorIdOrdenDePago(id As Integer) As Integer
End Interface
