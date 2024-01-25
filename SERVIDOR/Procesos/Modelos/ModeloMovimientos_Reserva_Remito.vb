Imports AccesoDatos

Public Class ModeloMovimientos_Reserva_Remito
    Inherits EnlaceTransacciones(Of TransaccionesMovimientos_Reserva_Remito)

    Private _idMovimientos_Reserva_Remito As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascPedidoMovimientos As ModeloPedidoMovimientos
    Private _ascRemitosVentaMovimientos As ModeloRemitosVentaMovimientos
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesMovimientos_Reserva_Remito(), "MOVIMIENTOS RESERVA REMITO")

        AscPedidosMovimientos = New ModeloPedidoMovimientos()
        AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos()
        Err = New Errores()
    End Sub

    Public Sub New(idMovimientos_Reserva_Remito As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   err As Errores, ascPedidoMovimientos As ModeloPedidoMovimientos, ascRemitosVentaMovimientos As ModeloRemitosVentaMovimientos)
        MyBase.New(New TransaccionesMovimientos_Reserva_Remito(), "MOVIMIENTOS RESERVA REMITO")

        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.Err = err
        Me.IdMovimientos_Reserva_Remito = idMovimientos_Reserva_Remito
        Me.AscPedidosMovimientos = ascPedidoMovimientos
        Me.AscRemitosVentaMovimientos = ascRemitosVentaMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"

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

    Public Property IdMovimientos_Reserva_Remito As Integer
        Get
            Return _idMovimientos_Reserva_Remito
        End Get
        Set(value As Integer)
            _idMovimientos_Reserva_Remito = value
        End Set
    End Property

    Public Property AscPedidosMovimientos As ModeloPedidoMovimientos
        Get
            Return _ascPedidoMovimientos
        End Get
        Set(value As ModeloPedidoMovimientos)
            _ascPedidoMovimientos = value
        End Set
    End Property

    Public Property AscRemitosVentaMovimientos As ModeloRemitosVentaMovimientos
        Get
            Return _ascRemitosVentaMovimientos
        End Get
        Set(value As ModeloRemitosVentaMovimientos)
            _ascRemitosVentaMovimientos = value
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
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdMovimientos_Reserva_Remito.ToString() + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function CantidadRemitada() As Double
        Dim resultado As New TablaMovimientos_Reserva_Remito

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD REMITADA DE UN DETALLE PEDIDO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadRemitada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad remitada del registro [ID: " + IdMovimientos_Reserva_Remito + "] de la tabla " + tabla
            End If

            Return Nothing
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
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdMovimientos_Reserva_Remito + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListasdoPorIdRemitosVenta() As List(Of ModeloMovimientos_Reserva_Remito)
        Dim resultado As New List(Of TablaMovimientos_Reserva_Remito)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO POR ID REMITOS VENTA"

        EjecutarTransaccion("ListasdoPorIdRemitosVenta", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloMovimientos_Reserva_Remito)

            For Each item In resultado
                lista.Add(Drivers.Movimientos_Reserva_Remito(item))
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

    Public Function ListasdoPorIdDetalleRemitosVenta() As List(Of ModeloMovimientos_Reserva_Remito)
        Dim resultado As New List(Of TablaMovimientos_Reserva_Remito)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO POR ID DETALLE REMITOS VENTA"

        EjecutarTransaccion("ListasdoPorIdDetalleRemitosVenta", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloMovimientos_Reserva_Remito)

            For Each item In resultado
                lista.Add(Drivers.Movimientos_Reserva_Remito(item))
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
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaMovimientos_Reserva_Remito With {
                                    .Fecha = Fecha,
                                    .Tipo = Tipo,
                                    .Cantidad = Cantidad,
                                    .Eliminado = Eliminado,
                                    .ascPedidosMovimientos = New TablaPedidoMovimientos With {
                                        .idPedidosMovimientos = AscPedidosMovimientos.IdPedidosMovimientos
                                    },
                                    .ascRemitosVentaMovimientos = New TablaRemitosVentaMovimientos With {
                                        .idRemitosVentasMovimientos = AscRemitosVentaMovimientos.IdRemitosVentasMovimientos
                                    }
                                })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdMovimientos_Reserva_Remito)
                Case "CantidadRemitada"
                    resultado = Me.Transaccion.verCantidadRemitada(AscPedidosMovimientos.AscPedidosDetalle.IdPedidosDetalle)
                Case "EliminarPorIdRemitosVenta"
                    resultado = Me.Transaccion.elimRegistroPorIdRemitosVenta(AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscRemitosVenta.IdRemitosVenta)
                Case "ListasdoPorIdRemitosVenta"
                    resultado = Me.Transaccion.verRegistrosPorIdRemitosVenta(AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscRemitosVenta.IdRemitosVenta)
                Case "ListasdoPorIdDetalleRemitosVenta"
                    resultado = Me.Transaccion.verRegistrosPorIdDetalleRemitosVenta(AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta)
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
