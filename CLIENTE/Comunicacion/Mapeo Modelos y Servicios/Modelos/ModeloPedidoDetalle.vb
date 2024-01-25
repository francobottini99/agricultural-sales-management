Public Class ModeloPedidoDetalle
    Public Property IdPedidosDetalle As Integer
    Public Property Cantidad As Double
    Public Property Remitado As String
    Public Property Facturado As String
    Public Property Eliminado As String
    Public Property AscArticulos As ModeloArticulos
    Public Property AscPedidos As ModeloPedidos
    Public Property Err As Errores

    Public Sub New()
        AscArticulos = New ModeloArticulos()
        AscPedidos = New ModeloPedidos()
        Err = New Errores()
    End Sub
End Class
