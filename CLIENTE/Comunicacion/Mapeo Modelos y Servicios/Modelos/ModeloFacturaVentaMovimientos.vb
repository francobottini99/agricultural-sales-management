Public Class ModeloFacturaVentaMovimientos
    Public Property IdFacturaVentaMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscFacturaVentaDetalle As ModeloFacturaVentaDetalle
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario()
        AscFacturaVentaDetalle = New ModeloFacturaVentaDetalle()
        Err = New Errores()
    End Sub
End Class
