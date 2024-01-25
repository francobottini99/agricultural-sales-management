Imports AccesoDatos

Public Class ModeloFacturaCompraMovimientos
    Inherits EnlaceTransacciones(Of TransaccionesFacturaCompraMovimientos)

    Private _idFacturaCompraMovimientos As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _ascFacturaCompraDetalle As ModeloFacturaCompraDetalle
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesFacturaCompraMovimientos(), "FACTURA COMPRA MOVIMIENTOS")

        AscUsuarios = New ModeloUsuario()
        AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle()
        Err = New Errores()
    End Sub

    Public Sub New(idFacturaCompraMovimientos As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascUsuarios As ModeloUsuario, ascFacturaCompraDetalle As ModeloFacturaCompraDetalle, err As Errores)
        MyBase.New(New TransaccionesFacturaCompraMovimientos(), "FACTURA COMPRA MOVIMIENTOS")

        Me.IdFacturaCompraMovimientos = idFacturaCompraMovimientos
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscFacturaCompraDetalle = ascFacturaCompraDetalle
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaCompraMovimientos As Integer
        Get
            Return _idFacturaCompraMovimientos
        End Get
        Set(value As Integer)
            _idFacturaCompraMovimientos = value
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

    Public Property AscFacturaCompraDetalle As ModeloFacturaCompraDetalle
        Get
            Return _ascFacturaCompraDetalle
        End Get
        Set(value As ModeloFacturaCompraDetalle)
            _ascFacturaCompraDetalle = value
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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdFacturaCompraMovimientos.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaFacturaCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idFacturaCompraMovimientos
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadFacturada() As Double
        Dim resultado As New TablaFacturaCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del registro [ID: " + IdFacturaCompraMovimientos + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadAnulada() As Double
        Dim resultado As New TablaFacturaCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD ANULADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadAnulada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad anulada del registro [ID: " + IdFacturaCompraMovimientos + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadRemitada() As Double
        Dim resultado As New TablaFacturaCompraMovimientos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD REMITADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadRemitada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad remitada del registro [ID: " + IdFacturaCompraMovimientos + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdFacturaCompra() As List(Of ModeloFacturaCompraMovimientos)
        Dim resultado As New List(Of TablaFacturaCompraMovimientos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE MOVIMIENTOS FACTURA COMPRA POR ID FACTURA COMPRA"

        EjecutarTransaccion("ListasdoPorIdFacturaCompra", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloFacturaCompraMovimientos)

            For Each item In resultado
                lista.Add(Drivers.FacturaCompraMovimientos(item))
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
                    resultado = Me.Transaccion.insRegistro(New TablaFacturaCompraMovimientos With {
                                                                .Fecha = Fecha,
                                                                .Tipo = Tipo,
                                                                .Cantidad = Cantidad,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascFacturaCompraDetalle = New TablaFacturaCompraDetalle With {.idFacturaCompraDetalle = AscFacturaCompraDetalle.IdFacturaCompraDetalle}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdFacturaCompraMovimientos)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
                Case "CantidadFacturada"
                    resultado = Me.Transaccion.verCantidadFacturada(AscFacturaCompraDetalle.IdFacturaCompraDetalle)
                Case "CantidadAnulada"
                    resultado = Me.Transaccion.verCantidadAnulada(AscFacturaCompraDetalle.IdFacturaCompraDetalle)
                Case "CantidadRemitada"
                    resultado = Me.Transaccion.verCantidadRemitada(AscFacturaCompraDetalle.IdFacturaCompraDetalle)
                Case "ListasdoPorIdFacturaCompra"
                    resultado = Me.Transaccion.verRegistrosPorIdFacturaCompra(AscFacturaCompraDetalle.AscFacturaCompra.IdFacturaCompra)
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
