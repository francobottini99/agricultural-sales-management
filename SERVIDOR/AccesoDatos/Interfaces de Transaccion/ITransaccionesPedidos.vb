Public Interface ITransaccionesPedidos
    Inherits ITransaccionesGenericas(Of TablaPedidos)
    Function modFechaCierrePedido(id As Integer, fec As Date) As Integer
    Function verUltimoId() As TablaPedidos
    Function verPedidosPorIDpedido(id As Integer) As TablaPedidos
    Function modEstado(id As Integer, Remitado As String, Facturado As String) As Integer
    Function modEstadoRemitado(id As Integer, Remitado As String) As Integer
    Function verRegistrosFacturadoRemitado(facturado As String, remitado As String) As List(Of TablaPedidos)
    Function verRegistrosRemitado(remitado As String) As List(Of TablaPedidos)
    Function modEstadoFacturado(id As Integer, Facturado As String) As Integer
End Interface
