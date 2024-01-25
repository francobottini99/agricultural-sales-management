Public Class ModeloFacturaComMonedas
    Public Property IdFacturaComMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property AscFacturaCompra As ModeloFacturaCompra
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscFacturaCompra = New ModeloFacturaCompra()
    End Sub
End Class
