Public Class OrdenDePagoMonedas
    Private _idOrdenDePagoMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascOrdenDePago As OrdenDePago

#Region "CONSTRUCTORES"
    Public Sub New()
        AscOrdenDePago = New OrdenDePago()
    End Sub

    Public Sub New(idOrdenDePagoMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double,
                   baseImponible As Double, iVA As Double, importeTotal As Double, eliminado As String, ascOrdenDePago As OrdenDePago)
        Me.IdOrdenDePagoMonedas = idOrdenDePagoMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscOrdenDePago = ascOrdenDePago
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdOrdenDePagoMonedas As Integer
        Get
            Return _idOrdenDePagoMonedas
        End Get
        Set(value As Integer)
            _idOrdenDePagoMonedas = value
        End Set
    End Property

    Public Property TipoCambio As Double
        Get
            Return _TipoCambio
        End Get
        Set(value As Double)
            _TipoCambio = value
        End Set
    End Property

    Public Property ImporteNeto As Double
        Get
            Return _ImporteNeto
        End Get
        Set(value As Double)
            _ImporteNeto = value
        End Set
    End Property

    Public Property DescuentoGral As Double
        Get
            Return _DescuentoGral
        End Get
        Set(value As Double)
            _DescuentoGral = value
        End Set
    End Property

    Public Property BaseImponible As Double
        Get
            Return _BaseImponible
        End Get
        Set(value As Double)
            _BaseImponible = value
        End Set
    End Property

    Public Property IVA As Double
        Get
            Return _IVA
        End Get
        Set(value As Double)
            _IVA = value
        End Set
    End Property

    Public Property ImporteTotal As Double
        Get
            Return _ImporteTotal
        End Get
        Set(value As Double)
            _ImporteTotal = value
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

    Public Property AscOrdenDePago As OrdenDePago
        Get
            Return _ascOrdenDePago
        End Get
        Set(value As OrdenDePago)
            _ascOrdenDePago = value
        End Set
    End Property
#End Region
End Class
