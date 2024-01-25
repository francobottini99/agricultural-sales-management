Public Class TablaPedidos
    Public Property idPedidos As Integer
    Public Property NroPedido As String
    Public Property Fecha As Date
    Public Property FechaCierrePedido As Date
    Public Property Remitado As String
    Public Property Facturado As String
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios
    Public Property ascClientes As TablaClientes

    Public Sub New()
        ascClientes = New TablaClientes()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
