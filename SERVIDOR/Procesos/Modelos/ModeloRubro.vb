Imports AccesoDatos

Public Class ModeloRubro
    Inherits EnlaceTransacciones(Of TransaccionesRubro)

    Private _idRubro As Integer
    Private _Abrebiatura As String
    Private _Descripcion As String
    Private _Eliminado As String
    Private _ascUsuarios As New ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRubro(), "RUBRO")

        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idRubro As Integer, abrebiatura As String, descripcion As String, eliminado As String,
                   ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesRubro(), "RUBRO")

        Me.IdRubro = idRubro
        Me.Abrebiatura = abrebiatura
        Me.Descripcion = descripcion
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRubro As Integer
        Get
            Return _idRubro
        End Get
        Set(value As Integer)
            _idRubro = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdRubro + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRubro + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloRubro)
        Dim resultado As New List(Of TablaRubro)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE RUBROS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloRubro(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de rubros de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ExistePorNombre() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN RUBRO CON UN NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorNombre", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ExistePorAbrebiatura() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN RUBRO CON UNA ABREBIATURA ESPECIFICA"

        EjecutarTransaccion("ExistePorAbrebiatura", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloRubro
        Dim resultado As New TablaRubro

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTA UN RUBRO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloRubro With {
                            .IdRubro = resultado.idRubro,
                            .Abrebiatura = resultado.Abrebiatura,
                            .Descripcion = resultado.Descripcion,
                            .Eliminado = Eliminado,
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = resultado.ascUsuarios.idUsuario}
                   }
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloRubro(objeto As List(Of TablaRubro)) As List(Of ModeloRubro)
        Dim rubros As New List(Of ModeloRubro)

        For Each item In objeto
            rubros.Add(New ModeloRubro With {
                            .IdRubro = item.idRubro,
                            .Abrebiatura = item.Abrebiatura,
                            .Descripcion = item.Descripcion,
                            .Eliminado = Eliminado,
                            .AscUsuarios = New ModeloUsuario With {
                                .IdUsuarios = item.ascUsuarios.idUsuario,
                                .Nombre = item.ascUsuarios.Nombre
                            }
                       })
        Next

        Return rubros
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaRubro With {
                                                                .Abrebiatura = Abrebiatura,
                                                                .Descripcion = Descripcion,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaRubro With {
                                                                .idRubro = IdRubro,
                                                                .Abrebiatura = Abrebiatura,
                                                                .Descripcion = Descripcion,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdRubro)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ExistePorNombre"
                    resultado = Me.Transaccion.verExisteRubroPorNombre(Descripcion)
                Case "ExistePorAbrebiatura"
                    resultado = Me.Transaccion.verExisteRubroPorAbrebiatura(Abrebiatura)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdRubro)
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
#End Region
End Class
