Public Class ModeloMovimientos_Remito_Factura
    Public Property IdMovimientos_Remito_Factura As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscRemitosVentaMovimientos As ModeloRemitosVentaMovimientos
    Public Property AscFacturaVentaMovimientos As ModeloFacturaVentaMovimientos
    Public Property Err As Errores

    Public Sub New()
        AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos()
        AscFacturaVentaMovimientos = New ModeloFacturaVentaMovimientos()
        Err = New Errores()
    End Sub
End Class
