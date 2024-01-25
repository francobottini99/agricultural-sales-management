Public Class ModeloDetalleCheque
    Public Property IdDetalleCheque As Integer
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
    Public Property AscChequera As ModeloChequera
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
        AscChequera = New ModeloChequera()
    End Sub
End Class
