Imports AccesoDatos

Public Class ModeloDetalleRemitoCompra
    Inherits EnlaceTransacciones(Of TransaccionesDetalleRemitoCompra)

    Private _idDetalleRemitosCompra As Integer
    Private _Descripcion As String
    Private _Cantidad As Double
    Private _Unidad As String
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Facturado As String
    Private _Eliminado As String
    Private _ascArticulos As ModeloArticulos
    Private _ascRemitosCompra As ModeloRemitosCompra
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDetalleRemitoCompra(), "DETALLE REMITO COMPRA")

        Err = New Errores()
        AscArticulos = New ModeloArticulos()
        AscRemitosCompra = New ModeloRemitosCompra()
    End Sub

    Public Sub New(idDetalleRemitosCompra As Integer, descripcion As String, cantidad As Double, unidad As String, precio As Double,
                   importe As Double, alicuotaIVA As Double, facturado As String, eliminado As String,
                   ascArticulos As ModeloArticulos, ascRemitosCompra As ModeloRemitosCompra, err As Errores)
        MyBase.New(New TransaccionesDetalleRemitoCompra(), "DETALLE REMITO COMPRA")

        Me.IdDetalleRemitosCompra = idDetalleRemitosCompra
        Me.Descripcion = descripcion
        Me.Cantidad = cantidad
        Me.Unidad = unidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Facturado = facturado
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscRemitosCompra = ascRemitosCompra
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDetalleRemitosCompra As Integer
        Get
            Return _idDetalleRemitosCompra
        End Get
        Set(value As Integer)
            _idDetalleRemitosCompra = value
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

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
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

    Public Property Facturado As String
        Get
            Return _Facturado
        End Get
        Set(value As String)
            _Facturado = value
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

    Public Property AscRemitosCompra As ModeloRemitosCompra
        Get
            Return _ascRemitosCompra
        End Get
        Set(value As ModeloRemitosCompra)
            _ascRemitosCompra = value
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
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo insertar el nuevo registro en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarEstadoFacturacion() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE FACTURACION DE UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarEstadoFacturacion", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el estado de facturacion del registro [ID: " + IdDetalleRemitosCompra.ToString() + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdRemitosCompra() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID REMITOS COMPRA"

        EjecutarTransaccion("EliminarPorIdRemitosCompra", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdDetalleRemitosCompra.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdRemitoCompraYIdArticulo() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID REMITOS COMPRA Y SU ID ARTICULO"

        EjecutarTransaccion("EliminarPorIdRemitoCompraYIdArticulo", resultado)

        If Not IsNothing(resultado) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaDetalleRemitoCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idDetalleRemitosCompra
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdRemitosCompra() As List(Of ModeloDetalleRemitoCompra)
        Dim resultado As New List(Of TablaDetalleRemitoCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE DETALLE REMITOS POR ID REMITOS COMPRA"

        EjecutarTransaccion("ListasdoPorIdRemitosCompra", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloDetalleRemitoCompra(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarCantidad() As Double
        Dim resultado As Double

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD DE UN DETALLE REMITO COMPRA POR SU ID"

        EjecutarTransaccion("ConsultarCantidad", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad remitada del registro [ID: " + IdDetalleRemitosCompra.ToString() + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function


    Public Function ListadoFiltradoPorIdProveedorYFacturado() As List(Of ModeloDetalleRemitoCompra)
        Dim resultado As New List(Of TablaDetalleRemitoCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID PROVEEDOR Y ESTADO DE FACTURACION"

        EjecutarTransaccion("ListadoFiltradoPorIdProveedorYFacturado", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloDetalleRemitoCompra)

            For Each item In resultado
                lista.Add(Drivers.DetalleRemitoCompra(item))
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
    Private Function listModeloDetalleRemitoCompra(objeto As List(Of TablaDetalleRemitoCompra)) As List(Of ModeloDetalleRemitoCompra)
        Dim detalleRemito As New List(Of ModeloDetalleRemitoCompra)

        For Each item In objeto
            detalleRemito.Add(New ModeloDetalleRemitoCompra With {
                                    .IdDetalleRemitosCompra = item.idDetalleRemitosCompra,
                                    .Descripcion = item.Descripcion,
                                    .Cantidad = item.Cantidad,
                                    .Unidad = item.Unidad,
                                    .Precio = item.Precio,
                                    .Importe = item.Importe,
                                    .AlicuotaIVA = item.AlicuotaIVA,
                                    .Facturado = item.Facturado,
                                    .AscArticulos = New ModeloArticulos With {
                                        .IdArticulo = item.ascArticulos.idArticulo,
                                        .CodArticulo = item.ascArticulos.CodArticulo
                                    }
                              })
        Next

        Return detalleRemito
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaDetalleRemitoCompra With {
                                                                .Descripcion = Descripcion,
                                                                .Cantidad = Cantidad,
                                                                .Unidad = Unidad,
                                                                .Precio = Precio,
                                                                .Importe = Importe,
                                                                .AlicuotaIVA = AlicuotaIVA,
                                                                .Facturado = Facturado,
                                                                .Eliminado = Eliminado,
                                                                .ascArticulos = New TablaArticulos With {.idArticulo = AscArticulos.IdArticulo},
                                                                .ascRemitosCompra = New TablaRemitosCompra With {.idRemitosCompra = AscRemitosCompra.IdRemitosCompra}
                                                           })
                Case "ModificarEstadoFacturacion"
                    resultado = Me.Transaccion.modEstadoDeFacturacion(IdDetalleRemitosCompra, Facturado)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoID()
                Case "EliminarPorIdRemitosCompra"
                    resultado = Me.Transaccion.elimRegistroPorIdRemitosCompra(AscRemitosCompra.IdRemitosCompra)
                Case "EliminarPorIdRemitoCompraYIdArticulo"
                    resultado = Me.Transaccion.elimDetalleRemCompraPorIDremyPorIDart(AscRemitosCompra.IdRemitosCompra, AscArticulos.IdArticulo)
                Case "ListasdoPorIdRemitosCompra"
                    resultado = Me.Transaccion.verRegistrosPorIdRemtiosCompra(AscRemitosCompra.IdRemitosCompra)
                Case "ListadoFiltradoPorIdProveedorYFacturado"
                    resultado = Me.Transaccion.verRegistroPorIdProveedor_Facturado(AscRemitosCompra.AscProveedores.IdProveedor, Facturado)
                Case "ConsultarCantidad"
                    resultado = Me.Transaccion.verCantidad(IdDetalleRemitosCompra)
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
