Public Interface ITransaccionesDetalleCheques
    Inherits ITransaccionesGenericas(Of ModeloDetalleCheque)
    Function verDetalleChequePorChequera(id As Integer) As Task(Of List(Of ModeloDetalleCheque))
    Function elimChequePorIdChequera(id As Integer) As Task
End Interface
