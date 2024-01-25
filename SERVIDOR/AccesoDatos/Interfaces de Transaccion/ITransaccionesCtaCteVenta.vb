Public Interface ITransaccionesCtaCteVenta
    Inherits ITransaccionesGenericas(Of TablaCuentaCorrienteVenta)
    Function verUltimoID() As TablaCuentaCorrienteVenta
    Function verCuentaCorrienteVentaPorIdCliente(idCliente As Integer) As List(Of TablaCuentaCorrienteVenta)
End Interface
