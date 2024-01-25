Imports AccesoDatos

Public Class ModeloCaja
    Inherits EnlaceTransacciones(Of TransaccionesCaja)

    Private _idCaja As Integer
    Private _Fecha As Date
    Private _Movimiento As String
    Private _Comprobante As String
    Private _Descripcion As String
    Private _Moneda As String
    Private _Ingreso As Double
    Private _Egreso As Double
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

    Private fecDesde As Date
    Private fecHasta As Date

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesCaja(), "CAJA")

        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub

    Public Sub New(idCaja As Integer, fecha As Date, movimiento As String, comprobante As String, descripcion As String, moneda As String,
               ingreso As Double, egreso As Double, eliminado As String, ascUsuarios As ModeloUsuario, err As Errores, observaciones As String)
        MyBase.New(New TransaccionesCaja(), "CAJA")

        Me.IdCaja = idCaja
        Me.Fecha = fecha
        Me.Movimiento = movimiento
        Me.Comprobante = comprobante
        Me.Descripcion = descripcion
        Me.Moneda = moneda
        Me.Ingreso = ingreso
        Me.Egreso = egreso
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
        Me.Observaciones = observaciones
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdCaja As Integer
        Get
            Return _idCaja
        End Get
        Set(value As Integer)
            _idCaja = value
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

    Public Property Comprobante As String
        Get
            Return _Comprobante
        End Get
        Set(value As String)
            _Comprobante = value
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

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Ingreso As Double
        Get
            Return _Ingreso
        End Get
        Set(value As Double)
            _Ingreso = value
        End Set
    End Property

    Public Property Egreso As Double
        Get
            Return _Egreso
        End Get
        Set(value As Double)
            _Egreso = value
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

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdCaja.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdCaja.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoPorFechas(fecDesde As Date, fecHasta As Date) As List(Of ModeloCaja)
        Dim resultado As New List(Of TablaCaja)

        Me.fecDesde = fecDesde
        Me.fecHasta = fecHasta

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO ENTRE FECHAS DE CAJA"

        EjecutarTransaccion("ListadoPorFechas", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Caja(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloCaja)
        Dim resultado As New List(Of TablaCaja)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE CAJA"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Caja(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function SaldoPesos() As Double
        Dim resultado As Double

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL SALDO DE LA CAJA EN PESOS"

        EjecutarTransaccion("SaldoPesos", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el saldo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function SaldoDolares() As Double
        Dim resultado As Double

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL SALDO DE LA CAJA EN DOLARES"

        EjecutarTransaccion("SaldoDolares", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el saldo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function MinFecha() As Date
        Dim resultado As New TablaCaja

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA PRIMER FECHA DE CARGA DE CAJA"

        EjecutarTransaccion("MinFecha", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Fecha
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la primer fecha de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function MaxFecha() As Date
        Dim resultado As New TablaCaja

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA ULTIMA FECHA DE CARGA DE CAJA"

        EjecutarTransaccion("MaxFecha", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Fecha
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la ultima fecha de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaCaja

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idCaja
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

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
                    resultado = Me.Transaccion.insRegistro(Drivers.Caja(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.Caja(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdCaja)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ListadoPorFechas"
                    resultado = Me.Transaccion.verRegistrosFechaDesdeHasta(fecDesde, fecHasta)
                Case "SaldoPesos"
                    resultado = Me.Transaccion.verSaldoPesos()
                Case "SaldoDolares"
                    resultado = Me.Transaccion.verSaldoDolares()
                Case "MinFecha"
                    resultado = Me.Transaccion.verMinFecha()
                Case "MaxFecha"
                    resultado = Me.Transaccion.verMaxFecha()
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
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
