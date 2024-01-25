Imports WSAFIPFE

Public Class FECabeceraRequest
    Private _CantReg As Integer
    Private _PtoVta As Integer
    Private _CbteTipo As WSAFIPFE.Factura.TipoComprobante

    Public Sub New()
    End Sub

    Public Sub New(cantReg As Integer, ptoVta As Integer, cbteTipo As Factura.TipoComprobante)
        Me.CantReg = cantReg
        Me.PtoVta = ptoVta
        Me.CbteTipo = cbteTipo
    End Sub

#Region "PROPIEDADES"
    Public Property CantReg As Integer
        Get
            Return _CantReg
        End Get
        Set(value As Integer)
            _CantReg = value
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

    Public Property CbteTipo As Factura.TipoComprobante
        Get
            Return _CbteTipo
        End Get
        Set(value As Factura.TipoComprobante)
            _CbteTipo = value
        End Set
    End Property
#End Region

End Class
