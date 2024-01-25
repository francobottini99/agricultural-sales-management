Public Class TablaRecibosVentaDetalle
    Public Property idRecibosVentaDetalle As Integer
    Public Property MedioPago As String
    Public Property NroComprobante As String
    Public Property EntidadEmisora As String
    Public Property SucursalEntidad As String
    Public Property Librador As String
    Public Property FechaCobro As Date
    Public Property Moneda As String
    Public Property Importe As Double
    Public Property Eliminado As String
    Public Property ascRecibosVenta As TablaRecibosVenta

    Public Sub New()
        ascRecibosVenta = New TablaRecibosVenta()
    End Sub
End Class
