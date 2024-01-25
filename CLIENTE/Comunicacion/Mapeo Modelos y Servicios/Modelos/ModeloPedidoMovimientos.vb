Public Class ModeloPedidoMovimientos
    Public Property IdPedidosMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscPedidosDetalle As ModeloPedidoDetalle
    Public Property AscStock As ModeloStock
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario()
        AscPedidosDetalle = New ModeloPedidoDetalle()
        AscStock = New ModeloStock()
        Err = New Errores()
    End Sub
End Class
