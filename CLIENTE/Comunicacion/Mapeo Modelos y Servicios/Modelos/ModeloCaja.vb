Public Class ModeloCaja
    Public Property IdCaja As Integer
    Public Property Fecha As Date
    Public Property Movimiento As String
    Public Property Comprobante As String
    Public Property Descripcion As String
    Public Property Moneda As String
    Public Property Ingreso As Double
    Public Property Egreso As Double
    Public Property Observaciones As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub
End Class
