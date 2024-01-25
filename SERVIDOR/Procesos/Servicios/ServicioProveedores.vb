Public Class ServicioProveedores
    Private _Proveedor As ModeloProveedores

#Region "CONSTRUCTORES"
    Public Sub New(proveedor As ModeloProveedores)
        Me.Proveedor = proveedor
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Proveedor As ModeloProveedores
        Get
            Return _Proveedor
        End Get
        Set(value As ModeloProveedores)
            _Proveedor = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"

    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim exs As RespuestaHTTP(Of String()) = Existe()

            If IsNothing(exs.Err) Then
                If exs.Cuerpo(0) = "No" Or exs.Cuerpo(0) = "Si-Elim-Nombre" Or exs.Cuerpo(0) = "Si-Elim-Cuit" Or exs.Cuerpo(0) = "Si-Elim-Nombre-Cuit" Then
                    If Proveedor.Insertar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Proveedor.Err)
                    End If
                ElseIf exs.Cuerpo(0) = "Si-Elim" Then
                    Proveedor.IdProveedor = exs.Cuerpo(1)

                    If Proveedor.RecuperarEliminado() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Proveedor.Err)
                    End If
                ElseIf exs.Cuerpo(0) = "Si-Act" Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un Proveedor con ese nombre dentro de la base de datos"})
                ElseIf exs.Cuerpo(0) = "Si-Act-Nombre" Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un Proveedor en la base de datos con el mismo nombre y distinto cuit"})
                ElseIf exs.Cuerpo(0) = "Si-Act-Cuit" Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un Proveedor en la base de datos con el mismo cuit y distinto nombre"})
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
                    If Proveedor.Modificar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Proveedor.Err)
                    End If
                Else
                    Dim registro As ModeloProveedores = Proveedor.ConsultarPorId()

                    If Not IsNothing(registro) Then
                        If exs.Cuerpo(0) = "Si-Act" Then
                            If registro.RazonSocial <> Proveedor.RazonSocial Or registro.CUIT <> Proveedor.CUIT Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un Proveedor con ese nombre y cuit dentro de la base de datos"})
                            End If
                        ElseIf exs.Cuerpo(0) = "Si-Act-Nombre" Then
                            If registro.RazonSocial <> Proveedor.RazonSocial Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un Proveedor en la base de datos con el mismo nombre y distinto cuit"})
                            End If
                        ElseIf exs.Cuerpo(0) = "Si-Act-Cuit" Then
                            If registro.CUIT <> Proveedor.CUIT Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Hay un Proveedor en la base de datos con el mismo cuit y distinto nombre"})
                            End If
                        Else
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = "Ocurrio un error desconocido [" + exs.Cuerpo(0) + "]"})
                        End If

                        If Proveedor.Modificar() Then
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Return New RespuestaHTTP(Of Boolean)(False, Proveedor.Err)
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Proveedor.Err)
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
            If Proveedor.SituacionIVA = "Consumidor Final" Or Proveedor.SituacionIVA = "Sujeto no Categorizado" Or Proveedor.SituacionIVA = "IVA Liberado – Ley Nº 19.640" Then
                Dim RespN As String() = Proveedor.ExistePorNombre()

                If Not IsNothing(RespN) Then
                    Return New RespuestaHTTP(Of String())(RespN, Nothing)
                Else
                    Return New RespuestaHTTP(Of String())(Nothing, Proveedor.Err)
                End If
            Else
                Dim RespNC As String() = Proveedor.ExistePorNombreYCuit()

                If Not IsNothing(RespNC) Then
                    If RespNC(0) = "No" Then
                        Dim RespC As String() = Proveedor.ExistePorCuit()

                        If Not IsNothing(RespC) Then
                            Dim RespN As String() = Proveedor.ExistePorNombre()

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
                                Return New RespuestaHTTP(Of String())(Nothing, Proveedor.Err)
                            End If
                        Else
                            Return New RespuestaHTTP(Of String())(Nothing, Proveedor.Err)
                        End If
                    Else
                        Return New RespuestaHTTP(Of String())(RespNC, Nothing)
                    End If
                Else
                    Return New RespuestaHTTP(Of String())(Nothing, Proveedor.Err)
                End If
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of String())(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
