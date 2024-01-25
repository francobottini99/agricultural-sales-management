Public Interface ITransaccionesDevolucionesMonedas
    Inherits ITransaccionesGenericas(Of TablaDevolucionesMonedas)
    Function elimRegistroPorIdDevoluciones(id As Integer) As Integer
End Interface
