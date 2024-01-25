Public Class ModeloParidadCambiaria
    Public Property IdParidadCambiaria As Integer
    Public Property Fecha As DateTime
    Public Property CotizacionCompra As Double
    Public Property CotizacionVenta As Double
    Public Property Eliminado As String
    Public Property AscMonedas As ModeloMonedas
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscMonedas = New ModeloMonedas()
    End Sub
End Class

