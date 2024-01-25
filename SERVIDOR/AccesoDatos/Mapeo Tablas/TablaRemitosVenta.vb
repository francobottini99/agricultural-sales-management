Public Class TablaRemitosVenta
    Public Property idRemitosVenta As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property Importe As Double
    Public Property Observaciones As String
    Public Property ImpOriginal As Integer
    Public Property ImpCopia As Integer
    Public Property Facturado As String
    Public Property Eliminado As String
    Public Property CAE As String
    Public Property FechaVtoCAE As Date
    Public Property ascClientes As TablaClientes
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascClientes = New TablaClientes()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
