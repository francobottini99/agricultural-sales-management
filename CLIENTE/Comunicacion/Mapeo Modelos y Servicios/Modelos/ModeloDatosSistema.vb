Public Class ModeloDatosSistema
    Public Property IdDatosSistema As Integer
    Public Property MonedaFacturacion As String
    Public Property MonedaContable As String
    Public Property AlicuotaIva1 As Double
    Public Property AlicuotaIva2 As Double
    Public Property AlicuotaIva3 As Double
    Public Property AlicuotaMargen As Double
    Public Property AlicuotaDesc1 As Double
    Public Property AlicuotaDesc2 As Double
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        AscUsuarios = New ModeloUsuario
        Err = New Errores()
    End Sub
End Class
