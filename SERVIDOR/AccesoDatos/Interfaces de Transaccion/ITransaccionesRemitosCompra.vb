Public Interface ITransaccionesRemitosCompra
    Inherits ITransaccionesGenericas(Of TablaRemitosCompra)
    Function verUltimoId() As TablaRemitosCompra
    Function verSinFacturar() As List(Of TablaRemitosCompra)
    Function modEstadoFacturacion(id As Integer, estFac As String) As Integer
    Function verRegistroPorId(id As Integer) As TablaRemitosCompra
End Interface
