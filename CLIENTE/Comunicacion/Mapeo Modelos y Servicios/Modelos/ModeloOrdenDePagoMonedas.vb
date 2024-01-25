Public Class ModeloOrdenDePagoMonedas
    Public Property IdOrdenDePagoMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property AscOrdenDePago As ModeloOrdenDePago
    Public Property Err As Errores

    Public Sub New()
        AscOrdenDePago = New ModeloOrdenDePago()
        Err = New Errores()
    End Sub
End Class
