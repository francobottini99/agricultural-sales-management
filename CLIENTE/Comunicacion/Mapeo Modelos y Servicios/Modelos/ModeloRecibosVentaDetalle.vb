Public Class ModeloRecibosVentaDetalle
    Public Property IdRecibosVentaDetalle As Integer
    Public Property MedioPago As String
    Public Property NroComprobante As String
    Public Property EntidadEmisora As String
    Public Property SucursalEntidad As String
    Public Property Librador As String
    Public Property FechaCobro As Date
    Public Property Moneda As String
    Public Property Importe As Double
    Public Property Eliminado As String
    Public Property AscRecibosVenta As ModeloRecibosVenta
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscRecibosVenta = New ModeloRecibosVenta()
    End Sub
End Class
