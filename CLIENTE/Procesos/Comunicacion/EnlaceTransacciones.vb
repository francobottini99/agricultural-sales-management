Imports Comunicacion

Public MustInherit Class EnlaceTransacciones(Of Entidad As {Transacciones, New})
    Protected Property Transaccion As Entidad

#Region "CONSTRUCTORES"
    Public Sub New()
        Transaccion = New Entidad
    End Sub
#End Region
End Class
