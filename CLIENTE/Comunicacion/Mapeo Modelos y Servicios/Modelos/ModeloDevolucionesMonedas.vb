Public Class ModeloDevolucionesMonedas
    Public Property IdDevolucionesMonedas As Integer
    Public Property TipoCambio As Double
    Public Property ImporteNeto As Double
    Public Property DescuentoGral As Double
    Public Property BaseImponible As Double
    Public Property IVA As Double
    Public Property ImporteTotal As Double
    Public Property Eliminado As String
    Public Property AscDevoluciones As ModeloDevoluciones
    Public Property Err As Errores

    Public Sub New()
        AscDevoluciones = New ModeloDevoluciones()
        Err = New Errores()
    End Sub
End Class
