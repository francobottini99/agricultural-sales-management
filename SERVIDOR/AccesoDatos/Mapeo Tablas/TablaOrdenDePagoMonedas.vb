Public Class TablaOrdenDePagoMonedas
    Public Property idOrdenDePagoMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property ascOrdenDePago As TablaOrdenDePago

    Public Sub New()
        ascOrdenDePago = New TablaOrdenDePago()
    End Sub
End Class
