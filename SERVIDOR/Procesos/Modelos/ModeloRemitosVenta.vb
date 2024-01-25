Imports AccesoDatos

Public Class ModeloRemitosVenta
    Inherits EnlaceTransacciones(Of TransaccionesRemitosVenta)

    Private _idRemitosVenta As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _Importe As Double
    Private _Observaciones As String
    Private _ImpOriginal As Integer
    Private _ImpCopia As Integer
    Private _Facturado As String
    Private _Eliminado As String
    Private _CAE As String
    Private _FechaVtoCAE As Date
    Private _ascClientes As ModeloCliente
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRemitosVenta(), "REMITOS VENTA")

        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idRemitosVenta As Integer, nroComprobante As String, fecha As Date, importe As Double, observaciones As String, impOriginal As Integer,
                   impCopia As Integer, facturado As String, eliminado As String, cae As String, fecvtocae As Date, ascClientes As ModeloCliente,
                   ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesRemitosVenta(), "REMITOS VENTA")

        Me.IdRemitosVenta = idRemitosVenta
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.Importe = importe
        Me.Observaciones = observaciones
        Me.ImpOriginal = impOriginal
        Me.ImpCopia = impCopia
        Me.Facturado = facturado
        Me.Eliminado = eliminado
        Me.CAE = cae
        Me.FechaVtoCAE = fecvtocae
        Me.AscClientes = ascClientes
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRemitosVenta As Integer
        Get
            Return _idRemitosVenta
        End Get
        Set(value As Integer)
            _idRemitosVenta = value
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

    Public Property Facturado As String
        Get
            Return _Facturado
        End Get
        Set(value As String)
            _Facturado = value
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

    Public Property CAE As String
        Get
            Return _CAE
        End Get
        Set(value As String)
            _CAE = value
        End Set
    End Property

    Public Property FechaVtoCAE As Date
        Get
            Return _FechaVtoCAE
        End Get
        Set(value As Date)
            _FechaVtoCAE = value
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

    Public Function Modificar() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el registro [ID: " + IdRemitosVenta + "] en la tabla " + tabla
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
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRemitosVenta + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarEstadoFacturacion() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE FACTURACION DE UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarEstadoFacturacion", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el estado de facturacion del registro [ID: " + IdRemitosVenta + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaRemitosVenta

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idRemitosVenta
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoSinFacturar() As List(Of ModeloRemitosVenta)
        Dim resultado As New List(Of TablaRemitosVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE REMITOS SIN FACTURAR"

        EjecutarTransaccion("ListadoSinFacturar", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.RemitoVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de remitos sin facturar de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloRemitosVenta)
        Dim resultado As New List(Of TablaRemitosVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE REMITOS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.RemitoVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de remitos de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloRemitosVenta
        Dim resultado As New TablaRemitosVenta

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO REMITOS VENTA IDENTIFICADO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.RemitoVenta(resultado)
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
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.RemitoVenta(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.RemitoVenta(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdRemitosVenta)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ModificarEstadoFacturacion"
                    resultado = Me.Transaccion.modEstadoFacturacion(IdRemitosVenta, Facturado)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
                Case "ListadoSinFacturar"
                    resultado = Me.Transaccion.verSinFacturar()
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdRemitosVenta)
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
