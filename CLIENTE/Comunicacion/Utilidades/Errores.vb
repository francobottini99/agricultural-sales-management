Public Enum EnumErrores
    OK
    ERROR_MYSQL
    ERROR_INFORMACION
    ERROR_GENERAL
    ERROR_DESCONOCIDO
    ERROR_CONEXION
    TRANSACCION_DESCONOCIDA
    REGISTRO_NO_ENCONTRADO
    OPERACION_SIMULTANEA_NO_TERMINANTE
    OPERACION_SIMULTANEA_TERMINANTE
    ERROR_AUTETICACION
    ERROR_AFIP
End Enum

Public Class Errores
    Private _Identificador As EnumErrores
    Private _Descripcion As String

    Public Sub New()
        Identificador = New EnumErrores
        Descripcion = "-"
    End Sub

    Public Sub New(err As EnumErrores, descripcion As String)
        Me.Identificador = err
        Me.Descripcion = descripcion
    End Sub

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Identificador As EnumErrores
        Get
            Return _Identificador
        End Get
        Set(value As EnumErrores)
            _Identificador = value
        End Set
    End Property
End Class
