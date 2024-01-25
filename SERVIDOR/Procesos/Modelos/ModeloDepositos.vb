Imports AccesoDatos

Public Class ModeloDepositos
    Inherits EnlaceTransacciones(Of TransaccionesDeposito)

    Private _idDeposito As Integer
    Private _Nombre As String
    Private _Direccion As String
    Private _Localidad As String
    Private _Provincia As String
    Private _CodPostal As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDeposito(), "DEPOSITOS")

        AscUsuarios = New ModeloUsuario
        Err = New Errores()
    End Sub

    Public Sub New(idDeposito As Integer, nombre As String, direccion As String, localidad As String, provincia As String,
                   codPostal As String, eliminado As String, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesDeposito(), "DEPOSITOS")

        Me.IdDeposito = idDeposito
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
        Me.CodPostal = codPostal
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDeposito As Integer
        Get
            Return _idDeposito
        End Get
        Set(value As Integer)
            _idDeposito = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property

    Public Property CodPostal As String
        Get
            Return _CodPostal
        End Get
        Set(value As String)
            _CodPostal = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdDeposito + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdDeposito + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloDepositos)
        Dim resultado As New List(Of TablaDepositos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE DEPOSITOS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloDepositos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ExistePorNombre() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN DEPOSITO CON UN NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorNombre", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloDepositos
        Dim resultado As New TablaDepositos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTA UN DEPOSITO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloDepositos With {
                                .IdDeposito = resultado.idDeposito,
                                .Nombre = resultado.Nombre,
                                .Direccion = resultado.Direccion,
                                .Localidad = resultado.Localidad,
                                .Provincia = resultado.Provincia,
                                .CodPostal = resultado.CodPostal,
                                .Eliminado = resultado.Eliminado,
                                .AscUsuarios = New ModeloUsuario With {.IdUsuarios = resultado.ascUsuarios.idUsuario}
                          }
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloDepositos(objeto As List(Of TablaDepositos)) As List(Of ModeloDepositos)
        Dim depositos As New List(Of ModeloDepositos)

        For Each item In objeto
            depositos.Add(New ModeloDepositos With {
                                .IdDeposito = item.idDeposito,
                                .Nombre = item.Nombre,
                                .Direccion = item.Direccion,
                                .Localidad = item.Localidad,
                                .Provincia = item.Provincia,
                                .CodPostal = item.CodPostal,
                                .Eliminado = item.Eliminado,
                                .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario}
                          })
        Next

        Return depositos
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaDepositos With {
                                                                .Nombre = Nombre,
                                                                .Direccion = Direccion,
                                                                .Localidad = Localidad,
                                                                .Provincia = Provincia,
                                                                .CodPostal = CodPostal,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaDepositos With {
                                                                .idDeposito = IdDeposito,
                                                                .Nombre = Nombre,
                                                                .Direccion = Direccion,
                                                                .Localidad = Localidad,
                                                                .Provincia = Provincia,
                                                                .CodPostal = CodPostal,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdDeposito)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ExistePorNombre"
                    resultado = Me.Transaccion.verExisteDepositoPorNombre(Nombre)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdDeposito)
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
