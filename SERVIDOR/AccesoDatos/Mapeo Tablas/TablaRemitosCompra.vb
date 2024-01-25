Public Class TablaRemitosCompra
    Public Property idRemitosCompra As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property Importe As Double
    Public Property Observaciones As String
    Public Property ImpOriginal As Integer
    Public Property ImpCopia As Integer
    Public Property Eliminado As String
    Public Property Facturado As String
    Public Property ascProveedores As TablaProveedores
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascProveedores = New TablaProveedores()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
