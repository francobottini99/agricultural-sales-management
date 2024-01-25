Public Class ModeloValoresEnCartera
    Public Property idValoresEnCartera As Integer
    Public Property TipoValor As String
    Public Property Banco As String
    Public Property Sucursal As String
    Public Property Numero As String
    Public Property Librador As String
    Public Property FechaCobro As Date
    Public Property Moneda As String
    Public Property Importe As Double
    Public Property Disponible As String
    Public Property Eliminado As String
    Public Property ascUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        ascUsuarios = New ModeloUsuario()
    End Sub
End Class
