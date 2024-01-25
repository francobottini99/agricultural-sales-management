Public Class TablaMovimientos_Remito_Factura
    Public Property idMovimientos_Remito_Factura As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascRemitosVentaMovimientos As TablaRemitosVentaMovimientos
    Public Property ascFacturaVentaMovimientos As TablaFacturaVentaMovimientos

    Public Sub New()
        ascFacturaVentaMovimientos = New TablaFacturaVentaMovimientos()
        ascRemitosVentaMovimientos = New TablaRemitosVentaMovimientos()
    End Sub
End Class
