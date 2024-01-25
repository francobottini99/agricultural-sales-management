Public Class ServicioPedidos
    Public Property Pedido As ModeloPedidos
    Public Property DetallePedido As ModeloPedidoDetalle
    Public Property Stock As ModeloStock
    Public Property listaStock As List(Of ModeloStock)
    Public Property listaDetallePedido As List(Of ModeloPedidoDetalle)
    Public Property listaPedidosMovimientos As List(Of ModeloPedidoMovimientos)
    Public Property numeracion As ModeloNumeracion

    Public Sub New()
        Pedido = New ModeloPedidos()
        DetallePedido = New ModeloPedidoDetalle()
        Stock = New ModeloStock()
        listaStock = New List(Of ModeloStock)
        listaDetallePedido = New List(Of ModeloPedidoDetalle)()
        listaPedidosMovimientos = New List(Of ModeloPedidoMovimientos)()
        numeracion = New ModeloNumeracion()
    End Sub

End Class
