Public Class TablaStock
    Public Property idStock As Integer
    Public Property Fecha As Date
    Public Property Movimiento As String
    Public Property Cantidad As Double
    Public Property Eliminado As String
    Public Property ascArticulos As TablaArticulos
    Public Property ascDepositos As TablaDepositos
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascArticulos = New TablaArticulos()
        ascDepositos = New TablaDepositos()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
