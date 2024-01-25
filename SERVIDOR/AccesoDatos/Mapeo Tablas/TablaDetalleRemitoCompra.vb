Public Class TablaDetalleRemitoCompra
    Public Property idDetalleRemitosCompra As Integer
    Public Property Descripcion As String
    Public Property Cantidad As Double
    Public Property Unidad As String
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Facturado As String
    Public Property Eliminado As String
    Public Property ascArticulos As TablaArticulos
    Public Property ascRemitosCompra As TablaRemitosCompra

    Public Sub New()
        ascArticulos = New TablaArticulos()
        ascRemitosCompra = New TablaRemitosCompra()
    End Sub
End Class
