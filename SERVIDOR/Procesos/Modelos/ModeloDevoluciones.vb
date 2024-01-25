Imports AccesoDatos

Public Class ModeloDevoluciones
    Inherits EnlaceTransacciones(Of TransaccionesDevoluciones)

    Private _idDevoluciones As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _Importe As Double
    Private _Observaciones As String
    Private _ImpOriginal As Integer
    Private _ImpCopia As Integer
    Private _Eliminado As String
    Private _ascClientes As ModeloCliente
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDevoluciones(), "DEVOLUCIONES")

        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idDevoluciones As Integer, nroComprobante As String, fecha As Date, importe As Double, observaciones As String,
                   impOriginal As Integer, impCopia As Integer, eliminado As String, ascClientes As ModeloCliente,
                   ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesDevoluciones(), "DEVOLUCIONES")

        Me.IdDevoluciones = idDevoluciones
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.Importe = importe
        Me.Observaciones = observaciones
        Me.ImpOriginal = impOriginal
        Me.ImpCopia = impCopia
        Me.Eliminado = eliminado
        Me.AscClientes = ascClientes
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDevoluciones As Integer
        Get
            Return _idDevoluciones
        End Get
        Set(value As Integer)
            _idDevoluciones = value
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

    Public Property Importe As Double
        Get
            Return _Importe
        End Get
        Set(value As Double)
            _Importe = value
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

    Public Property ImpOriginal As Integer
        Get
            Return _ImpOriginal
        End Get
        Set(value As Integer)
            _ImpOriginal = value
        End Set
    End Property

    Public Property ImpCopia As Integer
        Get
            Return _ImpCopia
        End Get
        Set(value As Integer)
            _ImpCopia = value
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

    Public Property AscClientes As ModeloCliente
        Get
            Return _ascClientes
        End Get
        Set(value As ModeloCliente)
            _ascClientes = value
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

    Public Function UltimoId() As Integer
        Dim resultado As New TablaDevoluciones

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idDevoluciones
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
                    resultado = Me.Transaccion.insRegistro(Drivers.Devoluciones(Me))
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
