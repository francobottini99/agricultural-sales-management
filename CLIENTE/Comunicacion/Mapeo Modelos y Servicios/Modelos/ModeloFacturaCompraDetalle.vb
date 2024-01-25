Public Class ModeloFacturaCompraDetalle
    Public Property IdFacturaCompraDetalle As Integer
    Public Property Descripcion As String
    Public Property Unidad As String
    Public Property Cantidad As Double
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Remitado As String
    Public Property Eliminado As String
    Public Property AscArticulos As ModeloArticulos
    Public Property AscFacturaCompra As ModeloFacturaCompra
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscArticulos = New ModeloArticulos()
        AscFacturaCompra = New ModeloFacturaCompra()
    End Sub
End Class
