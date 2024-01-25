Imports AccesoDatos

Public Class ServicioArticulos
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _Articulo As ModeloArticulos
    Private _Rubro As ModeloRubro
    Private _SubRubro As ModeloSubRubro

#Region "CONSTRUCTORES"
    Public Sub New(articulo As ModeloArticulos, rubro As ModeloRubro, subRubro As ModeloSubRubro)
        MyBase.New(New Transacciones(), "-")

        Me.Articulo = articulo
        Me.Rubro = rubro
        Me.SubRubro = subRubro
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Articulo As ModeloArticulos
        Get
            Return _Articulo
        End Get
        Set(value As ModeloArticulos)
            _Articulo = value
        End Set
    End Property

    Public Property Rubro As ModeloRubro
        Get
            Return _Rubro
        End Get
        Set(value As ModeloRubro)
            _Rubro = value
        End Set
    End Property

    Public Property SubRubro As ModeloSubRubro
        Get
            Return _SubRubro
        End Get
        Set(value As ModeloSubRubro)
            _SubRubro = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            BeginTransaction()

            Dim UltimoIdArticulo As Integer = Articulo.UltimoId()

            If Not IsNothing(UltimoIdArticulo) Then
                If SubRubro.IdSubRubro = 0 Then
                    Articulo.CodArticulo = Rubro.Abrebiatura + (UltimoIdArticulo + 1).ToString()

                    SubRubro.Abrebiatura = Rubro.Abrebiatura
                    SubRubro.Descripcion = Rubro.Descripcion
                    SubRubro.AscRubro.IdRubro = Rubro.IdRubro
                    SubRubro.AscUsuarios.IdUsuarios = Articulo.AscUsuarios.IdUsuarios

                    If SubRubro.Insertar() Then
                        Dim listSubRubros As List(Of ModeloSubRubro) = SubRubro.ListadoCompleto()

                        If Not IsNothing(listSubRubros) Then
                            Articulo.AscSubRubro = listSubRubros.Last()
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, SubRubro.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, SubRubro.Err)
                    End If
                Else
                    If Rubro.Abrebiatura = SubRubro.Abrebiatura Then
                        Articulo.CodArticulo = Rubro.Abrebiatura + (UltimoIdArticulo + 1).ToString()
                    Else
                        Articulo.CodArticulo = Rubro.Abrebiatura + SubRubro.Abrebiatura + (UltimoIdArticulo + 1).ToString()
                    End If
                End If

                If Articulo.Insertar() Then
                    Commit()
                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, Articulo.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, Articulo.Err)
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            BeginTransaction()

            If SubRubro.IdSubRubro = 0 Then
                Articulo.CodArticulo = Rubro.Abrebiatura + Articulo.IdArticulo.ToString()

                SubRubro.Abrebiatura = Rubro.Abrebiatura
                SubRubro.Descripcion = Rubro.Descripcion
                SubRubro.AscRubro.IdRubro = Rubro.IdRubro
                SubRubro.AscUsuarios.IdUsuarios = Articulo.AscUsuarios.IdUsuarios

                If SubRubro.Insertar() Then
                    Dim listSubRubros As List(Of ModeloSubRubro) = SubRubro.ListadoCompleto()

                    If Not IsNothing(listSubRubros) Then
                        Articulo.AscSubRubro = listSubRubros.Last()
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, SubRubro.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, SubRubro.Err)
                End If
            Else
                If Rubro.Abrebiatura = SubRubro.Abrebiatura Then
                    Articulo.CodArticulo = Rubro.Abrebiatura + Articulo.IdArticulo.ToString()
                Else
                    Articulo.CodArticulo = Rubro.Abrebiatura + SubRubro.Abrebiatura + Articulo.IdArticulo.ToString()
                End If
            End If

            If Articulo.Modificar() Then
                Commit()
                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, Articulo.Err)
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
