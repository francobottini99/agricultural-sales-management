Public Class TablaDetalleDevoluciones
    Public Property idDetalleDevoluciones As Integer
    Public Property Descripcion As String
    Public Property Cantidad As Double
    Public Property Unidad As String
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Eliminado As String
    Public Property ascArticulos As TablaArticulos
    Public Property ascDetalleRemitoVenta As TablaDetalleRemitoVenta
    Public Property ascDevoluciones As TablaDevoluciones

    Public Sub New()
        ascArticulos = New TablaArticulos()
        ascDetalleRemitoVenta = New TablaDetalleRemitoVenta()
        ascDevoluciones = New TablaDevoluciones()
    End Sub
End Class
