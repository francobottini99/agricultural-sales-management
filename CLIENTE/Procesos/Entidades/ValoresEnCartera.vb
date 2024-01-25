Public Class ValoresEnCartera
    Private _idValoresEnCartera As Integer
    Private _TipoValor As String
    Private _Banco As String
    Private _Sucursal As String
    Private _Numero As String
    Private _Librador As String
    Private _FechaCobro As Date
    Private _Moneda As String
    Private _Importe As Double
    Private _Disponible As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idValoresEnCartera As Integer, tipoValor As String, numero As String, librador As String, fechaCobro As Date,
                   importe As Double, disponible As String, eliminado As String, ascUsuarios As Usuario, ascBancos As Bancos, moneda As String, banco As String, sucursal As String)
        Me.IdValoresEnCartera = idValoresEnCartera
        Me.TipoValor = tipoValor
        Me.Numero = numero
        Me.Librador = librador
        Me.FechaCobro = fechaCobro
        Me.Importe = importe
        Me.Disponible = disponible
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Moneda = moneda
        Me.Banco = banco
        Me.Sucursal = sucursal
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdValoresEnCartera As Integer
        Get
            Return _idValoresEnCartera
        End Get
        Set(value As Integer)
            _idValoresEnCartera = value
        End Set
    End Property

    Public Property TipoValor As String
        Get
            Return _TipoValor
        End Get
        Set(value As String)
            _TipoValor = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _Numero
        End Get
        Set(value As String)
            _Numero = value
        End Set
    End Property

    Public Property Librador As String
        Get
            Return _Librador
        End Get
        Set(value As String)
            _Librador = value
        End Set
    End Property

    Public Property FechaCobro As Date
        Get
            Return _FechaCobro
        End Get
        Set(value As Date)
            _FechaCobro = value
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

    Public Property Disponible As String
        Get
            Return _Disponible
        End Get
        Set(value As String)
            _Disponible = value
        End Set
    End Property

    Public Property Eliminado As String
        Get
            Return _Eliminado
        End Get
        Set(value As String)
            _Eliminado = value
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

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Banco As String
        Get
            Return _Banco
        End Get
        Set(value As String)
            _Banco = value
        End Set
    End Property

    Public Property Sucursal As String
        Get
            Return _Sucursal
        End Get
        Set(value As String)
            _Sucursal = value
        End Set
    End Property
#End Region
End Class
