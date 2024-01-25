Public Class ModeloChequera
    Public Property IdChequera As Integer
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
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub
End Class
