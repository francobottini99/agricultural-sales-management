Public Interface ITransaccionesPedidoDetalle
    Inherits ITransaccionesGenericas(Of ModeloPedidoDetalle)
    Function elimRegistroPorIdPedido(id As Integer) As Task(Of Integer)
    Function verRegistroPorId(id As Integer) As Task(Of ModeloPedidoDetalle)
    Function verRegistrosPorIdCliente(id As Integer) As Task(Of List(Of ModeloPedidoDetalle))
    Function verRegistrosPorIdPedido(id As Integer) As Task(Of List(Of ModeloPedidoDetalle))
    Function verRegistrosPorIdClienteYRemitado(param As ModeloPedidoDetalle) As Task(Of List(Of ModeloPedidoDetalle))
    Function verRegistrosPorIdClienteYFacturado(param As ModeloPedidoDetalle) As Task(Of List(Of ModeloPedidoDetalle))
    Function verRegistrosSinRemitar_Cliente(id As Integer) As Task(Of List(Of ModeloPedidoDetalle))
    Function verRegistrosSinFacturar_idCliente(id As Integer) As Task(Of List(Of ModeloPedidoDetalle))
End Interface
