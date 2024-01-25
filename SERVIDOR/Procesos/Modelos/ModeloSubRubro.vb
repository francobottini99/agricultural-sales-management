Imports AccesoDatos

Public Class ModeloSubRubro
    Inherits EnlaceTransacciones(Of TransaccionesSubRubro)

    Private _idSubRubro As Integer
    Private _Abrebiatura As String
    Private _Descripcion As String
    Private _Eliminado As String
    Private _ascRubro As ModeloRubro
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesSubRubro(), "SUB RUBROS")

        AscRubro = New ModeloRubro()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idSubRubro As Integer, abrebiatura As String, descripcion As String, eliminado As String, ascRubro As ModeloRubro, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesSubRubro(), "SUB RUBROS")

        Me.IdSubRubro = idSubRubro
        Me.Abrebiatura = abrebiatura
        Me.Descripcion = descripcion
        Me.Eliminado = eliminado
        Me.AscRubro = ascRubro
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
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

    Public Property AscRubro As ModeloRubro
        Get
            Return _ascRubro
        End Get
        Set(value As ModeloRubro)
            _ascRubro = value
        End Set
    End Property

    Public Property AscUsuarios As ModeloUsuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As ModeloUsuario)
            _ascUsuarios = value
        End Set
    End Property

    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As Boolean
        Dim resultado As Integer

        operacion = "INSERTAR"
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Insertar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo insertar el nuevo registro en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function Modificar() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdSubRubro + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function Eliminar() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"

        EjecutarTransaccion("Eliminar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdSubRubro + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloSubRubro)
        Dim resultado As New List(Of TablaSubRubro)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE SUB RUBROS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloSubRubro(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de sub rubros de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ExistePorNombre() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN SUB RUBRO CON UN NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorNombre", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ExistePorIdRubro() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN SUB RUBRO CON UN NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorIdRubro", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ExistePorAbrebiatura() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN SUB RUBRO CON UNA ABREBIATURA ESPECIFICA"

        EjecutarTransaccion("ExistePorAbrebiatura", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloSubRubro
        Dim resultado As New TablaSubRubro

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTA UN SUB RUBRO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloSubRubro With {
                                .IdSubRubro = resultado.idSubRubro,
                                .Abrebiatura = resultado.Abrebiatura,
                                .Descripcion = resultado.Descripcion,
                                .Eliminado = resultado.Eliminado,
                                .AscRubro = New ModeloRubro With {.IdRubro = resultado.ascRubro.idRubro},
                                .AscUsuarios = New ModeloUsuario With {.IdUsuarios = resultado.ascUsuarios.idUsuario}
                          }
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaSubRubro With {
                                                                .Abrebiatura = Abrebiatura,
                                                                .Descripcion = Descripcion,
                                                                .ascRubro = New TablaRubro With {.idRubro = AscRubro.IdRubro},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaSubRubro With {
                                                                .idSubRubro = IdSubRubro,
                                                                .Abrebiatura = Abrebiatura,
                                                                .Descripcion = Descripcion,
                                                                .ascRubro = New TablaRubro With {.idRubro = AscRubro.IdRubro},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdSubRubro)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ExistePorNombre"
                    resultado = Me.Transaccion.verExisteSubRubroPorNombre(Descripcion)
                Case "ExistePorIdRubro"
                    resultado = Me.Transaccion.verExisteSubRubroPorIdRubro(AscRubro.IdRubro)
                Case "ExistePorAbrebiatura"
                    resultado = Me.Transaccion.verExisteSubRubroPorAbrebiatura(Abrebiatura)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdSubRubro)
                Case Else
                    Err.Identificador = EnumErrores.TRANSACCION_DESCONOCIDA
                    Err.Descripcion = "La transaccion """ + transaccion + """ no se encuentra en el servidor"

                    resultado = Nothing
            End Select
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Err.Identificador = EnumErrores.ERROR_MYSQL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace

            resultado = Nothing
        Catch ex As Exception
            Err.Identificador = EnumErrores.ERROR_GENERAL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace

            resultado = Nothing
        Finally
            detalleResultado = Err.Descripcion

            AñadirOperacion()
        End Try
    End Sub

    Private Function listModeloSubRubro(objeto As List(Of TablaSubRubro)) As List(Of ModeloSubRubro)
        Dim subRubros As New List(Of ModeloSubRubro)

        For Each item In objeto
            subRubros.Add(New ModeloSubRubro With {
                                .IdSubRubro = item.idSubRubro,
                                .Abrebiatura = item.Abrebiatura,
                                .Descripcion = item.Descripcion,
                                .Eliminado = item.Eliminado,
                                .AscRubro = New ModeloRubro With {.IdRubro = item.ascRubro.idRubro},
                                .AscUsuarios = New ModeloUsuario With {
                                    .IdUsuarios = item.ascUsuarios.idUsuario,
                                    .Nombre = item.ascUsuarios.Nombre
                                }
                          })
        Next

        Return subRubros
    End Function

#End Region
End Class
