Public Class TablaOrdenDePago
    Public Property idOrdenDePago As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property ImportePesos As Double
    Public Property ImporteDolares As Double
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascProveedores As TablaProveedores
    Public Property ascCuentaCorrienteCompra As TablaCuentaCorrienteCompra

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascProveedores = New TablaProveedores()
        ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra()
    End Sub
End Class
