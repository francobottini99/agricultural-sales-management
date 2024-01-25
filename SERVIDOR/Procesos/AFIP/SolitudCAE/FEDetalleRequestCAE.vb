Imports WSAFIPFE

Public Class FEDetalleRequestCAE
    Private _Concepto As EnumConceptos
    Private _DocTipo As Factura.TipoDocumento
    Private _DocNro As Long
    Private _CbteDesde As Long
    Private _CbteHasta As Long
    Private _CbteFch As String
    Private _ImpTotal As Double
    Private _ImpTotConc As Double
    Private _ImpNeto As Double
    Private _ImpOpEx As Double
    Private _ImpTrib As Double
    Private _ImpIVA As Double
    Private _FchServDesde As String
    Private _FchServHasta As String
    Private _FchVtoPago As String
    Private _MonId As String
    Private _MonCotiz As Double
    Private _CbtesAsoc As List(Of CbteAsoc)
    Private _Tributos As List(Of Tributo)
    Private _AlicIva As List(Of Iva)
    Private _Opcinales As List(Of Opcional)

    Public Sub New()
        CbtesAsoc = New List(Of CbteAsoc)
        Tributos = New List(Of Tributo)
        AlicIva = New List(Of Iva)
        Opcinales = New List(Of Opcional)
    End Sub

    Public Sub New(concepto As EnumConceptos, docTipo As Factura.TipoDocumento, docNro As Long, cbteDesde As Long, cbteHasta As Long, cbteFch As String,
                   impTotal As Double, impTotConc As Double, impNeto As Double, impOpEx As Double, impTrib As Double, impIVA As Double, fchServDesde As String,
                   fchServHasta As String, fchVtoPago As String, monId As String, monCotiz As Double, cbtesAsoc As List(Of CbteAsoc),
                   tributos As List(Of Tributo), alicIva As List(Of Iva), opcinales As List(Of Opcional))
        Me.Concepto = concepto
        Me.DocTipo = docTipo
        Me.DocNro = docNro
        Me.CbteDesde = cbteDesde
        Me.CbteHasta = cbteHasta
        Me.CbteFch = cbteFch
        Me.ImpTotal = impTotal
        Me.ImpTotConc = impTotConc
        Me.ImpNeto = impNeto
        Me.ImpOpEx = impOpEx
        Me.ImpTrib = impTrib
        Me.ImpIVA = impIVA
        Me.FchServDesde = fchServDesde
        Me.FchServHasta = fchServHasta
        Me.FchVtoPago = fchVtoPago
        Me.MonId = monId
        Me.MonCotiz = monCotiz
        Me.CbtesAsoc = cbtesAsoc
        Me.Tributos = tributos
        Me.AlicIva = alicIva
        Me.Opcinales = opcinales
    End Sub

#Region "PROPIEDADES"
    Public Property Concepto As EnumConceptos
        Get
            Return _Concepto
        End Get
        Set(value As EnumConceptos)
            _Concepto = value
        End Set
    End Property

    Public Property DocTipo As Factura.TipoDocumento
        Get
            Return _DocTipo
        End Get
        Set(value As Factura.TipoDocumento)
            _DocTipo = value
        End Set
    End Property

    Public Property DocNro As Long
        Get
            Return _DocNro
        End Get
        Set(value As Long)
            _DocNro = value
        End Set
    End Property

    Public Property CbteDesde As Long
        Get
            Return _CbteDesde
        End Get
        Set(value As Long)
            _CbteDesde = value
        End Set
    End Property

    Public Property CbteHasta As Long
        Get
            Return _CbteHasta
        End Get
        Set(value As Long)
            _CbteHasta = value
        End Set
    End Property

    Public Property CbteFch As String
        Get
            Return _CbteFch
        End Get
        Set(value As String)
            _CbteFch = value
        End Set
    End Property

    Public Property ImpTotal As Double
        Get
            Return _ImpTotal
        End Get
        Set(value As Double)
            _ImpTotal = value
        End Set
    End Property

    Public Property ImpTotConc As Double
        Get
            Return _ImpTotConc
        End Get
        Set(value As Double)
            _ImpTotConc = value
        End Set
    End Property

    Public Property ImpNeto As Double
        Get
            Return _ImpNeto
        End Get
        Set(value As Double)
            _ImpNeto = value
        End Set
    End Property

    Public Property ImpOpEx As Double
        Get
            Return _ImpOpEx
        End Get
        Set(value As Double)
            _ImpOpEx = value
        End Set
    End Property

    Public Property ImpTrib As Double
        Get
            Return _ImpTrib
        End Get
        Set(value As Double)
            _ImpTrib = value
        End Set
    End Property

    Public Property ImpIVA As Double
        Get
            Return _ImpIVA
        End Get
        Set(value As Double)
            _ImpIVA = value
        End Set
    End Property

    Public Property FchServDesde As String
        Get
            Return _FchServDesde
        End Get
        Set(value As String)
            _FchServDesde = value
        End Set
    End Property

    Public Property FchServHasta As String
        Get
            Return _FchServHasta
        End Get
        Set(value As String)
            _FchServHasta = value
        End Set
    End Property

    Public Property FchVtoPago As String
        Get
            Return _FchVtoPago
        End Get
        Set(value As String)
            _FchVtoPago = value
        End Set
    End Property

    Public Property MonId As String
        Get
            Return _MonId
        End Get
        Set(value As String)
            _MonId = value
        End Set
    End Property

    Public Property MonCotiz As Double
        Get
            Return _MonCotiz
        End Get
        Set(value As Double)
            _MonCotiz = value
        End Set
    End Property

    Public Property CbtesAsoc As List(Of CbteAsoc)
        Get
            Return _CbtesAsoc
        End Get
        Set(value As List(Of CbteAsoc))
            _CbtesAsoc = value
        End Set
    End Property

    Public Property Tributos As List(Of Tributo)
        Get
            Return _Tributos
        End Get
        Set(value As List(Of Tributo))
            _Tributos = value
        End Set
    End Property

    Public Property AlicIva As List(Of Iva)
        Get
            Return _AlicIva
        End Get
        Set(value As List(Of Iva))
            _AlicIva = value
        End Set
    End Property

    Public Property Opcinales As List(Of Opcional)
        Get
            Return _Opcinales
        End Get
        Set(value As List(Of Opcional))
            _Opcinales = value
        End Set
    End Property
#End Region

End Class
