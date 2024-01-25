Public Class TablaCaja
    Public Property idCaja As Integer
    Public Property Fecha As Date
    Public Property Movimiento As String
    Public Property Comprobante As String
    Public Property Detalle As String
    Public Property Moneda As String
    Public Property Ingreso As Double
    Public Property Egreso As Double
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
