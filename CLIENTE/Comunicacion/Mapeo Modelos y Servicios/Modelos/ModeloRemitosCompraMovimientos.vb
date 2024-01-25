Public Class ModeloRemitosCompraMovimientos
    Public Property IdRemitosCompraMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscDetalleRemtioCompra As ModeloDetalleRemitoCompra
    Public Property AscStock As ModeloStock
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
        AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra()
        AscStock = New ModeloStock()
    End Sub
End Class
