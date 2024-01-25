Public Class DatosSistema
    Private _idDatosSistema As Integer
    Private _MonedaFacturacion As String
    Private _MonedaContable As String
    Private _AlicuotaIva1 As Double
    Private _AlicuotaIva2 As Double
    Private _AlicuotaIva3 As Double
    Private _AlicuotaMargen As Double
    Private _AlicuotaDesc1 As Double
    Private _AlicuotaDesc2 As Double
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario
    End Sub

    Public Sub New(idDatosSistema As Integer, monedaFacturacion As String, monedaContable As String, alicuotaIva1 As Double, alicuotaIva2 As Double,
                   alicuotaIva3 As Double, alicuotaMargen As Double, alicuotaDesc1 As Double, alicuotaDesc2 As Double, ascUsuarios As Usuario)

        Me.IdDatosSistema = idDatosSistema
        Me.MonedaFacturacion = monedaFacturacion
        Me.MonedaContable = monedaContable
        Me.AlicuotaIva1 = alicuotaIva1
        Me.AlicuotaIva2 = alicuotaIva2
        Me.AlicuotaIva3 = alicuotaIva3
        Me.AlicuotaMargen = alicuotaMargen
        Me.AlicuotaDesc1 = alicuotaDesc1
        Me.AlicuotaDesc2 = alicuotaDesc2
        Me.AscUsuarios = ascUsuarios
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDatosSistema As Integer
        Get
            Return _idDatosSistema
        End Get
        Set(value As Integer)
            _idDatosSistema = value
        End Set
    End Property

    Public Property MonedaFacturacion As String
        Get
            Return _MonedaFacturacion
        End Get
        Set(value As String)
            _MonedaFacturacion = value
        End Set
    End Property

    Public Property MonedaContable As String
        Get
            Return _MonedaContable
        End Get
        Set(value As String)
            _MonedaContable = value
        End Set
    End Property

    Public Property AlicuotaIva1 As Double
        Get
            Return _AlicuotaIva1
        End Get
        Set(value As Double)
            _AlicuotaIva1 = value
        End Set
    End Property

    Public Property AlicuotaIva2 As Double
        Get
            Return _AlicuotaIva2
        End Get
        Set(value As Double)
            _AlicuotaIva2 = value
        End Set
    End Property

    Public Property AlicuotaIva3 As Double
        Get
            Return _AlicuotaIva3
        End Get
        Set(value As Double)
            _AlicuotaIva3 = value
        End Set
    End Property

    Public Property AlicuotaMargen As Double
        Get
            Return _AlicuotaMargen
        End Get
        Set(value As Double)
            _AlicuotaMargen = value
        End Set
    End Property

    Public Property AlicuotaDesc1 As Double
        Get
            Return _AlicuotaDesc1
        End Get
        Set(value As Double)
            _AlicuotaDesc1 = value
        End Set
    End Property

    Public Property AlicuotaDesc2 As Double
        Get
            Return _AlicuotaDesc2
        End Get
        Set(value As Double)
            _AlicuotaDesc2 = value
        End Set
    End Property

    Public Property AscUsuarios As Usuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As Usuario)
            _ascUsuarios = value
        End Set
    End Property
#End Region

End Class
