Public Class TablaFacturaVentaDetalle
    Public Property idFacturaVentaDetalle As Integer
    Public Property Descripcion As String
    Public Property Unidad As String
    Public Property Cantidad As Double
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Remitado As String
    Public Property Eliminado As String
    Public Property ascFacturaVenta As TablaFacturaVenta
    Public Property ascArticulos As TablaArticulos

    Public Sub New()
        ascFacturaVenta = New TablaFacturaVenta()
        ascArticulos = New TablaArticulos()
    End Sub

End Class
