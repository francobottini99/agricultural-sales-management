Public Interface ITransaccionesFacturaCompraDetalle
    Inherits ITransaccionesGenericas(Of TablaFacturaCompraDetalle)
    Function elimRegistroPorIdFacturaCompra(id As Integer) As Integer
    Function verRegistrosPorIdFacturaCompra(id As Integer) As List(Of TablaFacturaCompraDetalle)
    Function modEstadoRemitado(id As Integer, EstRem As String) As Integer
    Function verRegistroPorIdProveedor_Remitado(id As Integer, remitado As String) As List(Of TablaFacturaCompraDetalle)
    Function verUltimoId() As TablaFacturaCompraDetalle
End Interface
