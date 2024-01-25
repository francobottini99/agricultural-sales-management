Public Class TablaFacturaComMonedas
    Public Property idFacturaComMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property ascFacturaCompra As TablaFacturaCompra

    Public Sub New()
        ascFacturaCompra = New TablaFacturaCompra()
    End Sub
End Class
