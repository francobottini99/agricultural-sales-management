Public Class TablaArticulos
    Public Property idArticulo As Integer
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
    Public Property ascUsuarios As New TablaUsuarios
    Public Property ascRubro As New TablaRubro
    Public Property ascSubRubro As New TablaSubRubro

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascRubro = New TablaRubro()
        ascSubRubro = New TablaSubRubro()
    End Sub
End Class

