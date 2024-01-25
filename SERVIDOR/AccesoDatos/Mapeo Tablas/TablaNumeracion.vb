Public Class TablaNumeracion
    Public Property idNumeracion As Integer
    Public Property PuntoVenta As Integer
    Public Property Descripcion As String
    Public Property NroReserva As Integer
    Public Property NroRemito As Integer
    Public Property NroDevolucion As Integer
    Public Property NroFacturaA As Integer
    Public Property NroFacturaB As Integer
    Public Property NroFacturaC As Integer
    Public Property NroFacturaX As Integer
    Public Property NroNotaCreditoA As Integer
    Public Property NroNotaCreditoB As Integer
    Public Property NroNotaCreditoC As Integer
    Public Property NroNotaCreditoX As Integer
    Public Property NroNotaDebitoA As Integer
    Public Property NroNotaDebitoB As Integer
    Public Property NroNotaDebitoC As Integer
    Public Property NroNotaDebitoX As Integer
    Public Property NroRecibo As Integer
    Public Property NroOrdenCompra As Integer
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
