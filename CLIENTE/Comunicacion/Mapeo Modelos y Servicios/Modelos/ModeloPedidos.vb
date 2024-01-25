Public Class ModeloPedidos
    Public Property IdPedidos As Integer
    Public Property NroPedido As String
    Public Property Fecha As Date
    Public Property FechaCierrePedido As Date
    Public Property Remitado As String
    Public Property Facturado As String
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property AscClientes As ModeloCliente
    Public Property Err As Errores

    Public Sub New()
        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub
End Class
