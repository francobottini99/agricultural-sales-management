Public Class ModeloDetalleRemitoVenta
    Public Property IdDetalleRemitosVenta As Integer
    Public Property Descripcion As String
    Public Property Cantidad As Double
    Public Property Unidad As String
    Public Property Precio As Double
    Public Property Importe As Double
    Public Property AlicuotaIVA As Double
    Public Property Facturado As String
    Public Property Eliminado As String
    Public Property AscArticulos As ModeloArticulos
    Public Property AscRemitosVenta As ModeloRemitosVenta
    Public Property Err As Errores

    Public Sub New()
        AscArticulos = New ModeloArticulos()
        AscRemitosVenta = New ModeloRemitosVenta()
        Err = New Errores()
    End Sub
End Class
