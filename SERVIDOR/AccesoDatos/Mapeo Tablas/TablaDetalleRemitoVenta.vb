Public Class TablaDetalleRemitoVenta
    Public Property idDetalleRemitosVenta As Integer
    Public Property Descripcion As String
    Public Property Cantidad As Double
    Public Property Unidad As String
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Facturado As String
    Public Property Eliminado As String
    Public Property ascArticulos As TablaArticulos
    Public Property ascRemitosVenta As TablaRemitosVenta

    Public Sub New()
        ascArticulos = New TablaArticulos()
        ascRemitosVenta = New TablaRemitosVenta()
    End Sub
End Class
