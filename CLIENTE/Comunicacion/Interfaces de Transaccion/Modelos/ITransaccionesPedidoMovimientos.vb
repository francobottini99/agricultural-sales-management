Public Interface ITransaccionesPedidoMovimientos
    Inherits ITransaccionesGenericas(Of ModeloPedidoMovimientos)
    Function elimRegistroPorCampos(param As ModeloPedidoMovimientos) As Task(Of Integer)
    Function verRegistrosPorIdPedidoDetalle(id As Integer) As Task(Of List(Of ModeloPedidoMovimientos))
    Function elimRegistroPorIdPedidoDetalle(id As Integer) As Task(Of Integer)
End Interface
