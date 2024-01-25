Public Class ModeloRemitosCompra
    Public Property IdRemitosCompra As Integer
    Public Property NroComprobante As String
    Public Property Fecha As Date
    Public Property Importe As Double
    Public Property Observaciones As String
    Public Property ImpOriginal As Integer
    Public Property ImpCopia As Integer
    Public Property Eliminado As String
    Public Property Facturado As String
    Public Property AscProveedores As ModeloProveedores
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscProveedores = New ModeloProveedores()
        AscUsuarios = New ModeloUsuario()
    End Sub
End Class
