Public Class TablaMovimientoValores
    Public Property idMovimientoValores As Integer
    Public Property Fecha As Date
    Public Property Movimiento As String
    Public Property OrigenDestino As String
    Public Property Eliminado As String
    Public Property ascValoresEnCartera As TablaValoresEnCartera
    Public Property ascCaja As TablaCaja

    Public Sub New()
        ascValoresEnCartera = New TablaValoresEnCartera()
        ascCaja = New TablaCaja()
    End Sub
End Class
