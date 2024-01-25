Public Class ModeloRemitosVentaMovimientos
    Public Property idRemitosVentasMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscDetalleRemitoVenta As ModeloDetalleRemitoVenta
    Public Property AscStock As ModeloStock
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario()
        AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta()
        AscStock = New ModeloStock()
        Err = New Errores()
    End Sub
End Class
