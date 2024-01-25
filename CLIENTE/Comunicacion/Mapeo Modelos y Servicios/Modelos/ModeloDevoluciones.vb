Public Class ModeloDevoluciones
    Public Property IdDevoluciones As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property Importe As Double
    Public Property Observaciones As String
    Public Property ImpOriginal As Integer
    Public Property ImpCopia As Integer
    Public Property Eliminado As String
    Public Property AscClientes As ModeloCliente
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub
End Class
