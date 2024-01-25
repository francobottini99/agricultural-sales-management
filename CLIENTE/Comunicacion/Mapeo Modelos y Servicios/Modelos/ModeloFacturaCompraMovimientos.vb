Public Class ModeloFacturaCompraMovimientos
    Public Property IdFacturaCompraMovimientos As Integer
    Public Property Fecha As Date
    Public Property Tipo As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscFacturaCompraDetalle As ModeloFacturaCompraDetalle
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
        AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle()
    End Sub
End Class
