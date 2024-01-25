Public Class CbteAsoc
    Private _Tipo As WSAFIPFE.Factura.TipoComprobante
    Private _PtoVta As Integer
    Private _Nro As Long
    Private _Cuit As String
    Private _CbteFch As String

    Public Sub New()
    End Sub

    Public Sub New(tipo As WSAFIPFE.Factura.TipoComprobante, ptoVta As Integer, nro As Long, cuit As String, cbteFch As String)
        Me.Tipo = tipo
        Me.PtoVta = ptoVta
        Me.Nro = nro
        Me.Cuit = cuit
        Me.CbteFch = cbteFch
    End Sub

#Region "PROPIEDADES"
    Public Property Tipo As WSAFIPFE.Factura.TipoComprobante
        Get
            Return _Tipo
        End Get
        Set(value As WSAFIPFE.Factura.TipoComprobante)
            _Tipo = value
        End Set
    End Property

    Public Property PtoVta As Integer
        Get
            Return _PtoVta
        End Get
        Set(value As Integer)
            _PtoVta = value
        End Set
    End Property

    Public Property Nro As Long
        Get
            Return _Nro
        End Get
        Set(value As Long)
            _Nro = value
        End Set
    End Property

    Public Property Cuit As String
        Get
            Return _Cuit
        End Get
        Set(value As String)
            _Cuit = value
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
#End Region

End Class
