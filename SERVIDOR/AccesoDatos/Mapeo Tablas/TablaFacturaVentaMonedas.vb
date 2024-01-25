Public Class TablaFacturaVentaMonedas
    Public Property idFacturaVtaMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property ascFacturaVenta As TablaFacturaVenta

    Public Sub New()
        ascFacturaVenta = New TablaFacturaVenta()
    End Sub
End Class
