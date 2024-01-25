Imports AccesoDatos

Public Class ModeloDetalleRemitoVenta
    Inherits EnlaceTransacciones(Of TransaccionesDetalleRemitoVenta)

    Private _idDetalleRemitosVenta As Integer
    Private _Descripcion As String
    Private _Cantidad As Double
    Private _Unidad As String
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Facturado As String
    Private _Eliminado As String
    Private _ascArticulos As ModeloArticulos
    Private _ascRemitosVenta As ModeloRemitosVenta
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDetalleRemitoVenta(), "DETALLE REMITO VENTA")

        AscArticulos = New ModeloArticulos()
        AscRemitosVenta = New ModeloRemitosVenta()
        Err = New Errores()
    End Sub

    Public Sub New(idDetalleRemitosVenta As Integer, descripcion As String, cantidad As Double, unidad As String, precio As Double, importe As Double,
                   alicuotaIVA As Double, facturado As String, eliminado As String, ascArticulos As ModeloArticulos,
                   ascRemitosVenta As ModeloRemitosVenta, err As Errores)
        MyBase.New(New TransaccionesDetalleRemitoVenta(), "DETALLE REMITO VENTA")

        Me.IdDetalleRemitosVenta = idDetalleRemitosVenta
        Me.Descripcion = descripcion
        Me.Cantidad = cantidad
        Me.Unidad = unidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Facturado = facturado
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscRemitosVenta = ascRemitosVenta
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDetalleRemitosVenta As Integer
        Get
            Return _idDetalleRemitosVenta
        End Get
        Set(value As Integer)
            _idDetalleRemitosVenta = value
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

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set(value As Double)
            _Precio = value
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

    Public Property AlicuotaIVA As Double
        Get
            Return _AlicuotaIVA
        End Get
        Set(value As Double)
            _AlicuotaIVA = value
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

    Public Property AscArticulos As ModeloArticulos
        Get
            Return _ascArticulos
        End Get
        Set(value As ModeloArticulos)
            _ascArticulos = value
        End Set
    End Property

    Public Property AscRemitosVenta As ModeloRemitosVenta
        Get
            Return _ascRemitosVenta
        End Get
        Set(value As ModeloRemitosVenta)
            _ascRemitosVenta = value
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

    Public Function ModificarFacturacion() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE FACTURACION DE UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarFacturacion", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el estado de facturacion del registro [ID: " + IdDetalleRemitosVenta + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdRemitosVenta() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID REMITOS VENTA"

        EjecutarTransaccion("EliminarPorIdRemitosVenta", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdDetalleRemitosVenta + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdRemitosVentaYIdArticulo() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID REMITOS VENTA Y SU ID ARTICULO"

        EjecutarTransaccion("EliminarPorIdRemitosVentaYIdArticulo", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdDetalleRemitosVenta + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaDetalleRemitoVenta

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idDetalleRemitosVenta
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdRemitosVenta() As List(Of ModeloDetalleRemitoVenta)
        Dim resultado As New List(Of TablaDetalleRemitoVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE DETALLE REMITOS POR ID REMITOS VENTA"

        EjecutarTransaccion("ListasdoPorIdRemitosVenta", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.DetalleRemitoVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoFiltradoPorIdClienteYFacturado() As List(Of ModeloDetalleRemitoVenta)
        Dim resultado As New List(Of TablaDetalleRemitoVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID CLIENTE Y ESTADO DE FACTURACION"

        EjecutarTransaccion("ListadoFiltradoPorIdClienteYFacturado", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.DetalleRemitoVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoFiltradoPorIdCliente() As List(Of ModeloDetalleRemitoVenta)
        Dim resultado As New List(Of TablaDetalleRemitoVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID CLIENTE"

        EjecutarTransaccion("ListadoFiltradoPorIdCliente", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.DetalleRemitoVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloDetalleRemitoVenta
        Dim resultado As New TablaDetalleRemitoVenta

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.DetalleRemitoVenta(resultado)
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
                    resultado = Me.Transaccion.insRegistro(Drivers.DetalleRemitoVenta(Me))
                Case "ModificarFacturacion"
                    resultado = Me.Transaccion.modEstadoFacturacion(IdDetalleRemitosVenta, Facturado)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
                Case "EliminarPorIdRemitosVenta"
                    resultado = Me.Transaccion.elimRegistroPorIdRemitosVenta(AscRemitosVenta.IdRemitosVenta)
                Case "EliminarPorIdRemitosVentaYIdArticulo"
                    resultado = Me.Transaccion.elimRegistroPorIdRemitosVentaYIdArticulo(AscRemitosVenta.IdRemitosVenta, AscArticulos.IdArticulo)
                Case "ListasdoPorIdRemitosVenta"
                    resultado = Me.Transaccion.verRegistrosPorIdRemitosVenta(AscRemitosVenta.IdRemitosVenta)
                Case "ListadoFiltradoPorIdClienteYFacturado"
                    resultado = Me.Transaccion.verRegistroPorIdCliente_Facturado(AscRemitosVenta.AscClientes.IdCliente, Facturado)
                Case "ListadoFiltradoPorIdCliente"
                    resultado = Me.Transaccion.verRegistroPorIdCliente(AscRemitosVenta.AscClientes.IdCliente)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdDetalleRemitosVenta)
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
