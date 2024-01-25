Public Class ModeloComprobantes
    Public Property IdComprobantes As Integer
    Public Property Nombre As String
    Public Property Tipo As String
    Public Property Copias As Integer
    Public Property Leyenda As String
    Public Property Encabezado As String
    Public Property LeyendaEnc As String
    Public Property Pie As String
    Public Property LeyendaPie As String
    Public Property CantidadCompEmitidos As Integer
    Public Property CantidadCopiasComp As Integer
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub
End Class
