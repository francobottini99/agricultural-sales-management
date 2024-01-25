Imports AccesoDatos

Public Class ModeloStock
    Inherits EnlaceTransacciones(Of TransaccionesStock)

    Private _idStock As Integer
    Private _Fecha As Date
    Private _Movimiento As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascArticulos As ModeloArticulos
    Private _ascDepositos As ModeloDepositos
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesStock(), "STOCK")

        AscArticulos = New ModeloArticulos()
        AscDepositos = New ModeloDepositos()
        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idStock As Integer, fecha As Date, movimiento As String, cantidad As Double, eliminado As String, ascArticulos As ModeloArticulos,
                   ascDepositos As ModeloDepositos, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesStock(), "STOCK")

        Me.IdStock = idStock
        Me.Fecha = fecha
        Me.Movimiento = movimiento
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscDepositos = ascDepositos
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdStock As Integer
        Get
            Return _idStock
        End Get
        Set(value As Integer)
            _idStock = value
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

    Public Property Movimiento As String
        Get
            Return _Movimiento
        End Get
        Set(value As String)
            _Movimiento = value
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

    Public Property AscDepositos As ModeloDepositos
        Get
            Return _ascDepositos
        End Get
        Set(value As ModeloDepositos)
            _ascDepositos = value
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
                    Err.Descripcion = "No se pudo modificar el registro [ID: " + IdStock + "] en la tabla " + tabla
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
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdStock.ToString() + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorCampos() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR UN REGISTRO IDENTIFICADO POR EL VALOR DE SUS CAMPOS"

        EjecutarTransaccion("EliminarPorCampos", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro identificado por sus campos de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoStockPorIdArticulo() As List(Of ModeloStock)
        Dim resultado As New List(Of TablaStock)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE STOCK FILTRADO POR ID DE ARTICULO"

        EjecutarTransaccion("ListadoStockPorIdArticulo", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloStock(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de stcok del articulo [ID: " + AscArticulos.IdArticulo + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadStockReservadoPorIdArticulo() As Double
        Dim resultado As New TablaStock

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD DE STOCK RESERVADO DE UN ARTICULO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadStockReservadoPorIdArticulo", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad de stock reservado del articulo [ID: " + AscArticulos.IdArticulo + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadStockFisicoPorIdArticulo() As Double
        Dim resultado As New TablaStock

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD DE STOCK FISICO DE UN ARTICULO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadStockFisicoPorIdArticulo", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad de stock fisico del articulo [ID: " + AscArticulos.IdArticulo + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadStockFisicoPorIdArticuloYIdDeposito() As Double
        Dim resultado As New TablaStock

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD DE STOCK FISICO DE UN ARTICULO IDENTIFICADO POR SU ID EN UN DEPOSITO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadStockFisicoPorIdArticuloYIdDeposito", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad de stock fisico del articulo [ID: " + AscArticulos.IdArticulo + "] en el deposito [ID: " + AscDepositos.IdDeposito + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaStock

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idStock
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
    Private Function listModeloStock(objeto As List(Of TablaStock)) As List(Of ModeloStock)
        Dim stock As New List(Of ModeloStock)

        For Each item In objeto
            stock.Add(New ModeloStock With {
                            .IdStock = item.idStock,
                            .Fecha = item.Fecha,
                            .Movimiento = item.Movimiento,
                            .Cantidad = item.Cantidad,
                            .AscArticulos = New ModeloArticulos With {.IdArticulo = item.ascArticulos.idArticulo},
                            .AscDepositos = New ModeloDepositos With {.IdDeposito = item.ascDepositos.idDeposito},
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario}
                      })
        Next

        Return stock
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaStock With {
                                                                .Fecha = Fecha,
                                                                .Movimiento = Movimiento,
                                                                .Cantidad = Cantidad,
                                                                .Eliminado = Eliminado,
                                                                .ascArticulos = New TablaArticulos With {.idArticulo = AscArticulos.IdArticulo},
                                                                .ascDepositos = New TablaDepositos With {.idDeposito = AscDepositos.IdDeposito},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                          })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaStock With {
                                                                .idStock = IdStock,
                                                                .Fecha = Fecha,
                                                                .Movimiento = Movimiento,
                                                                .Cantidad = Cantidad,
                                                                .Eliminado = Eliminado,
                                                                .ascArticulos = New TablaArticulos With {.idArticulo = AscArticulos.IdArticulo},
                                                                .ascDepositos = New TablaDepositos With {.idDeposito = AscDepositos.IdDeposito},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                          })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdStock)
                Case "EliminarPorCampos"
                    resultado = Me.Transaccion.elimRegistroPorCampos(New TablaStock With {
                                                                            .Fecha = Fecha,
                                                                            .Movimiento = Movimiento,
                                                                            .Cantidad = Cantidad,
                                                                            .ascArticulos = New TablaArticulos With {.idArticulo = AscArticulos.IdArticulo},
                                                                            .ascDepositos = New TablaDepositos With {.idDeposito = AscDepositos.IdDeposito}
                                                                     })
                Case "ListadoStockPorIdArticulo"
                    resultado = Me.Transaccion.verStockPorIdArticulo(AscArticulos.IdArticulo)
                Case "CantidadStockReservadoPorIdArticulo"
                    resultado = Me.Transaccion.verStockReservado(AscArticulos.IdArticulo)
                Case "CantidadStockFisicoPorIdArticulo"
                    resultado = Me.Transaccion.verStockFisico(AscArticulos.IdArticulo)
                Case "CantidadStockFisicoPorIdArticuloYIdDeposito"
                    resultado = Me.Transaccion.verStockFisico(AscArticulos.IdArticulo, AscDepositos.IdDeposito)
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
