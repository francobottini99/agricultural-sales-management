Public Class ModeloOrdenDePagoDetalle
    Public Property IdOrdenPagoDetalle As Integer
    Public Property MedioPago As String
    Public Property NroComprobante As String
    Public Property EntidadEmisora As String
    Public Property SucursalEntidad As String
    Public Property Librador As String
    Public Property FechaCobro As Date
    Public Property Moneda As String
    Public Property Importe As Double
    Public Property Eliminado As String
    Public Property AscOrdenDePago As ModeloOrdenDePago
    Public Property Err As Errores

    Public Sub New()
        AscOrdenDePago = New ModeloOrdenDePago()
        Err = New Errores()
    End Sub
End Class
