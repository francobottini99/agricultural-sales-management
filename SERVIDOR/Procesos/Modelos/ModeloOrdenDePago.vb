Imports AccesoDatos

Public Class ModeloOrdenDePago
    Inherits EnlaceTransacciones(Of TransaccionesOrdenDePago)

    Private _idOrdenDePago As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _ImportePesos As Double
    Private _ImporteDolares As Double
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _ascProveedores As ModeloProveedores
    Private _ascCuentaCorrienteCompra As ModeloCuentaCorrienteCompra
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesOrdenDePago(), "ORDEN DE PAGO")

        AscUsuarios = New ModeloUsuario()
        AscProveedores = New ModeloProveedores()
        AscCuentaCorrienteCompra = New ModeloCuentaCorrienteCompra()
        Err = New Errores()
    End Sub

    Public Sub New(idOrdenDePago As Integer, nroComprobante As String, fecha As Date, importePesos As Double, importeDolares As Double,
                   observaciones As String, eliminado As String, ascUsuarios As ModeloUsuario, ascProveedores As ModeloProveedores, err As Errores, ascCuentaCorrienteCompra As ModeloCuentaCorrienteCompra)
        MyBase.New(New TransaccionesOrdenDePago(), "ORDEN DE PAGO")

        Me.IdOrdenDePago = idOrdenDePago
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.ImportePesos = importePesos
        Me.ImporteDolares = importeDolares
        Me.Observaciones = observaciones
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscProveedores = ascProveedores
        Me.Err = err
        Me.AscCuentaCorrienteCompra = ascCuentaCorrienteCompra
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdOrdenDePago As Integer
        Get
            Return _idOrdenDePago
        End Get
        Set(value As Integer)
            _idOrdenDePago = value
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

    Public Property AscProveedores As ModeloProveedores
        Get
            Return _ascProveedores
        End Get
        Set(value As ModeloProveedores)
            _ascProveedores = value
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

    Public Property AscCuentaCorrienteCompra As ModeloCuentaCorrienteCompra
        Get
            Return _ascCuentaCorrienteCompra
        End Get
        Set(value As ModeloCuentaCorrienteCompra)
            _ascCuentaCorrienteCompra = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdOrdenDePago.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdOrdenDePago.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloOrdenDePago)
        Dim resultado As New List(Of TablaOrdenDePago)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE ORDENES DE PAGO"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloOrdenDePago(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaOrdenDePago

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idOrdenDePago
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloOrdenDePago
        Dim resultado As New TablaOrdenDePago

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO ORDEN DE PAGO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.OrdenDePago(resultado)
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
    Private Function listModeloOrdenDePago(objeto As List(Of TablaOrdenDePago)) As List(Of ModeloOrdenDePago)
        Dim ordenesDePago As New List(Of ModeloOrdenDePago)

        For Each item In objeto
            ordenesDePago.Add(Drivers.OrdenDePago(item))
        Next

        Return ordenesDePago
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.OrdenDePago(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.OrdenDePago(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdOrdenDePago)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoID()
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verOrdenDePagoPorId(IdOrdenDePago)
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
