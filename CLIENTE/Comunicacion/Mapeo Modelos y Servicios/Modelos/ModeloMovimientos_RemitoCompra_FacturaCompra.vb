Public Class ModeloMovimientos_RemitoCompra_FacturaCompra
    Public Property IdMovimientos_RemitoCompra_FacturaCompra As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscRemitosCompraMovimientos As ModeloRemitosCompraMovimientos
    Public Property AscFacturaCompraMovimientos As ModeloFacturaCompraMovimientos
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscRemitosCompraMovimientos = New ModeloRemitosCompraMovimientos()
        AscFacturaCompraMovimientos = New ModeloFacturaCompraMovimientos()
    End Sub
End Class
