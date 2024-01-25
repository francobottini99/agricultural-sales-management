Public Class TablaChequera
    Public Property idChequera As Integer
    Public Property NroCuenta As String
    Public Property FechaAlta As Date
    Public Property Banco As String
    Public Property NroChqInicial As Integer
    Public Property CantidadChq As Integer
    Public Property ChqEmitidos As Integer
    Public Property ChqAnulados As Integer
    Public Property ChqDisponibles As Integer
    Public Property Observaciones As String
    Public Property Eliminada As String
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
