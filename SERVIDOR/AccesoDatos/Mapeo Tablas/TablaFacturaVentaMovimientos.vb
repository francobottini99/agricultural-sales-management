Public Class TablaFacturaVentaMovimientos
    Public Property idFacturaVentaMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascFacturaVentaDetalle As TablaFacturaVentaDetalle

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascFacturaVentaDetalle = New TablaFacturaVentaDetalle()
    End Sub
End Class
