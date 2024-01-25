Public Class TablaRecibosVentaMonedas
    Public Property idRecibosVentaMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property ascRecibosVenta As TablaRecibosVenta

    Public Sub New()
        ascRecibosVenta = New TablaRecibosVenta()
    End Sub
End Class
