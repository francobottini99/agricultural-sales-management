Public Class ServicioClientes
    Private _Cliente As ModeloCliente

#Region "CONSTRUCTORES"
    Public Sub New(cliente As ModeloCliente)
        Me.Cliente = cliente
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Cliente As ModeloCliente
        Get
            Return _Cliente
        End Get
        Set(value As ModeloCliente)
            _Cliente = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim exs As RespuestaHTTP(Of String()) = Existe()

            If IsNothing(exs.Err) Then
                If exs.Cuerpo(0) = "No" Or exs.Cuerpo(0) = "Si-Elim-Nombre" Or exs.Cuerpo(0) = "Si-Elim-Cuit" Or exs.Cuerpo(0) = "Si-Elim-Nombre-Cuit" Then
                    If Cliente.Insertar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Cliente.Err)
                    End If
                ElseIf exs.Cuerpo(0) = "Si-Elim" Then
                    Cliente.IdCliente = exs.Cuerpo(1)

                    If Cliente.RecuperarEliminado() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Cliente.Err)
                    End If
                ElseIf exs.Cuerpo(0) = "Si-Act" Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un cliente con ese nombre dentro de la base de datos"})
                ElseIf exs.Cuerpo(0) = "Si-Act-Nombre" Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un cliente en la base de datos con el mismo nombre y distinto cuit"})
                ElseIf exs.Cuerpo(0) = "Si-Act-Cuit" Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un cliente en la base de datos con el mismo cuit y distinto nombre"})
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ocurrio un error desconocido [" + exs.Cuerpo(0) + "]"})
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, exs.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim exs As RespuestaHTTP(Of String()) = Existe()

            If IsNothing(exs.Err) Then
                If exs.Cuerpo(0) = "No" Or exs.Cuerpo(0) = "Si-Elim-Nombre" Or exs.Cuerpo(0) = "Si-Elim-Cuit" Or exs.Cuerpo(0) = "Si-Elim-Nombre-Cuit" Or exs.Cuerpo(0) = "Si-Elim" Then
                    If Cliente.Modificar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Cliente.Err)
                    End If
                Else
                    Dim registro As ModeloCliente = Cliente.ConsultarPorId()

                    If Not IsNothing(registro) Then
                        If exs.Cuerpo(0) = "Si-Act" Then
                            If registro.RazonSocial <> Cliente.RazonSocial Or registro.CUIT <> Cliente.CUIT Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un Cliente con ese nombre y cuit dentro de la base de datos"})
                            End If
                        ElseIf exs.Cuerpo(0) = "Si-Act-Nombre" Then
                            If registro.RazonSocial <> Cliente.RazonSocial Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un Cliente en la base de datos con el mismo nombre y distinto cuit"})
                            End If
                        ElseIf exs.Cuerpo(0) = "Si-Act-Cuit" Then
                            If registro.CUIT <> Cliente.CUIT Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un Cliente en la base de datos con el mismo cuit y distinto nombre"})
                            End If
                        Else
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = "Ocurrio un error desconocido [" + exs.Cuerpo(0) + "]"})
                        End If

                        If Cliente.Modificar() Then
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Return New RespuestaHTTP(Of Boolean)(False, Cliente.Err)
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Cliente.Err)
                    End If
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, exs.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Existe() As RespuestaHTTP(Of String())
        Try
            If Cliente.SituacionIVA = "Consumidor Final" Or Cliente.SituacionIVA = "Sujeto no Categorizado" Or Cliente.SituacionIVA = "IVA Liberado – Ley Nº 19.640" Then
                Dim RespN As String() = Cliente.ExistePorNombre()

                If Not IsNothing(RespN) Then
                    Return New RespuestaHTTP(Of String())(RespN, Nothing)
                Else
                    Return New RespuestaHTTP(Of String())(Nothing, Cliente.Err)
                End If
            Else
                Dim RespNC As String() = Cliente.ExistePorNombreYCuit()

                If Not IsNothing(RespNC) Then
                    If RespNC(0) = "No" Then
                        Dim RespC As String() = Cliente.ExistePorCuit()

                        If Not IsNothing(RespC) Then
                            Dim RespN As String() = Cliente.ExistePorNombre()

                            If Not IsNothing(RespN) Then
                                Dim Resp(2) As String

                                If RespN(0) = "No" And RespC(0) = "No" Then
                                    Resp(0) = "No"
                                ElseIf RespN(0) <> "No" And RespC(0) = "No" Then
                                    Resp(0) = RespN(0) + "-Nombre"
                                    Resp(1) = RespN(1)
                                ElseIf RespN(0) = "No" And RespC(0) <> "No" Then
                                    Resp(0) = RespC(0) + "-Cuit"
                                    Resp(1) = RespC(1)
                                ElseIf RespN(0) <> "No" And RespC(0) <> "No" Then
                                    Resp(0) = RespC(0) + "-Nombre-Cuit"
                                    Resp(1) = RespC(1)
                                End If

                                Return New RespuestaHTTP(Of String())(Resp, Nothing)
                            Else
                                Return New RespuestaHTTP(Of String())(Nothing, Cliente.Err)
                            End If
                        Else
                            Return New RespuestaHTTP(Of String())(Nothing, Cliente.Err)
                        End If
                    Else
                        Return New RespuestaHTTP(Of String())(RespNC, Nothing)
                    End If
                Else
                    Return New RespuestaHTTP(Of String())(Nothing, Cliente.Err)
                End If
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of String())(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
