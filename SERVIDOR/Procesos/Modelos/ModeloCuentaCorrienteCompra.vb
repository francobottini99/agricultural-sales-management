Imports AccesoDatos

Public Class ModeloCuentaCorrienteCompra
    Inherits EnlaceTransacciones(Of TransaccionesCtaCteCompra)

    Private _idCuentaCorrienteCompra As Integer
    Private _Fecha As Date
    Private _FechaVto As Date
    Private _Comprobante As String
    Private _Numero As String
    Private _Detalle As String
    Private _Debito As Double
    Private _Credito As Double
    Private _Eliminado As String
    Private _Visible As String
    Private _ascProveedores As ModeloProveedores
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesCtaCteCompra(), "CUENTA CORRIENTE COMPRA")

        Err = New Errores()
        AscProveedores = New ModeloProveedores()
        ascUsuarios = New ModeloUsuario()
    End Sub

    Public Sub New(idCuentaCorrienteCompra As Integer, fecha As Date, fechaVto As Date, comprobante As String, numero As String,
                   detalle As String, debito As Double, credito As Double, eliminado As String, visible As String, ascProveedores As ModeloProveedores,
                   ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesCtaCteCompra(), "CUENTA CORRIENTE COMPRA")

        Me.IdCuentaCorrienteCompra = idCuentaCorrienteCompra
        Me.Fecha = fecha
        Me.FechaVto = fechaVto
        Me.Comprobante = comprobante
        Me.Numero = numero
        Me.Detalle = detalle
        Me.Debito = debito
        Me.Credito = credito
        Me.Eliminado = eliminado
        Me.Visible = visible
        Me.AscProveedores = ascProveedores
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdCuentaCorrienteCompra As Integer
        Get
            Return _idCuentaCorrienteCompra
        End Get
        Set(value As Integer)
            _idCuentaCorrienteCompra = value
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

    Public Property FechaVto As Date
        Get
            Return _FechaVto
        End Get
        Set(value As Date)
            _FechaVto = value
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

    Public Property Numero As String
        Get
            Return _Numero
        End Get
        Set(value As String)
            _Numero = value
        End Set
    End Property

    Public Shadows Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
        End Set
    End Property

    Public Property Debito As Double
        Get
            Return _Debito
        End Get
        Set(value As Double)
            _Debito = value
        End Set
    End Property

    Public Property Credito As Double
        Get
            Return _Credito
        End Get
        Set(value As Double)
            _Credito = value
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

    Public Property AscProveedores As ModeloProveedores
        Get
            Return _ascProveedores
        End Get
        Set(value As ModeloProveedores)
            _ascProveedores = value
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

    Public Property Visible As String
        Get
            Return _Visible
        End Get
        Set(value As String)
            _Visible = value
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

    Public Function Eliminar() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Eliminar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdCuentaCorrienteCompra.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaCuentaCorrienteCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idCuentaCorrienteCompra
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdProveedor() As List(Of ModeloCuentaCorrienteCompra)
        Dim resultado As New List(Of TablaCuentaCorrienteCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE CUENTA CORRIENTE POR ID PROVEEDOR"

        EjecutarTransaccion("ListasdoPorIdProveedor", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.CuentaCorrienteCompra(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
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
                    resultado = Me.Transaccion.insRegistro(Drivers.CuentaCorrienteCompra(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdCuentaCorrienteCompra)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoID()
                Case "ListasdoPorIdProveedor"
                    resultado = Me.Transaccion.verCuentaCorrienteVentaPorIdProveedor(AscProveedores.IdProveedor)
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
