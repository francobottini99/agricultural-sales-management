Public Class ModeloStock
    Public IdStock As Integer
    Public Fecha As Date
    Public Movimiento As String
    Public Cantidad As Double
    Public Eliminado As String
    Public AscArticulos As ModeloArticulos
    Public AscDepositos As ModeloDepositos
    Public AscUsuarios As ModeloUsuario
    Public Err As Errores

    Public Sub New()
        ascArticulos = New ModeloArticulos()
        ascDepositos = New ModeloDepositos()
        ascUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub
End Class
