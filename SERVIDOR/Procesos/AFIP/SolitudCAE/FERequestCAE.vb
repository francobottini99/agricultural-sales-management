Public Class FERequestCAE
    Private _FeCabReq As FECabeceraRequest
    Private _FeDetReq As FEDetalleRequestCAE

    Public Sub New()
    End Sub

    Public Sub New(feCabReq As FECabeceraRequest, feDetReq As FEDetalleRequestCAE)
        Me.FeCabReq = feCabReq
        Me.FeDetReq = feDetReq
    End Sub

#Region "PROPIEDADES"
    Public Property FeCabReq As FECabeceraRequest
        Get
            Return _FeCabReq
        End Get
        Set(value As FECabeceraRequest)
            _FeCabReq = value
        End Set
    End Property

    Public Property FeDetReq As FEDetalleRequestCAE
        Get
            Return _FeDetReq
        End Get
        Set(value As FEDetalleRequestCAE)
            _FeDetReq = value
        End Set
    End Property
#End Region

End Class
