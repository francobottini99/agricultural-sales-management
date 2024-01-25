Public Class ModeloMovimientos_Reserva_Remito
    Public Property IdMovimientos_Reserva_Remito As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscPedidosMovimientos As ModeloPedidoMovimientos
    Public Property AscRemitosVentaMovimientos As ModeloRemitosVentaMovimientos
    Public Property Err As Errores

    Public Sub New()
        AscPedidosMovimientos = New ModeloPedidoMovimientos()
        AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos()
        Err = New Errores()
    End Sub
End Class
