Public Interface ITransaccionesFacturaCompra
    Inherits ITransaccionesGenericas(Of TablaFacturaCompra)
    Function verRegistroPorId(id As Integer) As TablaFacturaCompra
    Function verUltimoId() As TablaFacturaCompra
    Function modEstadoRemitado(id As Integer, estRem As String) As Integer
End Interface
