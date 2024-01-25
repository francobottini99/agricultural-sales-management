Public Interface ITransaccionesPedidoDetalle
    Inherits ITransaccionesGenericas(Of TablaPedidoDetalle)
    Function elimRegistroPorIdPedido(id As Integer) As Integer
    Function verRegistroPorId(id As Integer) As TablaPedidoDetalle
    Function verRegistrosPorIdCliente(id As Integer) As List(Of TablaPedidoDetalle)
    Function verRegistrosPorIdPedido(id As Integer) As List(Of TablaPedidoDetalle)
    Function modEstado(id As Integer, Remitado As String, Facturado As String) As Integer
    Function verRegistroPorIdCliente_Remitado(id As Integer, remitado As String) As List(Of TablaPedidoDetalle)
    Function verRegistroPorIdCliente_Facturado(id As Integer, facturado As String) As List(Of TablaPedidoDetalle)
    Function verUltimoId() As TablaPedidoDetalle
    Function modEstadoRemitado(id As Integer, Remitado As String) As Integer
    Function modEstadoFacturado(id As Integer, Facturado As String) As Integer
End Interface
