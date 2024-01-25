Public Class ModeloFacturaVentaDetalle
    Public Property IdFacturaVentaDetalle As Integer
    Public Property Descripcion As String
    Public Property Unidad As String
    Public Property Cantidad As Double
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Remitado As String
    Public Property Eliminado As String
    Public Property AscFacturaVenta As ModeloFacturaVenta
    Public Property AscArticulos As ModeloArticulos
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscFacturaVenta = New ModeloFacturaVenta()
        AscArticulos = New ModeloArticulos()
    End Sub
End Class
