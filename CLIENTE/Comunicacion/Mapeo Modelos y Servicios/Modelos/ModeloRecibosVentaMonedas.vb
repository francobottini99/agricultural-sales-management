Public Class ModeloRecibosVentaMonedas
    Public Property IdRecibosVentaMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property AscRecibosVenta As ModeloRecibosVenta
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscRecibosVenta = New ModeloRecibosVenta()
    End Sub
End Class
