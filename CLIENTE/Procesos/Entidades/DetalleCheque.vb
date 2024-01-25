Public Class DetalleCheque
    Private _idDetalleCheque As Integer
    Private _Numero As Integer
    Private _FechaEmision As Date
    Private _FechaCobro As Date
    Private _PlazoDias As Integer
    Private _Importe As Double
    Private _Destino As String
    Private _EnDisponiblidad As String
    Private _Cobrado As String
    Private _Anulado As String
    Private _Modificado As String
    Private _Modificacion As String
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascChequera As Chequeras
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscChequera = New Chequeras()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idDetalleCheque As Integer, numero As Integer, fechaEmision As Date, fechaCobro As Date, plazoDias As Integer,
               importe As Double, destino As String, enDisponiblidad As String, cobrado As String, anulado As String,
               modificado As String, modificacion As String, observaciones As String, eliminado As String,
               ascChequera As Chequeras, ascUsuarios As Usuario)
        Me.IdDetalleCheque = idDetalleCheque
        Me.Numero = numero
        Me.FechaEmision = fechaEmision
        Me.FechaCobro = fechaCobro
        Me.PlazoDias = plazoDias
        Me.Importe = importe
        Me.Destino = destino
        Me.EnDisponiblidad = enDisponiblidad
        Me.Cobrado = cobrado
        Me.Anulado = anulado
        Me.Modificado = modificado
        Me.Modificacion = modificacion
        Me.Observaciones = observaciones
        Me.Eliminado = eliminado
        Me.AscChequera = ascChequera
        Me.AscUsuarios = ascUsuarios
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDetalleCheque As Integer
        Get
            Return _idDetalleCheque
        End Get
        Set(value As Integer)
            _idDetalleCheque = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return _Numero
        End Get
        Set(value As Integer)
            _Numero = value
        End Set
    End Property

    Public Property FechaEmision As Date
        Get
            Return _FechaEmision
        End Get
        Set(value As Date)
            _FechaEmision = value
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

    Public Property PlazoDias As Integer
        Get
            Return _PlazoDias
        End Get
        Set(value As Integer)
            _PlazoDias = value
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

    Public Property Destino As String
        Get
            Return _Destino
        End Get
        Set(value As String)
            _Destino = value
        End Set
    End Property

    Public Property EnDisponiblidad As String
        Get
            Return _EnDisponiblidad
        End Get
        Set(value As String)
            _EnDisponiblidad = value
        End Set
    End Property

    Public Property Cobrado As String
        Get
            Return _Cobrado
        End Get
        Set(value As String)
            _Cobrado = value
        End Set
    End Property

    Public Property Anulado As String
        Get
            Return _Anulado
        End Get
        Set(value As String)
            _Anulado = value
        End Set
    End Property

    Public Property Modificado As String
        Get
            Return _Modificado
        End Get
        Set(value As String)
            _Modificado = value
        End Set
    End Property

    Public Property Modificacion As String
        Get
            Return _Modificacion
        End Get
        Set(value As String)
            _Modificacion = value
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

    Public Property Eliminado As String
        Get
            Return _Eliminado
        End Get
        Set(value As String)
            _Eliminado = value
        End Set
    End Property

    Public Property AscChequera As Chequeras
        Get
            Return _ascChequera
        End Get
        Set(value As Chequeras)
            _ascChequera = value
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
