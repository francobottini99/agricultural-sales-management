Public Class SubRubros
    Private _idSubRubro As Integer
    Private _Abrebiatura As String
    Private _Descripcion As String
    Private _Eliminado As String
    Private _ascRubro As Rubros
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscRubro = New Rubros
        AscUsuarios = New Usuario
    End Sub

    Public Sub New(idSubRubro As Integer, abrebiatura As String, descripcion As String, eliminado As String, ascRubro As Rubros, ascUsuarios As Usuario)
        Me.IdSubRubro = idSubRubro
        Me.Abrebiatura = abrebiatura
        Me.Descripcion = descripcion
        Me.Eliminado = eliminado
        Me.AscRubro = ascRubro
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(abrebiatura As String, descripcion As String, idRub As Integer)
        Me.Abrebiatura = abrebiatura
        Me.Descripcion = descripcion
        Me.Eliminado = "NO"
        Me.AscRubro = New Rubros With {.IdRubro = idRub}
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub
#End Region


#Region "PROPIEDADES"
    Public Property IdSubRubro As Integer
        Get
            Return _idSubRubro
        End Get
        Set(value As Integer)
            _idSubRubro = value
        End Set
    End Property

    Public Property Abrebiatura As String
        Get
            Return _Abrebiatura
        End Get
        Set(value As String)
            _Abrebiatura = value
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

    Public Property Eliminado As String
        Get
            Return _Eliminado
        End Get
        Set(value As String)
            _Eliminado = value
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
