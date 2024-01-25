Public Class TablaParidadCambiaria
    Public Property idParidadCambiaria As Integer
    Public Property Fecha As DateTime
    Public Property CotizacionCompra As Double
    Public Property CotizacionVenta As Double
    Public Property Eliminado As String
    Public Property ascMonedas As TablaMonedas

    Public Sub New()
        ascMonedas = New TablaMonedas()
    End Sub
End Class

