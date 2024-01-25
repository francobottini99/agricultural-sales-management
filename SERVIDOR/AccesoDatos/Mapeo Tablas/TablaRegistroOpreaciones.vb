Public Class TablaRegistroOpreaciones
    Public Property idRegistroOperaciones As Integer
    Public Property Fecha As Date
    Public Property Hora As Date
    Public Property Operacion As String
    Public Property DetalleOperacion As String
    Public Property TablasAfectadas As String
    Public Property ProcedimientoAlmacenado As String
    Public Property DocumentosEmitidos As String
    Public Property ReportesEmitidos As String
    Public Property ResultadoOperacion As String
    Public Property DetalleResultado As String
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
