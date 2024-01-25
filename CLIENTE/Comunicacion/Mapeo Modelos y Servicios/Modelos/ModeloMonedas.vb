Public Class ModeloMonedas
    Public Property IdMonedas As Integer
    Public Property Tipo As String
    Public Property Moneda As String
    Public Property Simbolo As String
    Public Property Eliminado As String
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
    End Sub
End Class