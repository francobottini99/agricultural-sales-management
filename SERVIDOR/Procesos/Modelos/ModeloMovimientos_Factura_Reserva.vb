Imports AccesoDatos

Public Class ModeloMovimientos_Factura_Reserva
    Inherits EnlaceTransacciones(Of TransaccionesMovimientos_Factura_Reserva)

    Private _idMovimientos_Factura_Reseva As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascFacturaVentaMovimientos As ModeloFacturaVentaMovimientos
    Private _ascPedidoMovimientos As ModeloPedidoMovimientos
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesMovimientos_Factura_Reserva(), "MOVIMIENTOS FACTURA RESERVA")

        AscFacturaVentaMovimientos = New ModeloFacturaVentaMovimientos()
        AscPedidoMovimientos = New ModeloPedidoMovimientos()
        Err = New Errores()
    End Sub

    Public Sub New(idMovimientos_Factura_Reseva As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   err As Errores, ascFacturaVentaMovimientos As ModeloFacturaVentaMovimientos, ascPedidoMovimientos As ModeloPedidoMovimientos)
        MyBase.New(New TransaccionesMovimientos_Factura_Reserva(), "MOVIMIENTOS FACTURA RESERVA")

        Me.IdMovimientos_Factura_Reseva = idMovimientos_Factura_Reseva
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.Err = err
        Me.AscFacturaVentaMovimientos = ascFacturaVentaMovimientos
        Me.AscPedidoMovimientos = ascPedidoMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMovimientos_Factura_Reseva As Integer
        Get
            Return _idMovimientos_Factura_Reseva
        End Get
        Set(value As Integer)
            _idMovimientos_Factura_Reseva = value
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

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
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

    Public Property Eliminado As String
        Get
            Return _Eliminado
        End Get
        Set(value As String)
            _Eliminado = value
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

    Public Property AscFacturaVentaMovimientos As ModeloFacturaVentaMovimientos
        Get
            Return _ascFacturaVentaMovimientos
        End Get
        Set(value As ModeloFacturaVentaMovimientos)
            _ascFacturaVentaMovimientos = value
        End Set
    End Property

    Public Property AscPedidoMovimientos As ModeloPedidoMovimientos
        Get
            Return _ascPedidoMovimientos
        End Get
        Set(value As ModeloPedidoMovimientos)
            _ascPedidoMovimientos = value
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


    Public Function CantidadFacturada() As Double
        Dim resultado As New TablaMovimientos_Factura_Reserva

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURADA DE UN DETALLE PEDIDO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del registro [ID: " + IdMovimientos_Factura_Reseva + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdDetalleRemitosVenta() As List(Of ModeloMovimientos_Factura_Reserva)
        Dim resultado As New List(Of TablaMovimientos_Factura_Reserva)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO POR ID DETALLE FACTURA VENTA"

        EjecutarTransaccion("ListasdoPorIdDetalleFacturaVenta", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloMovimientos_Factura_Reserva)

            For Each item In resultado
                lista.Add(Drivers.Movimientos_Factura_Reserva(item))
            Next

            Return lista
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function EliminarPorIdFacturaVentaMovimientos() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID FACUTRA VENTA MOVIMIENTOS"

        EjecutarTransaccion("EliminarPorIdFacturaVentaMovimientos", resultado)

        If Not IsNothing(resultado) Then
            Return True

            'If resultado > 0 Then
            '    Return True
            'Else
            '    If Err.Descripcion = "-" Then
            '        Err.Identificador = EnumErrores.ERROR_INFORMACION
            '        Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdMovimientos_Factura_Reseva.ToString() + "] de la tabla " + tabla
            '    End If

            '    Return False
            'End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaMovimientos_Factura_Reserva With {
                                                                .Fecha = Fecha,
                                                                .Tipo = Tipo,
                                                                .Cantidad = Cantidad,
                                                                .Eliminado = Eliminado,
                                                                .ascPedidoMovimientos = New TablaPedidoMovimientos With {.idPedidosMovimientos = AscPedidoMovimientos.IdPedidosMovimientos},
                                                                .ascFacturaVentaMovimientos = New TablaFacturaVentaMovimientos With {.idFacturaVentaMovimientos = AscFacturaVentaMovimientos.IdFacturaVentaMovimientos}
                                                           })
                Case "ListasdoPorIdDetalleFacturaVenta"
                    resultado = Me.Transaccion.verRegistrosPorIdDetalleFacturaVenta(AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle)
                Case "CantidadFacturada"
                    resultado = Me.Transaccion.verCantidadFacturada(AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle)
                Case "EliminarPorIdFacturaVentaMovimientos"
                    resultado = Me.Transaccion.elimRegistroPorIdFacturaVentaMovimientos(AscFacturaVentaMovimientos.IdFacturaVentaMovimientos)
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
