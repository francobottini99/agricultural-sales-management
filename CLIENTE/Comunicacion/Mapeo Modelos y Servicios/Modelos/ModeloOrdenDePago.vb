Public Class ModeloOrdenDePago
    Public Property IdOrdenDePago As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property ImportePesos As Double
    Public Property ImporteDolares As Double
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscProveedores As ModeloProveedores
    Public Property AscCuentaCorrienteCompra As ModeloCuentaCorrienteCompra
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario()
        AscProveedores = New ModeloProveedores()
        AscCuentaCorrienteCompra = New ModeloCuentaCorrienteCompra()
        Err = New Errores()
    End Sub
End Class
