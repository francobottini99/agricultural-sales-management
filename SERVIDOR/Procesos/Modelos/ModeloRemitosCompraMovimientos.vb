Imports AccesoDatos
Public Class ModeloRemitosCompraMovimientos
    Inherits EnlaceTransacciones(Of TransaccionesRemitosCompraMovimientos)

    Private _idRemitosCompraMovimientos As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _ascDetalleRemtioCompra As ModeloDetalleRemitoCompra
    Private _ascStock As ModeloStock
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRemitosCompraMovimientos(), "REMITOS COMPRA MOVIMIENTOS")

        AscUsuarios = New ModeloUsuario()
        AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra()
        AscStock = New ModeloStock()
        Err = New Errores()
    End Sub

    Public Sub New(idRemitosCompraMovimientos As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
               ascUsuarios As ModeloUsuario, ascDetalleRemtioCompra As ModeloDetalleRemitoCompra, ascStock As ModeloStock, err As Errores)
        MyBase.New(New TransaccionesRemitosCompraMovimientos(), "REMITOS COMPRA MOVIMIENTOS")

        Me.IdRemitosCompraMovimientos = idRemitosCompraMovimientos
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscDetalleRemtioCompra = ascDetalleRemtioCompra
        Me.AscStock = ascStock
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRemitosCompraMovimientos As Integer
        Get
            Return _idRemitosCompraMovimientos
        End Get
        Set(value As Integer)
            _idRemitosCompraMovimientos = value
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

    Public Property AscUsuarios As ModeloUsuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As ModeloUsuario)
            _ascUsuarios = value
        End Set
    End Property

    Public Property AscDetalleRemtioCompra As ModeloDetalleRemitoCompra
        Get
            Return _ascDetalleRemtioCompra
        End Get
        Set(value As ModeloDetalleRemitoCompra)
            _ascDetalleRemtioCompra = value
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

    Public Function Eliminar() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"

        EjecutarTransaccion("Eliminar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRemitosCompraMovimientos.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListasdoPorIdRemitosCompra() As List(Of ModeloRemitosCompraMovimientos)
        Dim resultado As New List(Of TablaRemitosCompraMovimientos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE MOVIMIENTOS REMITO COMPRA POR ID REMITOS COMPRA"

        EjecutarTransaccion("ListasdoPorIdRemitosCompra", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloRemitosCompraMovimientos)

            For Each item In resultado
                lista.Add(Drivers.RemitosCompraMovimientos(item))
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

    Public Function UltimoId() As Integer
        Dim resultado As New TablaRemitosCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idRemitosCompraMovimientos
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadRemitada() As Double
        Dim resultado As New TablaRemitosCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD REMITADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadRemitada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad remitada del registro [ID: " + IdRemitosCompraMovimientos + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadDevuelta() As Double
        Dim resultado As New TablaRemitosCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD DEVUELTA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadDevuelta", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad devuelta del registro [ID: " + IdRemitosCompraMovimientos + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadFacturada() As Double
        Dim resultado As New TablaRemitosCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del registro [ID: " + IdRemitosCompraMovimientos + "] de la tabla " + tabla
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
                    resultado = Me.Transaccion.insRegistro(New TablaRemitosCompraMovimientos With {
                                                                .Fecha = Fecha,
                                                                .Tipo = Tipo,
                                                                .Cantidad = Cantidad,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascDetalleRemtioCompra = New TablaDetalleRemitoCompra With {.idDetalleRemitosCompra = AscDetalleRemtioCompra.IdDetalleRemitosCompra},
                                                                .ascStock = New TablaStock With {.idStock = AscStock.IdStock}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdRemitosCompraMovimientos)
                Case "ListasdoPorIdRemitosCompra"
                    resultado = Me.Transaccion.verRegistrosPorIdRemitosCompra(AscDetalleRemtioCompra.AscRemitosCompra.IdRemitosCompra)
                Case "CantidadRemitada"
                    resultado = Me.Transaccion.verCantidadRemitada(AscDetalleRemtioCompra.IdDetalleRemitosCompra)
                Case "CantidadDevuelta"
                    resultado = Me.Transaccion.verCantidadDevuelta(AscDetalleRemtioCompra.IdDetalleRemitosCompra)
                Case "CantidadFacturada"
                    resultado = Me.Transaccion.verCantidadFacturada(AscDetalleRemtioCompra.IdDetalleRemitosCompra)
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
