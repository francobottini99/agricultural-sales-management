Public Class ModeloArticulos
    Public Property IdArticulo As Integer
    Public Property CodArticulo As String
    Public Property Detalle As String
    Public Property Unidad As String
    Public Property Costo As Double
    Public Property FechaActCosto As Date
    Public Property Precio As Double
    Public Property FechaActPrec As Date
    Public Property AlicuotaIVA As Double
    Public Property StkMinimo As Double
    Public Property Observaciones As String
    Public Property Imagen As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscRubro As ModeloRubro
    Public Property AscSubRubro As ModeloSubRubro
    Public Property Err As Errores

    Public Sub New()
        ascRubro = New ModeloRubro()
        ascUsuarios = New ModeloUsuario()
        AscSubRubro = New ModeloSubRubro()
        Err = New Errores()
    End Sub
End Class
