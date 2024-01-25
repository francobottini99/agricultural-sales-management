Public Interface ITransaccionesCtaCteCompra
    Inherits ITransaccionesGenericas(Of TablaCuentaCorrienteCompra)
    Function verUltimoID() As TablaCuentaCorrienteCompra
    Function verCuentaCorrienteVentaPorIdProveedor(idProveedor As Integer) As List(Of TablaCuentaCorrienteCompra)
End Interface
