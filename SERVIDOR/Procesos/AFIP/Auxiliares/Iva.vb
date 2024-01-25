Public Enum AlicuotasIVA
    I21 = 5
    I10_5 = 4
    I27 = 6
    I5 = 8
    I2_5 = 9
    I0 = 3
End Enum

Public Class Iva
    Private _Id As AlicuotasIVA
    Private _BaseImp As Double
    Private _Importe As Double

    Public Sub New()
    End Sub

    Public Sub New(id As AlicuotasIVA, baseImp As Double, importe As Double)
        Me.Id = id
        Me.BaseImp = baseImp
        Me.Importe = importe
    End Sub

#Region "PROPIEDADES"
    Public Property Id As AlicuotasIVA
        Get
            Return _Id
        End Get
        Set(value As AlicuotasIVA)
            _Id = value
        End Set
    End Property

    Public Property BaseImp As Double
        Get
            Return _BaseImp
        End Get
        Set(value As Double)
            _BaseImp = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _Importe
        End Get
        Set(value As Double)
            _Importe = value
        End Set
    End Property
#End Region

End Class
