Public Class TablaRemitosVentaMovimientos
    Public Property idRemitosVentasMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascDetalleRemitoVenta As TablaDetalleRemitoVenta
    Public Property ascStock As TablaStock

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascDetalleRemitoVenta = New TablaDetalleRemitoVenta()
        ascStock = New TablaStock()
    End Sub
End Class
