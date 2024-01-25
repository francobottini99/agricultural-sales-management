Public Class DetalleDevoluciones
    Private _idDetalleDevoluciones As Integer
    Private _Descripcion As String
    Private _Cantidad As Double
    Private _Unidad As String
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Eliminado As String
    Private _ascArticulos As Articulos
    Private _ascDetalleRemitoVenta As DetalleRemitoVenta
    Private _ascDevoluciones As Devoluciones

#Region "CONSTRUCTORES"
    Public Sub New()
        AscArticulos = New Articulos()
        AscDetalleRemitoVenta = New DetalleRemitoVenta()
        AscDevoluciones = New Devoluciones()
    End Sub

    Public Sub New(idDetalleDevoluciones As Integer, descripcion As String, cantidad As Double, unidad As String, precio As Double,
                   importe As Double, alicuotaIVA As Double, eliminado As String, ascArticulos As Articulos,
                   ascDetalleRemitoVenta As DetalleRemitoVenta, ascDevoluciones As Devoluciones)
        Me.IdDetalleDevoluciones = idDetalleDevoluciones
        Me.Descripcion = descripcion
        Me.Cantidad = cantidad
        Me.Unidad = unidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscDetalleRemitoVenta = ascDetalleRemitoVenta
        Me.AscDevoluciones = ascDevoluciones
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDetalleDevoluciones As Integer
        Get
            Return _idDetalleDevoluciones
        End Get
        Set(value As Integer)
            _idDetalleDevoluciones = value
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

    Public Property AscDetalleRemitoVenta As DetalleRemitoVenta
        Get
            Return _ascDetalleRemitoVenta
        End Get
        Set(value As DetalleRemitoVenta)
            _ascDetalleRemitoVenta = value
        End Set
    End Property

    Public Property AscDevoluciones As Devoluciones
        Get
            Return _ascDevoluciones
        End Get
        Set(value As Devoluciones)
            _ascDevoluciones = value
        End Set
    End Property
#End Region
End Class
