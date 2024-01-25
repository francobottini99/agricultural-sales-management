Public Class TablaCuentaCorrienteVenta
    Public Property idCuentaCorrienteVentas As Integer
    Public Property Fecha As Date
    Public Property FechaVto As Date
    Public Property Comprobante As String
    Public Property Numero As String
    Public Property Detalle As String
    Public Property Debito As Double
    Public Property Credito As Double
    Public Property Eliminado As String
    Public Property Visible As String
    Public Property ascClientes As TablaClientes
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascClientes = New TablaClientes()
        ascUsuarios = New TablaUsuarios()
    End Sub

End Class
