Public Class TablaMovimientos_RemitoCompra_FacturaCompra
    Public Property idMovimientos_RemitoCompra_FacturaCompra As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascRemitosCompraMovimientos As TablaRemitosCompraMovimientos
    Public Property ascFacturaCompraMovimientos As TablaFacturaCompraMovimientos

    Public Sub New()
        ascRemitosCompraMovimientos = New TablaRemitosCompraMovimientos()
        ascFacturaCompraMovimientos = New TablaFacturaCompraMovimientos()
    End Sub
End Class
