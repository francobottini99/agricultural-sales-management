Public Class ModeloCuentaCorrienteVenta
    Public Property IdCuentaCorrienteVentas As Integer
    Public Property Fecha As Date
    Public Property FechaVto As Date
    Public Property Comprobante As String
    Public Property Numero As String
    Public Property Detalle As String
    Public Property Debito As Double
    Public Property Credito As Double
    Public Property Eliminado As String
    Public Property Visible As String
    Public Property AscClientes As ModeloCliente
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
    End Sub
End Class
