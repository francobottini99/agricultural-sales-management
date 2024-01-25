Public Class TablaRemitosVentaMonedas
    Public Property idRemitoVtaMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property ascRemitosventa As TablaRemitosVenta

    Public Sub New()
        ascRemitosventa = New TablaRemitosVenta()
    End Sub
End Class
