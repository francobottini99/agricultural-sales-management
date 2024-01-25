Imports AccesoDatos

Public Class ModeloMovimientos_Remito_Factura
    Inherits EnlaceTransacciones(Of TransaccionesMovimientos_Remito_Factura)

    Private _idMovimientos_Remito_Factura As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascRemitosVentaMovimientos As ModeloRemitosVentaMovimientos
    Private _ascFacturaVentaMovimientos As ModeloFacturaVentaMovimientos
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesMovimientos_Remito_Factura(), "MOVIMIENTOS REMITO FACTURA")

        AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos()
        AscFacturaVentaMovimientos = New ModeloFacturaVentaMovimientos()
        Err = New Errores()
    End Sub

    Public Sub New(fecha As Date, tipo As String, cantidad As Double, eliminado As String, err As Errores,
                   idMovimientos_Remito_Factura As Integer, ascRemitosVentaMovimientos As ModeloRemitosVentaMovimientos, ascFacturaVentaMovimientos As ModeloFacturaVentaMovimientos)
        MyBase.New(New TransaccionesMovimientos_Remito_Factura(), "MOVIMIENTOS REMITO FACTURA")

        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.Err = err
        Me.IdMovimientos_Remito_Factura = idMovimientos_Remito_Factura
        Me.AscRemitosVentaMovimientos = ascRemitosVentaMovimientos
        Me.AscFacturaVentaMovimientos = ascFacturaVentaMovimientos
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

    Public Property IdMovimientos_Remito_Factura As Integer
        Get
            Return _idMovimientos_Remito_Factura
        End Get
        Set(value As Integer)
            _idMovimientos_Remito_Factura = value
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

    Public Property AscFacturaVentaMovimientos As ModeloFacturaVentaMovimientos
        Get
            Return _ascFacturaVentaMovimientos
        End Get
        Set(value As ModeloFacturaVentaMovimientos)
            _ascFacturaVentaMovimientos = value
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
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdMovimientos_Remito_Factura.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function CantidadRemitada() As Double
        Dim resultado As New TablaMovimientos_Remito_Factura

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD REMITADA DE UN DETALLE FACTURA IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadRemitada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad remitada del registro [ID: " + IdMovimientos_Remito_Factura + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadFacturada() As Double
        Dim resultado As New TablaMovimientos_Remito_Factura

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del registro [ID: " + IdMovimientos_Remito_Factura + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadFacturadaIdFacturaVentaDetalle() As Double
        Dim resultado As New TablaMovimientos_Remito_Factura

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturadaIdFacturaVentaDetalle", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del registro [ID: " + IdMovimientos_Remito_Factura + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdRemitosVenta() As List(Of ModeloMovimientos_Remito_Factura)
        Dim resultado As New List(Of TablaMovimientos_Remito_Factura)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO POR ID REMITOS VENTA"

        EjecutarTransaccion("ListasdoPorIdRemitosVenta", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Movimientos_Remito_Factura(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdRemitosVentaMovimientos() As List(Of ModeloMovimientos_Remito_Factura)
        Dim resultado As New List(Of TablaMovimientos_Remito_Factura)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO POR ID REMITOS VENTA MOVIMIENTOS"

        EjecutarTransaccion("ListasdoPorIdRemitosVentaMovimientos", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Movimientos_Remito_Factura(resultado)
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
                    resultado = Me.Transaccion.insRegistro(Drivers.Movimientos_Remito_Factura(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdMovimientos_Remito_Factura)
                Case "CantidadRemitada"
                    resultado = Me.Transaccion.verCantidadRemitada(AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle)
                Case "CantidadFacturadaIdFacturaVentaDetalle"
                    resultado = Me.Transaccion.verCantidadFacturadaIdDetFac(AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle)
                Case "CantidadFacturada"
                    resultado = Me.Transaccion.verCantidadFacturada(AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta)
                Case "ListasdoPorIdRemitosVenta"
                    resultado = Me.Transaccion.verRegistrosPorIdRemitosVenta(AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscRemitosVenta.IdRemitosVenta)
                Case "ListasdoPorIdRemitosVentaMovimientos"
                    resultado = Me.Transaccion.verRegistrosPorIdRemitosVentaMovimientos(AscRemitosVentaMovimientos.IdRemitosVentasMovimientos)
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
