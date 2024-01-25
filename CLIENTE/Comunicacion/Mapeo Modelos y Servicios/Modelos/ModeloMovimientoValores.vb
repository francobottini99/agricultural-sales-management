Public Class ModeloMovimientoValores
    Public Property IdMovimientoValores As Integer
    Public Property Fecha As Date
    Public Property Movimiento As String
    Public Property OrigenDestino As String
    Public Property Eliminado As String
    Public Property AscValoresEnCartera As ModeloValoresEnCartera
    Public Property AscCaja As ModeloCaja
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscCaja = New ModeloCaja()
        AscValoresEnCartera = New ModeloValoresEnCartera()
    End Sub
End Class
