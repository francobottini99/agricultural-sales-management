Public Class TablaMovimientos_Reserva_Remito
    Public Property idMovimientos_Reserva_Remito As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascPedidosMovimientos As TablaPedidoMovimientos
    Public Property ascRemitosVentaMovimientos As TablaRemitosVentaMovimientos

    Public Sub New()
        ascPedidosMovimientos = New TablaPedidoMovimientos()
        ascRemitosVentaMovimientos = New TablaRemitosVentaMovimientos()
    End Sub
End Class
