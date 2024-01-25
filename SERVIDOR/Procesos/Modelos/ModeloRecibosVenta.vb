Imports AccesoDatos

Public Class ModeloRecibosVenta
    Inherits EnlaceTransacciones(Of TransaccionesRecibosVenta)

    Private _idRecibosVenta As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _ImportePesos As Double
    Private _ImporteDolares As Double
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _ascClientes As ModeloCliente
    Private _ascCuentaCorrienteVenta As ModeloCuentaCorrienteVenta
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRecibosVenta(), "RECIBOS VENTA")

        AscUsuarios = New ModeloUsuario()
        AscClientes = New ModeloCliente()
        AscCuentaCorrienteVenta = New ModeloCuentaCorrienteVenta()
        Err = New Errores()
    End Sub

    Public Sub New(idRecibosVenta As Integer, nroComprobante As String, fecha As Date, importePesos As Double, importeDolares As Double,
                   observaciones As String, eliminado As String, ascUsuarios As ModeloUsuario, ascClientes As ModeloCliente,
                   ascCuentaCorrienteVenta As ModeloCuentaCorrienteVenta, err As Errores)
        MyBase.New(New TransaccionesRecibosVenta(), "RECIBOS VENTA")

        Me.IdRecibosVenta = idRecibosVenta
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.ImportePesos = importePesos
        Me.ImporteDolares = importeDolares
        Me.Observaciones = observaciones
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscClientes = ascClientes
        Me.AscCuentaCorrienteVenta = ascCuentaCorrienteVenta
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRecibosVenta As Integer
        Get
            Return _idRecibosVenta
        End Get
        Set(value As Integer)
            _idRecibosVenta = value
        End Set
    End Property

    Public Property NroComprobante As String
        Get
            Return _NroComprobante
        End Get
        Set(value As String)
            _NroComprobante = value
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

    Public Property ImportePesos As Double
        Get
            Return _ImportePesos
        End Get
        Set(value As Double)
            _ImportePesos = value
        End Set
    End Property

    Public Property ImporteDolares As Double
        Get
            Return _ImporteDolares
        End Get
        Set(value As Double)
            _ImporteDolares = value
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

    Public Property AscClientes As ModeloCliente
        Get
            Return _ascClientes
        End Get
        Set(value As ModeloCliente)
            _ascClientes = value
        End Set
    End Property

    Public Property AscCuentaCorrienteVenta As ModeloCuentaCorrienteVenta
        Get
            Return _ascCuentaCorrienteVenta
        End Get
        Set(value As ModeloCuentaCorrienteVenta)
            _ascCuentaCorrienteVenta = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdRecibosVenta.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRecibosVenta.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloRecibosVenta)
        Dim resultado As New List(Of TablaRecibosVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE RECIBOS VENTA"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloRecibosVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaRecibosVenta

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idRecibosVenta
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
    Private Function listModeloRecibosVenta(objeto As List(Of TablaRecibosVenta)) As List(Of ModeloRecibosVenta)
        Dim recibosVenta As New List(Of ModeloRecibosVenta)

        For Each item In objeto
            recibosVenta.Add(Drivers.RecibosVenta(item))
        Next

        Return recibosVenta
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.RecibosVenta(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.RecibosVenta(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdRecibosVenta)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoID()
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
