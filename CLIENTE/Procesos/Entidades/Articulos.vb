Public Class Articulos
    Private _idArticulo As Integer
    Private _CodArticulo As String
    Private _Detalle As String
    Private _Unidad As String
    Private _Costo As Double
    Private _FechaActCosto As Date
    Private _Precio As Double
    Private _FechaActPrec As Date
    Private _AlicuotaIVA As Double
    Private _StkMinimo As Double
    Private _Observaciones As String
    Private _Imagen As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario
    Private _ascRubro As Rubros
    Private _ascSubRubro As SubRubros

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
        AscRubro = New Rubros()
        AscSubRubro = New SubRubros()
    End Sub

    Public Sub New(idArticulo As Integer, codArticulo As String, detalle As String, unidad As String,
                   costo As Double, fechaActCosto As Date, precio As Double, fechaActPrec As Date,
                   alicuotaIVA As Double, stkMinimo As Double, observaciones As String, imagen As String,
                   eliminado As String, ascUsuarios As Usuario, ascRubro As Rubros, ascSubRubro As SubRubros)

        Me.IdArticulo = idArticulo
        Me.CodArticulo = codArticulo
        Me.Detalle = detalle
        Me.Unidad = unidad
        Me.Costo = costo
        Me.FechaActCosto = fechaActCosto
        Me.Precio = precio
        Me.FechaActPrec = fechaActPrec
        Me.AlicuotaIVA = alicuotaIVA
        Me.StkMinimo = stkMinimo
        Me.Observaciones = observaciones
        Me.Imagen = imagen
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscRubro = ascRubro
        Me.AscSubRubro = ascSubRubro
    End Sub

    Public Sub New(detalle As String, unidad As String, costo As Double, precio As Double,
                   alicuotaIVA As Double, stkMinimo As Double, observaciones As String,
                   imagen As String, idRubro As Integer, idSubRubro As Integer,
                   nomRub As String, abrvRub As String, abrvSubRub As String)

        Me.Detalle = detalle
        Me.Unidad = unidad
        Me.Costo = costo
        Me.FechaActCosto = Date.Now.Date
        Me.Precio = precio
        Me.FechaActPrec = Date.Now.Date
        Me.AlicuotaIVA = alicuotaIVA
        Me.StkMinimo = stkMinimo
        Me.Observaciones = observaciones
        Me.Imagen = imagen
        Me.Eliminado = "NO"
        Me.AscUsuarios = DatosSesion._Usuario
        Me.AscRubro = New Rubros With {.IdRubro = idRubro, .Descripcion = nomRub, .Abrebiatura = abrvRub}
        Me.AscSubRubro = New SubRubros With {.IdSubRubro = idSubRubro, .Abrebiatura = abrvSubRub}
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdArticulo As Integer
        Get
            Return _idArticulo
        End Get
        Set(value As Integer)
            _idArticulo = value
        End Set
    End Property

    Public Property CodArticulo As String
        Get
            Return _CodArticulo
        End Get
        Set(value As String)
            _CodArticulo = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
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

    Public Property Costo As Double
        Get
            Return _Costo
        End Get
        Set(value As Double)
            _Costo = value
        End Set
    End Property

    Public Property FechaActCosto As Date
        Get
            Return _FechaActCosto
        End Get
        Set(value As Date)
            _FechaActCosto = value
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

    Public Property FechaActPrec As Date
        Get
            Return _FechaActPrec
        End Get
        Set(value As Date)
            _FechaActPrec = value
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

    Public Property StkMinimo As Double
        Get
            Return _StkMinimo
        End Get
        Set(value As Double)
            _StkMinimo = value
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

    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
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

    Public Property AscRubro As Rubros
        Get
            Return _ascRubro
        End Get
        Set(value As Rubros)
            _ascRubro = value
        End Set
    End Property

    Public Property AscSubRubro As SubRubros
        Get
            Return _ascSubRubro
        End Get
        Set(value As SubRubros)
            _ascSubRubro = value
        End Set
    End Property
#End Region

End Class
