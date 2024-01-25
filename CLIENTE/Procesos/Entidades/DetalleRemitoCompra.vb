Public Class DetalleRemitoCompra
    Private _idDetalleRemitosCompra As Integer
    Private _Descripcion As String
    Private _Cantidad As Double
    Private _Unidad As String
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Facturado As String
    Private _Eliminado As String
    Private _ascArticulos As Articulos
    Private _ascRemitosCompra As RemitoCompra

#Region "CONSTRUCTORES"
    Public Sub New(idDetalleRemitosCompra As Integer, descripcion As String, cantidad As Double, unidad As String, precio As Double,
                   importe As Double, alicuotaIVA As Double, facturado As String, eliminado As String, ascArticulos As Articulos,
                   ascRemitosCompra As RemitoCompra)

        Me.IdDetalleRemitosCompra = idDetalleRemitosCompra
        Me.Descripcion = descripcion
        Me.Cantidad = cantidad
        Me.Unidad = unidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Facturado = facturado
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscRemitosCompra = ascRemitosCompra
    End Sub

    Public Sub New()
        AscArticulos = New Articulos()
        AscRemitosCompra = New RemitoCompra()
    End Sub

#End Region

#Region "PROPIEDADES"
    Public Property IdDetalleRemitosCompra As Integer
        Get
            Return _idDetalleRemitosCompra
        End Get
        Set(value As Integer)
            _idDetalleRemitosCompra = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set(value As Double)
            _Precio = value
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

    Public Property AlicuotaIVA As Double
        Get
            Return _AlicuotaIVA
        End Get
        Set(value As Double)
            _AlicuotaIVA = value
        End Set
    End Property

    Public Property Facturado As String
        Get
            Return _Facturado
        End Get
        Set(value As String)
            _Facturado = value
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

    Public Property AscArticulos As Articulos
        Get
            Return _ascArticulos
        End Get
        Set(value As Articulos)
            _ascArticulos = value
        End Set
    End Property

    Public Property AscRemitosCompra As RemitoCompra
        Get
            Return _ascRemitosCompra
        End Get
        Set(value As RemitoCompra)
            _ascRemitosCompra = value
        End Set
    End Property
#End Region

End Class
