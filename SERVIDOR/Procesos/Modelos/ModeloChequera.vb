Imports AccesoDatos

Public Class ModeloChequera
    Inherits EnlaceTransacciones(Of TransaccionesChequera)

    Private _idChequera As Integer
    Private _NroCuenta As String
    Private _FechaAlta As Date
    Private _Banco As String
    Private _NroChqInicial As Integer
    Private _CantidadChq As Integer
    Private _ChqEmitidos As Integer
    Private _ChqAnulados As Integer
    Private _ChqDisponibles As Integer
    Private _Observaciones As String
    Private _Eliminada As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesChequera(), "CHEQUERAS")

        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub

    Public Sub New(idChequera As Integer, nroCuenta As String, fechaAlta As Date, banco As String, nroChqInicial As Integer, cantidadChq As Integer,
                   chqEmitidos As Integer, chqAnulados As Integer, chqDisponibles As Integer, observaciones As String, eliminada As String,
                   ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesChequera(), "CHEQUERAS")

        Me.IdChequera = idChequera
        Me.NroCuenta = nroCuenta
        Me.FechaAlta = fechaAlta
        Me.Banco = banco
        Me.NroChqInicial = nroChqInicial
        Me.CantidadChq = cantidadChq
        Me.ChqEmitidos = chqEmitidos
        Me.ChqAnulados = chqAnulados
        Me.ChqDisponibles = chqDisponibles
        Me.Observaciones = observaciones
        Me.Eliminada = eliminada
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdChequera As Integer
        Get
            Return _idChequera
        End Get
        Set(value As Integer)
            _idChequera = value
        End Set
    End Property

    Public Property NroCuenta As String
        Get
            Return _NroCuenta
        End Get
        Set(value As String)
            _NroCuenta = value
        End Set
    End Property

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(value As Date)
            _FechaAlta = value
        End Set
    End Property

    Public Property Banco As String
        Get
            Return _Banco
        End Get
        Set(value As String)
            _Banco = value
        End Set
    End Property

    Public Property NroChqInicial As Integer
        Get
            Return _NroChqInicial
        End Get
        Set(value As Integer)
            _NroChqInicial = value
        End Set
    End Property

    Public Property CantidadChq As Integer
        Get
            Return _CantidadChq
        End Get
        Set(value As Integer)
            _CantidadChq = value
        End Set
    End Property

    Public Property ChqEmitidos As Integer
        Get
            Return _ChqEmitidos
        End Get
        Set(value As Integer)
            _ChqEmitidos = value
        End Set
    End Property

    Public Property ChqAnulados As Integer
        Get
            Return _ChqAnulados
        End Get
        Set(value As Integer)
            _ChqAnulados = value
        End Set
    End Property

    Public Property ChqDisponibles As Integer
        Get
            Return _ChqDisponibles
        End Get
        Set(value As Integer)
            _ChqDisponibles = value
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

    Public Property Eliminada As String
        Get
            Return _Eliminada
        End Get
        Set(value As String)
            _Eliminada = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdChequera.ToString + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdChequera.ToString + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarChequesdeChequera() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS CHEQUE ASOCIADOS A LA CHEQUERA"

        EjecutarTransaccion("EliminarChqs", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudieron eliminar el conjunto de cheques asociados al registro [ID: " + IdChequera.ToString + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloChequera)
        Dim resultado As New List(Of TablaChequera)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE CHEQUERAS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Chequeras(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaChequera

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idChequera
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ExisteChequeEnChequera() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN CHEQUE ESPECIFICADO POR SU NUMERO DENTRO DE LA CHEQUERA"

        EjecutarTransaccion("ExisteChequeEnChequera", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ExisteChequera() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UNA CHEQAUERA YA CARGADA PARA NO DUPLICAR REGISTROS"

        EjecutarTransaccion("ExisteChequera", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ListadoSinCompletar() As List(Of ModeloChequera)
        Dim resultado As New List(Of TablaChequera)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE CHEQUERAS SIN COMPLETAR"

        EjecutarTransaccion("ListadoSinCompletar", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Chequeras(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ModificarChqEmitidos() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE CHEQUES EMITIDOS"

        EjecutarTransaccion("ModificarChqEmitidos", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el numero de cheques emitidos en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.Chequeras(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.Chequeras(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdChequera)
                Case "EliminarChqs"
                    resultado = Me.Transaccion.elimChequesdeChequera(IdChequera)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoID()
                Case "ExisteChequeEnChequera"
                    resultado = Me.Transaccion.verExisteChequeEnChequera(NroChqInicial)
                Case "ExisteChequera"
                    resultado = Me.Transaccion.verExisteChequera(NroCuenta, NroChqInicial)
                Case "ListadoSinCompletar"
                    resultado = Me.Transaccion.verListadoSinCompletar()
                Case "ModificarChqEmitidos"
                    resultado = Me.Transaccion.modChqEmitidos(IdChequera, ChqEmitidos)
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
