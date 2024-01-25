Public Interface ITransaccionesRemtiosVenta
    Inherits ITransaccionesGenericas(Of TablaRemitosVenta)
    Function verUltimoId() As TablaRemitosVenta
    Function verSinFacturar() As List(Of TablaRemitosVenta)
    Function modEstadoFacturacion(id As Integer, estFact As String) As Integer
    Function verRegistroPorId(id As Integer) As TablaRemitosVenta
End Interface
