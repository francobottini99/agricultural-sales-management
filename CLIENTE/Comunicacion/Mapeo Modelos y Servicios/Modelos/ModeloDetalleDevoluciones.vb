Public Class ModeloDetalleDevoluciones
    Public Property IdDetalleDevoluciones As Integer
    Public Property Descripcion As String
    Public Property Cantidad As Double
    Public Property Unidad As String
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Eliminado As String
    Public Property AscArticulos As ModeloArticulos
    Public Property AscDetalleRemitoVenta As ModeloDetalleRemitoVenta
    Public Property AscDevoluciones As ModeloDevoluciones
    Public Property Err As Errores

    Public Sub New()
        AscArticulos = New ModeloArticulos()
        AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta()
        AscDevoluciones = New ModeloDevoluciones()
        Err = New Errores()
    End Sub
End Class
