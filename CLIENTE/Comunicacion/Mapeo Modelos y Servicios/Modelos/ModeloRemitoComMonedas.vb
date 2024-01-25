Public Class ModeloRemitoComMonedas
    Public Property IdRemitoComMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property AscRemitosCompra As ModeloRemitosCompra
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscRemitosCompra = New ModeloRemitosCompra()
    End Sub
End Class
