Public Class FacturaCompraDetalle

    Private _idFacturaCompraDetalle As Integer
    Private _Descripcion As String
    Private _Unidad As String
    Private _Cantidad As Double
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Remitado As String
    Private _Eliminado As String
    Private _ascArticulos As Articulos
    Private _ascFacturaCompra As FacturaCompra

#Region "CONSTRUCTORES"
    Public Sub New(idFacturaCompraDetalle As Integer, descripcion As String, unidad As String, cantidad As Double, precio As Double,
                   importe As Double, alicuotaIVA As Double, remitado As String, eliminado As String, ascArticulos As Articulos,
                   ascFacturaCompra As FacturaCompra)

        Me.IdFacturaCompraDetalle = idFacturaCompraDetalle
        Me.Descripcion = descripcion
        Me.Unidad = unidad
        Me.Cantidad = cantidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscFacturaCompra = ascFacturaCompra
        Me.Remitado = remitado
    End Sub

    Public Sub New()
        AscArticulos = New Articulos()
        AscFacturaCompra = New FacturaCompra()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaCompraDetalle As Integer
        Get
            Return _idFacturaCompraDetalle
        End Get
        Set(value As Integer)
            _idFacturaCompraDetalle = value
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

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
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

    Public Property AscFacturaCompra As FacturaCompra
        Get
            Return _ascFacturaCompra
        End Get
        Set(value As FacturaCompra)
            _ascFacturaCompra = value
        End Set
    End Property

    Public Property Remitado As String
        Get
            Return _Remitado
        End Get
        Set(value As String)
            _Remitado = value
        End Set
    End Property
#End Region

End Class
