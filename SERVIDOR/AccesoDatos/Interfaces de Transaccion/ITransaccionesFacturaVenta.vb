Public Interface ITransaccionesFacturaVenta
    Inherits ITransaccionesGenericas(Of TablaFacturaVenta)
    Function verUltimoID() As TablaFacturaVenta
    Function verFacturasVentaSinRemitar() As List(Of TablaFacturaVenta)
    Function modEstadoRemitado(id As Integer, estRem As String) As Integer
    Function modFacturaVentaCAE(id As Integer, CAE As String, fchVtoCAE As Date) As Integer
End Interface
