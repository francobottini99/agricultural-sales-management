Imports AccesoDatos

Public Class ModeloOrdenDePagoDetalle
    Inherits EnlaceTransacciones(Of TransaccionesOrdenDePagoDetalle)

    Private _idOrdenPagoDetalle As Integer
    Private _MedioPago As String
    Private _NroComprobante As String
    Private _EntidadEmisora As String
    Private _SucursalEntidad As String
    Private _Librador As String
    Private _FechaCobro As Date
    Private _Moneda As String
    Private _Importe As Double
    Private _Eliminado As String
    Private _ascOrdenDePago As ModeloOrdenDePago
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesOrdenDePagoDetalle(), "ORDEN DE PAGO DETALLE")

        Err = New Errores()
        AscOrdenDePago = New ModeloOrdenDePago()
    End Sub

    Public Sub New(idOrdenPagoDetalle As Integer, medioPago As String, nroComprobante As String, entidadEmisora As String, sucursalEntidad As String,
                   librador As String, fechaCobro As Date, moneda As String, importe As Double, eliminado As String, ascOrdenDePago As ModeloOrdenDePago, err As Errores)
        MyBase.New(New TransaccionesOrdenDePagoDetalle(), "ORDEN DE PAGO DETALLE")

        Me.IdOrdenPagoDetalle = idOrdenPagoDetalle
        Me.MedioPago = medioPago
        Me.NroComprobante = nroComprobante
        Me.EntidadEmisora = entidadEmisora
        Me.SucursalEntidad = sucursalEntidad
        Me.Librador = librador
        Me.FechaCobro = fechaCobro
        Me.Moneda = moneda
        Me.Importe = importe
        Me.Eliminado = eliminado
        Me.AscOrdenDePago = ascOrdenDePago
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdOrdenPagoDetalle As Integer
        Get
            Return _idOrdenPagoDetalle
        End Get
        Set(value As Integer)
            _idOrdenPagoDetalle = value
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

    Public Property AscOrdenDePago As ModeloOrdenDePago
        Get
            Return _ascOrdenDePago
        End Get
        Set(value As ModeloOrdenDePago)
            _ascOrdenDePago = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdOrdenPagoDetalle.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdOrdenPagoDetalle.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloOrdenDePagoDetalle)
        Dim resultado As New List(Of TablaOrdenDePagoDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE ORDEN DE PAGO DETALLE"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listOrdenDePagoDetalle(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function EliminarPorIdOrdenDePago() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS REGISTROS IDENTIFICADOS POR LA ID ORDEN DE PAGO"

        EjecutarTransaccion("EliminarPorIdOrdenDePago", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdOrdenPagoDetalle.ToString() + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listOrdenDePagoDetalle(objeto As List(Of TablaOrdenDePagoDetalle)) As List(Of ModeloOrdenDePagoDetalle)
        Dim ordenesDePagoDetalle As New List(Of ModeloOrdenDePagoDetalle)

        For Each item In objeto
            ordenesDePagoDetalle.Add(Drivers.OrdenDePagoDetalle(item))
        Next

        Return ordenesDePagoDetalle
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.OrdenDePagoDetalle(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.OrdenDePagoDetalle(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdOrdenPagoDetalle)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "EliminarPorIdOrdenDePago"
                    resultado = Me.Transaccion.elimRegistroPorIdOrdenDePago(AscOrdenDePago.IdOrdenDePago)
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
