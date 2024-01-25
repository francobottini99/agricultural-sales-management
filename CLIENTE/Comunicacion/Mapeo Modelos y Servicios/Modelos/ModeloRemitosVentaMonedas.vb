Public Class ModeloRemitosVentaMonedas
    Public Property IdRemitoVtaMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property AscRemitosventa As ModeloRemitosVenta
    Public Property Err As Errores

    Public Sub New()
        AscRemitosventa = New ModeloRemitosVenta()
        Err = New Errores()
    End Sub
End Class
