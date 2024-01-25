Public Class TablaRecibosVenta
    Public Property idRecibosVenta As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property ImportePesos As Double
    Public Property ImporteDolares As Double
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascClientes As TablaClientes
    Public Property ascCuentaCorrienteVenta As TablaCuentaCorrienteVenta

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascClientes = New TablaClientes()
        ascCuentaCorrienteVenta = New TablaCuentaCorrienteVenta()
    End Sub
End Class
