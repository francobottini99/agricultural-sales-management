Imports AccesoDatos

Public Class ModeloPedidoMovimientos
    Inherits EnlaceTransacciones(Of TransaccionesPedidoMovimientos)

    Private _idPedidosMovimientos As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _ascPedidosDetalle As ModeloPedidoDetalle
    Private _ascStock As ModeloStock
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesPedidoMovimientos(), "PEDIDOS MOVIMIENTOS")

        AscUsuarios = New ModeloUsuario
        AscPedidosDetalle = New ModeloPedidoDetalle
        Err = New Errores()
    End Sub

    Public Sub New(idPedidosMovimientos As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascUsuarios As ModeloUsuario, ascPedidosDetalle As ModeloPedidoDetalle, err As Errores, ascStock As ModeloStock)
        MyBase.New(New TransaccionesPedidoMovimientos(), "PEDIDOS MOVIMIENTOS")

        Me.IdPedidosMovimientos = idPedidosMovimientos
        Me.Fecha = fecha
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscPedidosDetalle = ascPedidosDetalle
        Me.Err = err
        Me.Tipo = tipo
        Me.AscStock = ascStock
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdPedidosMovimientos As Integer
        Get
            Return _idPedidosMovimientos
        End Get
        Set(value As Integer)
            _idPedidosMovimientos = value
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

    Public Property AscUsuarios As ModeloUsuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As ModeloUsuario)
            _ascUsuarios = value
        End Set
    End Property

    Public Property AscPedidosDetalle As ModeloPedidoDetalle
        Get
            Return _ascPedidosDetalle
        End Get
        Set(value As ModeloPedidoDetalle)
            _ascPedidosDetalle = value
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

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property AscStock As ModeloStock
        Get
            Return _ascStock
        End Get
        Set(value As ModeloStock)
            _ascStock = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdPedidosMovimientos + "] en la tabla " + tabla

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
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdPedidosMovimientos.ToString + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdPedidosDetalle() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA UN REGISTRO ESPECIFICADO POR EL ID PEDIDOS DETALLE"

        EjecutarTransaccion("EliminarPorIdPedidosDetalle", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdPedidosMovimientos + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorCampos() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA UN REGISTRO ESPECIFICADO POR SUS CAMPOS"

        EjecutarTransaccion("EliminarPorCampos", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdPedidosMovimientos + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoPorIdPedidosDetalle() As List(Of ModeloPedidoMovimientos)
        Dim resultado As New List(Of TablaPedidoMovimientos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE PEDIDOS MOVIMIENTOS FILTRADO POR ID PEDIDOS DETALLE"

        EjecutarTransaccion("ListadoPorIdPedidosDetalle", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloPedidosMovimientos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de pedidos de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoPorIdPedidosDetalleTipo() As List(Of ModeloPedidoMovimientos)
        Dim resultado As New List(Of TablaPedidoMovimientos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE PEDIDOS MOVIMIENTOS FILTRADO POR ID PEDIDOS DETALLE Y TIPO"

        EjecutarTransaccion("ListadoPorIdPedidosDetalleTipo", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloPedidosMovimientos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de pedidos de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadRetirada() As Double
        Dim resultado As New TablaPedidoMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD RETIRADA DETALLE PEDIDO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadRetirada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad retirada del detalle pedido [ID: " + AscPedidosDetalle.IdPedidosDetalle + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadAnulada() As Double
        Dim resultado As New TablaPedidoMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD ANULADA DETALLE PEDIDO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadAnulada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad anulada del detalle pedido [ID: " + AscPedidosDetalle.IdPedidosDetalle + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadReservada() As Double
        Dim resultado As New TablaPedidoMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD RESERVADA DETALLE PEDIDO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadReservada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad reservada del detalle pedido [ID: " + AscPedidosDetalle.IdPedidosDetalle + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadFacturada() As Double
        Dim resultado As New TablaPedidoMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURAD DETALLE PEDIDO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del detalle pedido [ID: " + AscPedidosDetalle.IdPedidosDetalle + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadRemitada() As Double
        Dim resultado As New TablaPedidoMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD REMITADA DETALLE PEDIDO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadRemitada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad remitada del detalle pedido [ID: " + AscPedidosDetalle.IdPedidosDetalle + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaPedidoMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idPedidosMovimientos
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
    Private Function listModeloPedidosMovimientos(objeto As List(Of TablaPedidoMovimientos)) As List(Of ModeloPedidoMovimientos)
        Dim pedidos As New List(Of ModeloPedidoMovimientos)

        For Each item In objeto
            pedidos.Add(New ModeloPedidoMovimientos With {
                            .IdPedidosMovimientos = item.idPedidosMovimientos,
                            .Fecha = item.Fecha,
                            .Tipo = item.Tipo,
                            .Cantidad = item.Cantidad,
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario},
                            .AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = item.ascPedidosDetalle.idPedidosDetalle},
                            .AscStock = New ModeloStock With {.IdStock = item.ascStock.idStock}
                        })
        Next

        Return pedidos
    End Function


    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaPedidoMovimientos With {
                                    .Fecha = Fecha,
                                    .Tipo = Tipo,
                                    .Cantidad = Cantidad,
                                    .Eliminado = Eliminado,
                                    .ascUsuarios = New TablaUsuarios With {
                                        .idUsuario = AscUsuarios.IdUsuarios
                                    },
                                    .ascPedidosDetalle = New TablaPedidoDetalle With {
                                        .idPedidosDetalle = AscPedidosDetalle.IdPedidosDetalle
                                    },
                                    .ascStock = New TablaStock With {
                                        .idStock = AscStock.IdStock
                                    }
                                })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaPedidoMovimientos With {
                                    .idPedidosMovimientos = IdPedidosMovimientos,
                                    .Fecha = Fecha,
                                    .Tipo = Tipo,
                                    .Cantidad = Cantidad,
                                    .Eliminado = Eliminado,
                                    .ascUsuarios = New TablaUsuarios With {
                                        .idUsuario = AscUsuarios.IdUsuarios
                                    },
                                    .ascPedidosDetalle = New TablaPedidoDetalle With {
                                        .idPedidosDetalle = AscPedidosDetalle.IdPedidosDetalle
                                    },
                                    .ascStock = New TablaStock With {
                                        .idStock = AscStock.IdStock
                                    }
                                })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdPedidosMovimientos)
                Case "EliminarPorIdPedidosDetalle"
                    resultado = Me.Transaccion.elimRegistroPorIdPedidoDetalle(AscPedidosDetalle.IdPedidosDetalle)
                Case "EliminarPorCampos"
                    resultado = Me.Transaccion.elimRegistroPorCampos(New TablaPedidoMovimientos With {
                                                                            .Tipo = Tipo,
                                                                            .Cantidad = Cantidad,
                                                                            .ascPedidosDetalle = New TablaPedidoDetalle With {.idPedidosDetalle = AscPedidosDetalle.IdPedidosDetalle}
                                                                     })
                Case "ListadoPorIdPedidosDetalle"
                    resultado = Me.Transaccion.verRegistrosPorIdPedidoDetalle(AscPedidosDetalle.IdPedidosDetalle)
                Case "ListadoPorIdPedidosDetalleTipo"
                    resultado = Me.Transaccion.verRegistrosPorIdPedidoDetalleTipo(AscPedidosDetalle.IdPedidosDetalle, Tipo)
                Case "CantidadAnulada"
                    resultado = Me.Transaccion.verCantidadAnulada(AscPedidosDetalle.IdPedidosDetalle)
                Case "CantidadRetirada"
                    resultado = Me.Transaccion.verCantidadRetirada(AscPedidosDetalle.IdPedidosDetalle)
                Case "CantidadReservada"
                    resultado = Me.Transaccion.verCantidadReservada(AscPedidosDetalle.IdPedidosDetalle)
                Case "CantidadFacturada"
                    resultado = Me.Transaccion.verCantidadFacturada(AscPedidosDetalle.IdPedidosDetalle)
                Case "CantidadRemitada"
                    resultado = Me.Transaccion.verCantidadRemitada(AscPedidosDetalle.IdPedidosDetalle)
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
