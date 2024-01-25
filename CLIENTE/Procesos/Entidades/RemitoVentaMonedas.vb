Public Class RemitoVentaMonedas
    Private _idRemitoVtaMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascRemitosventa As RemitoVenta

#Region "CONSTRUCTORES"
    Public Sub New(idRemitoVtaMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double, baseImponible As Double,
                   iVA As Double, importeTotal As Double, eliminado As String, ascRemitosventa As RemitoVenta)
        Me.IdRemitoVtaMonedas = idRemitoVtaMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscRemitosventa = ascRemitosventa
    End Sub

    Public Sub New()
        AscRemitosventa = New RemitoVenta()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRemitoVtaMonedas As Integer
        Get
            Return _idRemitoVtaMonedas
        End Get
        Set(value As Integer)
            _idRemitoVtaMonedas = value
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

    Public Property AscRemitosventa As RemitoVenta
        Get
            Return _ascRemitosventa
        End Get
        Set(value As RemitoVenta)
            _ascRemitosventa = value
        End Set
    End Property
#End Region
End Class
