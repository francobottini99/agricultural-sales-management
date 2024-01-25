Public Class TablaFacturaCompraDetalle
    Public Property idFacturaCompraDetalle As Integer
    Public Property Descripcion As String
    Public Property Unidad As String
    Public Property Cantidad As Double
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Remitado As String
    Public Property Eliminado As String
    Public Property ascArticulos As TablaArticulos
    Public Property ascFacturaCompra As TablaFacturaCompra

    Public Sub New()
        ascArticulos = New TablaArticulos()
        ascFacturaCompra = New TablaFacturaCompra()
    End Sub
End Class
