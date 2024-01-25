Public Class TablaCuentaCorrienteCompra
    Public Property idCuentaCorrienteCompra As Integer
    Public Property Fecha As Date
    Public Property FechaVto As Date
    Public Property Comprobante As String
    Public Property Numero As String
    Public Property Detalle As String
    Public Property Debito As Double
    Public Property Credito As Double
    Public Property Eliminado As String
    Public Property Visible As String
    Public Property ascProveedores As TablaProveedores
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascProveedores = New TablaProveedores()
        ascUsuarios = New TablaUsuarios()
    End Sub

End Class
