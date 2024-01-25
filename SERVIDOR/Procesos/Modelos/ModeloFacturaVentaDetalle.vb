Imports AccesoDatos

Public Class ModeloFacturaVentaDetalle
    Inherits EnlaceTransacciones(Of TransaccionesFacturaVentaDetalle)

    Private _idFacturaVentaDetalle As Integer
    Private _Descripcion As String
    Private _Unidad As String
    Private _Cantidad As Double
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Remitado As String
    Private _Eliminado As String
    Private _ascFacturaVenta As ModeloFacturaVenta
    Private _ascArticulos As ModeloArticulos
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesFacturaVentaDetalle(), "FACTURA VENTA DETALLES")

        Err = New Errores()
        AscFacturaVenta = New ModeloFacturaVenta()
        AscArticulos = New ModeloArticulos()
    End Sub

    Public Sub New(idFacturaVentaDetalle As Integer, descripcion As String, unidad As String, cantidad As Double, precio As Double,
                   importe As Double, alicuotaIVA As Double, remitado As String, eliminado As String,
                   ascFacturaVenta As ModeloFacturaVenta, ascArticulos As ModeloArticulos, err As Errores)
        MyBase.New(New TransaccionesFacturaVentaDetalle(), "FACTURA VENTA DETALLES")

        Me.IdFacturaVentaDetalle = idFacturaVentaDetalle
        Me.Descripcion = descripcion
        Me.Unidad = unidad
        Me.Cantidad = cantidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Remitado = remitado
        Me.Eliminado = eliminado
        Me.AscFacturaVenta = ascFacturaVenta
        Me.AscArticulos = ascArticulos
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaVentaDetalle As Integer
        Get
            Return _idFacturaVentaDetalle
        End Get
        Set(value As Integer)
            _idFacturaVentaDetalle = value
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

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
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

    Public Property Remitado As String
        Get
            Return _Remitado
        End Get
        Set(value As String)
            _Remitado = value
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

    Public Property AscFacturaVenta As ModeloFacturaVenta
        Get
            Return _ascFacturaVenta
        End Get
        Set(value As ModeloFacturaVenta)
            _ascFacturaVenta = value
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

    Public Function ModificarRemitado() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE REMITADO DE UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarRemitado", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el estado de Remitado del registro [ID: " + IdFacturaVentaDetalle + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdFacturaVenta() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID FACTURA VENTA"

        EjecutarTransaccion("EliminarPorIdFacturaVenta", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdFacturaVentaDetalle + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoPorIdFacturaVenta() As List(Of ModeloFacturaVentaDetalle)
        Dim resultado As New List(Of TablaFacturaVentaDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE DETALLE FACTURA POR ID FACTURA VENTA"

        EjecutarTransaccion("ListadoPorIdFacturaVenta", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.FacturaVentaDetalle(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoFiltradoPorIdClienteYRemitado() As List(Of ModeloFacturaVentaDetalle)
        Dim resultado As New List(Of TablaFacturaVentaDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID CLIENTE Y ESTADO DE REMITACION"

        EjecutarTransaccion("ListadoFiltradoPorIdClienteYRemitado", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.FacturaVentaDetalle(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadFacturada() As Double
        Dim resultado As New TablaFacturaVentaDetalle

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURADA DETALLE FACTURA IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del detalle factura [ID: " + AscFacturaVenta.IdFacturaVenta + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaFacturaVentaDetalle

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idFacturaVentaDetalle
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoFiltradoPorIdCliente() As List(Of ModeloFacturaVentaDetalle)
        Dim resultado As New List(Of TablaFacturaVentaDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID CLIENTE"

        EjecutarTransaccion("ListadoFiltradoPorIdCliente", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.FacturaVentaDetalle(resultado)
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
                    resultado = Me.Transaccion.insRegistro(Drivers.FacturaVentaDetalle(Me))
                Case "EliminarPorIdFacturaVenta"
                    resultado = Me.Transaccion.elimRegistroPorIdFacturaVenta(AscFacturaVenta.IdFacturaVenta)
                Case "ListadoPorIdFacturaVenta"
                    resultado = Me.Transaccion.verDetalleFacturaVentaPorIdFacturaVenta(AscFacturaVenta.IdFacturaVenta)
                Case "ListadoFiltradoPorIdClienteYRemitado"
                    resultado = Me.Transaccion.verRegistroPorIdCliente_Remitado(AscFacturaVenta.AscClientes.IdCliente, Remitado)
                Case "ModificarRemitado"
                    resultado = Me.Transaccion.modEstadoRemitado(IdFacturaVentaDetalle, Remitado)
                Case "CantidadFacturada"
                    resultado = Me.Transaccion.verCantidadFacturada(IdFacturaVentaDetalle)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
                Case "ListadoFiltradoPorIdCliente"
                    resultado = Me.Transaccion.verRegistroPorIdCliente(AscFacturaVenta.AscClientes.IdCliente)
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
