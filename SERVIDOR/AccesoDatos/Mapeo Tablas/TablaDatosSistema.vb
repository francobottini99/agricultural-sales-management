Public Class TablaDatosSistema
    Public Property idDatosSistema As Integer
    Public Property MonedaFacturacion As String
    Public Property MonedaContable As String
    Public Property AlicuotaIva1 As Double
    Public Property AlicuotaIva2 As Double
    Public Property AlicuotaIva3 As Double
    Public Property AlicuotaMargen As Double
    Public Property AlicuotaDesc1 As Double
    Public Property AlicuotaDesc2 As Double
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
