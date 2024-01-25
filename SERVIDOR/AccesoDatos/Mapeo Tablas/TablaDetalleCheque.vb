Public Class TablaDetalleCheque
    Public Property idDetalleCheque As Integer
    Public Property Numero As Integer
    Public Property FechaEmision As Date
    Public Property FechaCobro As Date
    Public Property PlazoDias As Integer
    Public Property Importe As Double
    Public Property Destino As String
    Public Property EnDisponiblidad As String
    Public Property Cobrado As String
    Public Property Anulado As String
    Public Property Modificado As String
    Public Property Modificacion As String
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property ascChequera As TablaChequera
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
        ascChequera = New TablaChequera()
    End Sub

End Class
