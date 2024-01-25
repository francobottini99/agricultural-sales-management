Public Class TablaPedidoMovimientos
    Public Property idPedidosMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascPedidosDetalle As TablaPedidoDetalle
    Public Property ascStock As TablaStock

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascPedidosDetalle = New TablaPedidoDetalle()
        ascStock = New TablaStock()
    End Sub
End Class
