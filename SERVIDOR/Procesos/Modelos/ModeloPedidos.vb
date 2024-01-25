Imports AccesoDatos

Public Class ModeloPedidos
    Inherits EnlaceTransacciones(Of TransaccionesPedidos)

    Private _idPedidos As Integer
    Private _NroPedido As String
    Private _Fecha As Date
    Private _FechaCierrePedido As Date
    Private _Remitado As String
    Private _Facturado As String
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _ascClientes As ModeloCliente
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesPedidos(), "PEDIDOS")

        AscClientes = New ModeloCliente()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idPedidos As Integer, nroPedido As String, fecha As Date, fechaCierrePedido As Date, remitado As String, facturado As String,
                   observaciones As String, eliminado As String, ascUsuarios As ModeloUsuario, ascClientes As ModeloCliente, err As Errores)
        MyBase.New(New TransaccionesPedidos(), "PEDIDOS")

        Me.IdPedidos = idPedidos
        Me.NroPedido = nroPedido
        Me.Fecha = fecha
        Me.FechaCierrePedido = fechaCierrePedido
        Me.Remitado = remitado
        Me.Facturado = facturado
        Me.Observaciones = observaciones
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscClientes = ascClientes
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdPedidos As Integer
        Get
            Return _idPedidos
        End Get
        Set(value As Integer)
            _idPedidos = value
        End Set
    End Property

    Public Property NroPedido As String
        Get
            Return _NroPedido
        End Get
        Set(value As String)
            _NroPedido = value
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

    Public Property FechaCierrePedido As Date
        Get
            Return _FechaCierrePedido
        End Get
        Set(value As Date)
            _FechaCierrePedido = value
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

    Public Property AscClientes As ModeloCliente
        Get
            Return _ascClientes
        End Get
        Set(value As ModeloCliente)
            _ascClientes = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdPedidos.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdPedidos.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoFiltradoPorFacturadoYRemitado() As List(Of ModeloPedidos)
        Dim resultado As New List(Of TablaPedidos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE PEDIDOS FILTRADO POR EL ESTADO DE REMITADO Y FACTURADO"

        EjecutarTransaccion("ListadoFiltradoPorFacturadoYRemitado", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloPedidos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de pedidos de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoFiltradoPorRemitado() As List(Of ModeloPedidos)
        Dim resultado As New List(Of TablaPedidos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE PEDIDOS FILTRADO POR EL ESTADO DE REMITADO"

        EjecutarTransaccion("ListadoFiltradoPorRemitado", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloPedidos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de pedidos de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloPedidos)
        Dim resultado As New List(Of TablaPedidos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE PEDIDOS FILTRADO POR ESTADO DE REMITADO Y FACTURADO"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloPedidos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de pedidos de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloPedidos
        Dim resultado As New TablaPedidos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO PEDIDOS IDENTIFICADO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloPedidos With {
                            .IdPedidos = resultado.idPedidos,
                            .NroPedido = resultado.NroPedido,
                            .Fecha = resultado.Fecha,
                            .FechaCierrePedido = resultado.FechaCierrePedido,
                            .Remitado = resultado.Remitado,
                            .Facturado = resultado.Facturado,
                            .Observaciones = resultado.Observaciones,
                            .Eliminado = resultado.Eliminado,
                            .AscClientes = New ModeloCliente With {.IdCliente = resultado.ascClientes.idCliente},
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = resultado.ascUsuarios.idUsuario}
                       }
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaPedidos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idPedidos
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ModificarFechaCierrePedido() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL FECHA DE CIERRE DEL PEDIDO DE UN REGISTRO ESPECIFICO"

        EjecutarTransaccion("ModificarFechaCierrePedido", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar la fecha de cierre del registro [ID: " + IdPedidos + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
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
                Err.Descripcion = "No se pudo modificar el estado del registro [ID: " + IdPedidos + "] en la tabla " + tabla

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
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el estado del registro [ID: " & IdPedidos & "] en la tabla " + tabla
                End If

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
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el estado del registro [ID: " & IdPedidos & "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloPedidos(objeto As List(Of TablaPedidos)) As List(Of ModeloPedidos)
        Dim pedidos As New List(Of ModeloPedidos)

        For Each item In objeto
            pedidos.Add(New ModeloPedidos With {
                            .IdPedidos = item.idPedidos,
                            .NroPedido = item.NroPedido,
                            .Fecha = item.Fecha,
                            .FechaCierrePedido = item.FechaCierrePedido,
                            .resultado = item.Remitado,
                            .Facturado = item.Facturado,
                            .Observaciones = item.Observaciones,
                            .AscClientes = New ModeloCliente With {
                                .IdCliente = item.ascClientes.idCliente,
                                .RazonSocial = item.ascClientes.RazonSocial
                            },
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario}
                        })
        Next

        Return pedidos
    End Function


    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaPedidos With {
                                                                .NroPedido = NroPedido,
                                                                .Fecha = Fecha,
                                                                .FechaCierrePedido = FechaCierrePedido,
                                                                .Remitado = Remitado,
                                                                .Facturado = Facturado,
                                                                .Observaciones = Observaciones,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascClientes = New TablaClientes With {.idCliente = AscClientes.IdCliente}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaPedidos With {
                                                                .idPedidos = IdPedidos,
                                                                .NroPedido = NroPedido,
                                                                .Fecha = Fecha,
                                                                .FechaCierrePedido = FechaCierrePedido,
                                                                .Remitado = Remitado,
                                                                .Facturado = Facturado,
                                                                .Observaciones = Observaciones,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascClientes = New TablaClientes With {.idCliente = AscClientes.IdCliente}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdPedidos)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ListadoFiltradoPorFacturadoYRemitado"
                    resultado = Me.Transaccion.verRegistrosFacturadoRemitado(Facturado, Remitado)
                Case "ListadoFiltradoPorRemitado"
                    resultado = Me.Transaccion.verRegistrosRemitado(Remitado)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verPedidosPorIDpedido(IdPedidos)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
                Case "ModificarFechaCierrePedido"
                    resultado = Me.Transaccion.modFechaCierrePedido(IdPedidos, FechaCierrePedido)
                Case "ModificarEstado"
                    resultado = Me.Transaccion.modEstado(IdPedidos, Remitado, Facturado)
                Case "ModificarEstadoRemitado"
                    resultado = Me.Transaccion.modEstadoRemitado(IdPedidos, Remitado)
                Case "ModificarEstadoFacturado"
                    resultado = Me.Transaccion.modEstadoFacturado(IdPedidos, Facturado)
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
