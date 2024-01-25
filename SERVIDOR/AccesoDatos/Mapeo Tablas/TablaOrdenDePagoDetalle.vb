Public Class TablaOrdenDePagoDetalle
    Public Property idOrdenPagoDetalle As Integer
    Public Property MedioPago As String
    Public Property NroComprobante As String
    Public Property EntidadEmisora As String
    Public Property SucursalEntidad As String
    Public Property Librador As String
    Public Property FechaCobro As Date
    Public Property Moneda As String
    Public Property Importe As Double
    Public Property Eliminado As String
    Public Property ascOrdenDePago As TablaOrdenDePago

    Public Sub New()
        ascOrdenDePago = New TablaOrdenDePago()
    End Sub
End Class
