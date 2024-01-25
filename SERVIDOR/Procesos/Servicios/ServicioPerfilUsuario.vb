Imports AccesoDatos

Public Class ServicioPerfilUsuario
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _perfil As ModeloPerfilUsuario

#Region "CONSTRUCTORES"
    Public Sub New(perfil As ModeloPerfilUsuario)
        MyBase.New(New Transacciones(), "SERVICIO")
        Me.Perfil = perfil
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Perfil As ModeloPerfilUsuario
        Get
            Return _perfil
        End Get
        Set(value As ModeloPerfilUsuario)
            _perfil = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            If Not IsNothing(Perfil) Then
                If Not Perfil.ExistePorNombre() Then
                    If Perfil.Insertar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(Nothing, Perfil.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_INFORMACION, .Descripcion = "Ya existe un Perfil de Usuario con ese nombre"})
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = "Error en el servidor al recibir la informacion enviada por el cliente"})
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Eliminar() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarNoEliminado As ModeloPerfilUsuario = Perfil.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                If Not New ModeloUsuario With {.AscPerfilUs = Perfil}.ExistePorIdPerfil Then
                    If Perfil.Eliminar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(Nothing, Perfil.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "El perfil que intentas eliminar esta asociado a uno o más USUARIOS, primero quita el perfil del/los usuario y luego podras eliminarlo !"})
                End If

            ElseIf verificarNoEliminado.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "El perfil que intentas eliminar ya fue eliminada por otro usuario."})
            Else
                Return New RespuestaHTTP(Of Boolean)(Nothing, verificarNoEliminado.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarNoEliminado As ModeloPerfilUsuario = Perfil.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                If Not Perfil.ExistePorNombre() Or verificarNoEliminado.NombrePerfil = Perfil.NombrePerfil Then
                    If Perfil.Modificar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(Nothing, Perfil.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_INFORMACION, .Descripcion = "Ya existe un Perfil de Usuario con ese nombre"})
                End If
            ElseIf verificarNoEliminado.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "El perfil que intentas modificar ya fue eliminada por otro usuario."})
            Else
                Return New RespuestaHTTP(Of Boolean)(Nothing, verificarNoEliminado.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region


End Class
