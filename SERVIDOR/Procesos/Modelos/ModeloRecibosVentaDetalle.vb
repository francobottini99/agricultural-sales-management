Imports AccesoDatos

Public Class ModeloRecibosVentaDetalle
    Inherits EnlaceTransacciones(Of TransaccionesRecibosVentaDetalle)

    Private _idRecibosVentaDetalle As Integer
    Private _MedioPago As String
    Private _NroComprobante As String
    Private _EntidadEmisora As String
    Private _SucursalEntidad As String
    Private _Librador As String
    Private _FechaCobro As Date
    Private _Moneda As String
    Private _Importe As Double
    Private _Eliminado As String
    Private _ascRecibosVenta As ModeloRecibosVenta
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRecibosVentaDetalle(), "RECIBOS VENTA DETALLE")

        Err = New Errores()
        AscRecibosVenta = New ModeloRecibosVenta()
    End Sub

    Public Sub New(idRecibosVentaDetalle As Integer, medioPago As String, nroComprobante As String, entidadEmisora As String,
                   sucursalEntidad As String, librador As String, fechaCobro As Date, moneda As String, importe As Double,
                   eliminado As String, ascRecibosVenta As ModeloRecibosVenta, err As Errores)
        MyBase.New(New TransaccionesRecibosVentaDetalle(), "RECIBOS VENTA DETALLE")

        Me.IdRecibosVentaDetalle = idRecibosVentaDetalle
        Me.MedioPago = medioPago
        Me.NroComprobante = nroComprobante
        Me.EntidadEmisora = entidadEmisora
        Me.SucursalEntidad = sucursalEntidad
        Me.Librador = librador
        Me.FechaCobro = fechaCobro
        Me.Moneda = moneda
        Me.Importe = importe
        Me.Eliminado = eliminado
        Me.AscRecibosVenta = ascRecibosVenta
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRecibosVentaDetalle As Integer
        Get
            Return _idRecibosVentaDetalle
        End Get
        Set(value As Integer)
            _idRecibosVentaDetalle = value
        End Set
    End Property

    Public Property MedioPago As String
        Get
            Return _MedioPago
        End Get
        Set(value As String)
            _MedioPago = value
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

    Public Property EntidadEmisora As String
        Get
            Return _EntidadEmisora
        End Get
        Set(value As String)
            _EntidadEmisora = value
        End Set
    End Property

    Public Property SucursalEntidad As String
        Get
            Return _SucursalEntidad
        End Get
        Set(value As String)
            _SucursalEntidad = value
        End Set
    End Property

    Public Property Librador As String
        Get
            Return _Librador
        End Get
        Set(value As String)
            _Librador = value
        End Set
    End Property

    Public Property FechaCobro As Date
        Get
            Return _FechaCobro
        End Get
        Set(value As Date)
            _FechaCobro = value
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

    Public Property Importe As Double
        Get
            Return _Importe
        End Get
        Set(value As Double)
            _Importe = value
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

    Public Property AscRecibosVenta As ModeloRecibosVenta
        Get
            Return _ascRecibosVenta
        End Get
        Set(value As ModeloRecibosVenta)
            _ascRecibosVenta = value
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

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdRecibosVentaDetalle.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRecibosVentaDetalle.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloRecibosVentaDetalle)
        Dim resultado As New List(Of TablaRecibosVentaDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE RECIBOS VENTA DETALLE"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listReciboVentaDetalle(resultado)
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
    Private Function listReciboVentaDetalle(objeto As List(Of TablaRecibosVentaDetalle)) As List(Of ModeloRecibosVentaDetalle)
        Dim recibosVentaDetalle As New List(Of ModeloRecibosVentaDetalle)

        For Each item In objeto
            recibosVentaDetalle.Add(Drivers.RecibosVentaDetalle(item))
        Next

        Return recibosVentaDetalle
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.RecibosVentaDetalle(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.RecibosVentaDetalle(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdRecibosVentaDetalle)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
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
