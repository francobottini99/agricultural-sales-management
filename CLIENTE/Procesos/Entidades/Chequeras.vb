Public Class Chequeras
    Private _idChequera As Integer
    Private _NroCuenta As String
    Private _FechaAlta As Date
    Private _Banco As String
    Private _NroChqInicial As Integer
    Private _CantidadChq As Integer
    Private _ChqEmitidos As Integer
    Private _ChqAnulados As Integer
    Private _ChqDisponibles As Integer
    Private _Observaciones As String
    Private _Eliminada As String
    Private _ascUsuarios As Usuario


#Region "CONSTRUCTORES"
    Public Sub New(idChequera As Integer, nroCuenta As String, fechaAlta As Date, banco As String, nroChqInicial As Integer, cantidadChq As Integer,
                   chqEmitidos As Integer, chqAnulados As Integer, chqDisponibles As Integer, observaciones As String,
                   eliminada As String, ascUsuarios As Usuario)

        Me.IdChequera = idChequera
        Me.NroCuenta = nroCuenta
        Me.FechaAlta = fechaAlta
        Me.Banco = banco
        Me.NroChqInicial = nroChqInicial
        Me.CantidadChq = cantidadChq
        Me.ChqEmitidos = chqEmitidos
        Me.ChqAnulados = chqAnulados
        Me.ChqDisponibles = chqDisponibles
        Me.Observaciones = observaciones
        Me.Eliminada = eliminada
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(nroCuenta As String, fechaAlta As Date, banco As String, nroChqInicial As Integer, cantidadChq As Integer,
                    observaciones As String)

        Me.NroCuenta = nroCuenta
        Me.FechaAlta = fechaAlta
        Me.Banco = banco
        Me.NroChqInicial = nroChqInicial
        Me.CantidadChq = cantidadChq
        Me.ChqEmitidos = 0
        Me.ChqAnulados = 0
        Me.ChqDisponibles = cantidadChq
        Me.Observaciones = observaciones
        Me.Eliminada = "NO"
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub

    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdChequera As Integer
        Get
            Return _idChequera
        End Get
        Set(value As Integer)
            _idChequera = value
        End Set
    End Property

    Public Property NroCuenta As String
        Get
            Return _NroCuenta
        End Get
        Set(value As String)
            _NroCuenta = value
        End Set
    End Property

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(value As Date)
            _FechaAlta = value
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

    Public Property NroChqInicial As Integer
        Get
            Return _NroChqInicial
        End Get
        Set(value As Integer)
            _NroChqInicial = value
        End Set
    End Property

    Public Property CantidadChq As Integer
        Get
            Return _CantidadChq
        End Get
        Set(value As Integer)
            _CantidadChq = value
        End Set
    End Property

    Public Property ChqEmitidos As Integer
        Get
            Return _ChqEmitidos
        End Get
        Set(value As Integer)
            _ChqEmitidos = value
        End Set
    End Property

    Public Property ChqAnulados As Integer
        Get
            Return _ChqAnulados
        End Get
        Set(value As Integer)
            _ChqAnulados = value
        End Set
    End Property

    Public Property ChqDisponibles As Integer
        Get
            Return _ChqDisponibles
        End Get
        Set(value As Integer)
            _ChqDisponibles = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property

    Public Property Eliminada As String
        Get
            Return _Eliminada
        End Get
        Set(value As String)
            _Eliminada = value
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
