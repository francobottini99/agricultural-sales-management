Public Interface ITransaccionesPedidoMovimientos
    Inherits ITransaccionesGenericas(Of TablaPedidoMovimientos)
    Function elimRegistroPorCampos(param As TablaPedidoMovimientos) As Integer
    Function verRegistrosPorIdPedidoDetalle(id As Integer) As List(Of TablaPedidoMovimientos)
    Function elimRegistroPorIdPedidoDetalle(id As Integer) As Integer
    Function verRegistrosPorIdPedidoDetalleTipo(id As Integer, tipo As String) As List(Of TablaPedidoMovimientos)
    Function verCantidadRetirada(idDetPed As Integer) As TablaPedidoMovimientos
    Function verCantidadAnulada(idDetPed As Integer) As TablaPedidoMovimientos
    Function verCantidadReservada(idDetPed As Integer) As TablaPedidoMovimientos
    Function verCantidadFacturada(idDetPed As Integer) As TablaPedidoMovimientos
    Function verCantidadRemitada(idDetPed As Integer) As TablaPedidoMovimientos
    Function verUltimoId() As TablaPedidoMovimientos
End Interface
