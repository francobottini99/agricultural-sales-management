Public Class Tributo
    Private _Id As Short
    Private _Desc As String
    Private _BaseImp As Double
    Private _Alic As Double
    Private _Importe As Double

    Public Sub New()
    End Sub

    Public Sub New(id As Short, desc As String, baseImp As Double, alic As Double, importe As Double)
        Me.Id = id
        Me.Desc = desc
        Me.BaseImp = baseImp
        Me.Alic = alic
        Me.Importe = importe
    End Sub

#Region "PROPIEDADES"
    Public Property Id As Short
        Get
            Return _Id
        End Get
        Set(value As Short)
            _Id = value
        End Set
    End Property

    Public Property Desc As String
        Get
            Return _Desc
        End Get
        Set(value As String)
            _Desc = value
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

    Public Property Alic As Double
        Get
            Return _Alic
        End Get
        Set(value As Double)
            _Alic = value
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
