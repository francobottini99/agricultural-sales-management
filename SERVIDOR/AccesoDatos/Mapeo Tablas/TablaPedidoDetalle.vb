Public Class TablaPedidoDetalle
    Public Property idPedidosDetalle As Integer
    Public Property Cantidad As Double
    Public Property Remitado As String
    Public Property Facturado As String
    Public Property Eliminado As String
    Public Property ascArticulos As TablaArticulos
    Public Property ascPedidos As TablaPedidos

    Public Sub New()
        ascArticulos = New TablaArticulos()
        ascPedidos = New TablaPedidos()
    End Sub
End Class
