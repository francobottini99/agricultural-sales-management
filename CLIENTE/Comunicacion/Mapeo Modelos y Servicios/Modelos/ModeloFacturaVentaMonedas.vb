Public Class ModeloFacturaVentaMonedas
    Public Property IdFacturaVtaMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property AscFacturaVenta As ModeloFacturaVenta
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscFacturaVenta = New ModeloFacturaVenta()
    End Sub
End Class
