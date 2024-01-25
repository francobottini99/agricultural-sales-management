Public Class TablaRemitoComMonedas
    Public Property idRemitoComMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property ascRemitosCompra As TablaRemitosCompra

    Public Sub New()
        ascRemitosCompra = New TablaRemitosCompra()
    End Sub
End Class
