Public Class TablaDevolucionesMonedas
    Public Property idDevolucionesMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property ascDevoluciones As TablaDevoluciones

    Public Sub New()
        ascDevoluciones = New TablaDevoluciones()
    End Sub
End Class
