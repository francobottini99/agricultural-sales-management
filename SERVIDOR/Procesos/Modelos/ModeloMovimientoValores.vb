Imports AccesoDatos

Public Class ModeloMovimientoValores
    Inherits EnlaceTransacciones(Of TransaccionesMovimientoValores)

    Private _idMovimientoValores As Integer
    Private _Fecha As Date
    Private _Movimiento As String
    Private _OrigenDestino As String
    Private _Eliminado As String
    Private _ascValoresEnCartera As ModeloValoresEnCartera
    Private _ascCaja As ModeloCaja
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesMovimientoValores(), "MOVIMIENTO VALORES")

        AscValoresEnCartera = New ModeloValoresEnCartera()
        AscCaja = New ModeloCaja()
    End Sub

    Public Sub New(idMovimientoValores As Integer, fecha As Date, movimiento As String, origenDestino As String, eliminado As String,
                   ascValoresEnCartera As ModeloValoresEnCartera, ascCaja As ModeloCaja, err As Errores)
        MyBase.New(New TransaccionesMovimientoValores(), "MOVIMIENTO VALORES")

        Me.IdMovimientoValores = idMovimientoValores
        Me.Fecha = fecha
        Me.Movimiento = movimiento
        Me.OrigenDestino = origenDestino
        Me.Eliminado = eliminado
        Me.AscValoresEnCartera = ascValoresEnCartera
        Me.AscCaja = ascCaja
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMovimientoValores As Integer
        Get
            Return _idMovimientoValores
        End Get
        Set(value As Integer)
            _idMovimientoValores = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Movimiento As String
        Get
            Return _Movimiento
        End Get
        Set(value As String)
            _Movimiento = value
        End Set
    End Property

    Public Property OrigenDestino As String
        Get
            Return _OrigenDestino
        End Get
        Set(value As String)
            _OrigenDestino = value
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

    Public Property AscValoresEnCartera As ModeloValoresEnCartera
        Get
            Return _ascValoresEnCartera
        End Get
        Set(value As ModeloValoresEnCartera)
            _ascValoresEnCartera = value
        End Set
    End Property

    Public Property AscCaja As ModeloCaja
        Get
            Return _ascCaja
        End Get
        Set(value As ModeloCaja)
            _ascCaja = value
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

        EjecutarTransaccion("Insertar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo insertar el nuevo registro en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function Modificar() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el registro [ID: " + IdMovimientoValores.ToString() + "] en la tabla " + tabla
                End If

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
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdMovimientoValores.ToString() + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloMovimientoValores)
        Dim resultado As New List(Of TablaMovimientoValores)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloMovimientoValores(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorIdCaja() As ModeloMovimientoValores
        Dim resultado As New TablaMovimientoValores

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO IDENTIFICADO POR SU ID CAJA"

        EjecutarTransaccion("ConsultarPorIdCaja", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.MovimientoValores(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoPorIdValoresEnCartera() As List(Of ModeloMovimientoValores)
        Dim resultado As New List(Of TablaMovimientoValores)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTROS IDENTIFICADO POR SU ID VALORES EN CARTERA"

        EjecutarTransaccion("ListadoPorIdValoresEnCartera", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloMovimientoValores(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloMovimientoValores(objeto As List(Of TablaMovimientoValores)) As List(Of ModeloMovimientoValores)
        Dim movVal As New List(Of ModeloMovimientoValores)

        For Each item In objeto
            movVal.Add(Drivers.MovimientoValores(item))
        Next

        Return movVal
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.MovimientoValores(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.MovimientoValores(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdMovimientoValores)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ConsultarPorIdCaja"
                    resultado = Me.Transaccion.verRegistroPorIdCaja(AscCaja.IdCaja)
                Case "ListadoPorIdValoresEnCartera"
                    resultado = Me.Transaccion.verListadoPorIdValoresEnCartera(AscValoresEnCartera.IdValoresEnCartera)
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
