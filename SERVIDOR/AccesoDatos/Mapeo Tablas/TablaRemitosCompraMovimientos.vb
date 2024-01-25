Public Class TablaRemitosCompraMovimientos
    Public Property idRemitosCompraMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascDetalleRemtioCompra As TablaDetalleRemitoCompra
    Public Property ascStock As TablaStock

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascDetalleRemtioCompra = New TablaDetalleRemitoCompra()
        ascStock = New TablaStock()
    End Sub
End Class
