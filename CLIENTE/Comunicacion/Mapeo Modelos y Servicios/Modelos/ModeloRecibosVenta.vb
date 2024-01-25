Public Class ModeloRecibosVenta
    Public Property IdRecibosVenta As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property ImportePesos As Double
    Public Property ImporteDolares As Double
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscClientes As ModeloCliente
    Public Property AscCuentaCorrienteVenta As ModeloCuentaCorrienteVenta
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
        AscCuentaCorrienteVenta = New ModeloCuentaCorrienteVenta()
    End Sub
End Class
