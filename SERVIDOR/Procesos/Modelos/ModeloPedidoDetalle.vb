Imports AccesoDatos

Public Class ModeloPedidoDetalle
    Inherits EnlaceTransacciones(Of TransaccionesPedidoDetalle)

    Private _idPedidosDetalle As Integer
    Private _Cantidad As Double
    Private _Remitado As String
    Private _Facturado As String
    Private _Eliminado As String
    Private _ascArticulos As ModeloArticulos
    Private _ascPedidos As ModeloPedidos
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesPedidoDetalle(), "PEDIDO DETALLE")

        AscArticulos = New ModeloArticulos()
        AscPedidos = New ModeloPedidos()
        Err = New Errores()
    End Sub

    Public Sub New(idPedidosDetalle As Integer, cantidad As Double, remitado As String, facturado As String,
                   eliminado As String, ascArticulos As ModeloArticulos, ascPedidos As ModeloPedidos, err As Errores)
        MyBase.New(New TransaccionesPedidoDetalle(), "PEDIDO DETALLE")

        Me.IdPedidosDetalle = idPedidosDetalle
        Me.Cantidad = cantidad
        Me.Remitado = remitado
        Me.Facturado = facturado
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscPedidos = ascPedidos
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdPedidosDetalle As Integer
        Get
            Return _idPedidosDetalle
        End Get
        Set(value As Integer)
            _idPedidosDetalle = value
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

    Public Property AscArticulos As ModeloArticulos
        Get
            Return _ascArticulos
        End Get
        Set(value As ModeloArticulos)
            _ascArticulos = value
        End Set
    End Property

    Public Property AscPedidos As ModeloPedidos
        Get
            Return _ascPedidos
        End Get
        Set(value As ModeloPedidos)
            _ascPedidos = value
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

    Public Property Remitado As String
        Get
            Return _Remitado
        End Get
        Set(value As String)
            _Remitado = value
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

    Public Function UltimoId() As Integer
        Dim resultado As New TablaPedidoDetalle

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idPedidosDetalle
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdPedidosDetalle + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdPedido() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"

        EjecutarTransaccion("EliminarPorIdPedido", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdPedidosDetalle + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloPedidoDetalle)
        Dim resultado As New List(Of TablaPedidoDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE PEDIDOS DETALLE"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloModeloPedidoDetalle(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de pedidos de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoPorIdCliente() As List(Of ModeloPedidoDetalle)
        Dim resultado As New List(Of TablaPedidoDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID CLIENTE"

        EjecutarTransaccion("ListadoPorIdCliente", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloModeloPedidoDetalle_Pedidos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoFiltradoPorIdClienteYRemitado() As List(Of ModeloPedidoDetalle)
        Dim resultado As New List(Of TablaPedidoDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID CLIENTE Y ESTADO DE REMITACION"

        EjecutarTransaccion("ListadoFiltradoPorIdClienteYRemitado", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloModeloPedidoDetalle_Pedidos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoFiltradoPorIdClienteYFacturado() As List(Of ModeloPedidoDetalle)
        Dim resultado As New List(Of TablaPedidoDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID CLIENTE Y ESTADO DE FACTURACION"

        EjecutarTransaccion("ListadoFiltradoPorIdClienteYFacturado", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloModeloPedidoDetalle_Pedidos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoPorIdPedidos() As List(Of ModeloPedidoDetalle)
        Dim resultado As New List(Of TablaPedidoDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID PEDIDO"

        EjecutarTransaccion("ListadoPorIdPedidos", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloModeloPedidoDetalle(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloPedidoDetalle
        Dim resultado As New TablaPedidoDetalle

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloPedidoDetalle With {
                                .IdPedidosDetalle = resultado.idPedidosDetalle,
                                .Cantidad = resultado.Cantidad,
                                .Remitado = resultado.Remitado,
                                .Facturado = resultado.Facturado,
                                .AscArticulos = New ModeloArticulos With {
                                    .IdArticulo = resultado.ascArticulos.idArticulo,
                                    .CodArticulo = resultado.ascArticulos.CodArticulo,
                                    .Detalle = resultado.ascArticulos.Detalle,
                                    .Unidad = resultado.ascArticulos.Unidad
                                },
                                .AscPedidos = New ModeloPedidos With {.IdPedidos = resultado.ascPedidos.idPedidos}
                           }
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ModificarEstado() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE FACTURACION Y REMITADO DE UN REGISTRO ESPECIFICO"

        EjecutarTransaccion("ModificarEstado", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el estado del registro [ID: " + IdPedidosDetalle + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarEstadoRemitado() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE REMITADO DE UN REGISTRO ESPECIFICO"

        EjecutarTransaccion("ModificarEstadoRemitado", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el estado del registro [ID: " & IdPedidosDetalle & "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarEstadoFacturado() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE FACTURADO DE UN REGISTRO ESPECIFICO"

        EjecutarTransaccion("ModificarEstadoFacturado", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el estado del registro [ID: " & IdPedidosDetalle & "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloModeloPedidoDetalle(objeto As List(Of TablaPedidoDetalle)) As List(Of ModeloPedidoDetalle)
        Dim pedDetalle As New List(Of ModeloPedidoDetalle)

        For Each item In objeto
            pedDetalle.Add(New ModeloPedidoDetalle With {
                                .IdPedidosDetalle = item.idPedidosDetalle,
                                .Cantidad = item.Cantidad,
                                .Remitado = item.Remitado,
                                .Facturado = item.Facturado,
                                .AscArticulos = New ModeloArticulos With {
                                    .IdArticulo = item.ascArticulos.idArticulo,
                                    .CodArticulo = item.ascArticulos.CodArticulo,
                                    .Detalle = item.ascArticulos.Detalle,
                                    .Unidad = item.ascArticulos.Unidad
                                },
                                .AscPedidos = New ModeloPedidos With {.IdPedidos = item.ascPedidos.idPedidos}
                           })
        Next

        Return pedDetalle
    End Function

    Private Function listModeloModeloPedidoDetalle_Pedidos(objeto As List(Of TablaPedidoDetalle)) As List(Of ModeloPedidoDetalle)
        Dim pedDetalle As New List(Of ModeloPedidoDetalle)

        For Each item In objeto
            pedDetalle.Add(New ModeloPedidoDetalle With {
                        .IdPedidosDetalle = item.idPedidosDetalle,
                        .Cantidad = item.Cantidad,
                        .Remitado = item.Remitado,
                        .Facturado = item.Facturado,
                        .AscArticulos = New ModeloArticulos With {
                            .IdArticulo = item.ascArticulos.idArticulo,
                            .CodArticulo = item.ascArticulos.CodArticulo,
                            .Detalle = item.ascArticulos.Detalle
                        },
                        .AscPedidos = New ModeloPedidos With {
                            .IdPedidos = item.ascPedidos.idPedidos,
                            .NroPedido = item.ascPedidos.NroPedido,
                            .Fecha = item.ascPedidos.Fecha,
                            .FechaCierrePedido = item.ascPedidos.FechaCierrePedido,
                            .Observaciones = item.ascPedidos.Observaciones,
                            .AscClientes = New ModeloCliente With {
                                .IdCliente = item.ascPedidos.ascClientes.idCliente
                            },
                            .AscUsuarios = New ModeloUsuario With {
                                .IdUsuarios = item.ascPedidos.ascUsuarios.idUsuario
                            }
                        }
                    })
        Next

        Return pedDetalle
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaPedidoDetalle With {
                                                                .Cantidad = Cantidad,
                                                                .Remitado = Remitado,
                                                                .Facturado = Facturado,
                                                                .Eliminado = Eliminado,
                                                                .ascArticulos = New TablaArticulos With {.idArticulo = AscArticulos.IdArticulo},
                                                                .ascPedidos = New TablaPedidos With {.idPedidos = AscPedidos.IdPedidos}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaPedidoDetalle With {
                                                                .idPedidosDetalle = IdPedidosDetalle,
                                                                .Cantidad = Cantidad,
                                                                .Remitado = Remitado,
                                                                .Facturado = Facturado,
                                                                .Eliminado = Eliminado,
                                                                .ascArticulos = New TablaArticulos With {.idArticulo = AscArticulos.IdArticulo},
                                                                .ascPedidos = New TablaPedidos With {.idPedidos = AscPedidos.IdPedidos}
                                                           })
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "EliminarPorIdPedido"
                    resultado = Me.Transaccion.elimRegistroPorIdPedido(AscPedidos.IdPedidos)
                Case "ModificarEstado"
                    resultado = Me.Transaccion.modEstado(IdPedidosDetalle, Remitado, Facturado)
                Case "ModificarEstadoRemitado"
                    resultado = Me.Transaccion.modEstadoRemitado(IdPedidosDetalle, Remitado)
                Case "ModificarEstadoFacturado"
                    resultado = Me.Transaccion.modEstadoFacturado(IdPedidosDetalle, Facturado)
                Case "ListadoPorIdPedidos"
                    resultado = Me.Transaccion.verRegistrosPorIdPedido(AscPedidos.IdPedidos)
                Case "ListadoPorIdCliente"
                    resultado = Me.Transaccion.verRegistrosPorIdCliente(AscPedidos.AscClientes.IdCliente)
                Case "ListadoFiltradoPorIdClienteYRemitado"
                    resultado = Me.Transaccion.verRegistroPorIdCliente_Remitado(AscPedidos.AscClientes.IdCliente, Remitado)
                Case "ListadoFiltradoPorIdClienteYFacturado"
                    resultado = Me.Transaccion.verRegistroPorIdCliente_Facturado(AscPedidos.AscClientes.IdCliente, Facturado)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdPedidosDetalle)
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
