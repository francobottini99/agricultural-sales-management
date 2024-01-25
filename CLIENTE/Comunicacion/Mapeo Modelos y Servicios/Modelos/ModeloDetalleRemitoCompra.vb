Public Class ModeloDetalleRemitoCompra
    Public Property IdDetalleRemitosCompra As Integer
    Public Property Descripcion As String
    Public Property Cantidad As Double
    Public Property Unidad As String
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Facturado As String
    Public Property Eliminado As String
    Public Property AscArticulos As ModeloArticulos
    Public Property AscRemitosCompra As ModeloRemitosCompra
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscArticulos = New ModeloArticulos()
        AscRemitosCompra = New ModeloRemitosCompra()
    End Sub
End Class
