Public Interface ITransaccionesDetalleCheques
    Inherits ITransaccionesGenericas(Of TablaDetalleCheque)
    Function verDetalleChequePorChequera(id As Integer) As List(Of TablaDetalleCheque)
    Function elimChequePorIdChequera(id As Integer) As Integer
End Interface
