Public Class TablaFacturaCompraMovimientos
    Public Property idFacturaCompraMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascFacturaCompraDetalle As TablaFacturaCompraDetalle

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascFacturaCompraDetalle = New TablaFacturaCompraDetalle()
    End Sub
End Class
