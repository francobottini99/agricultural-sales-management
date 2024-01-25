Imports AccesoDatos

Public Class ModeloFacturaCompraDetalle
    Inherits EnlaceTransacciones(Of TransaccionesFacturaCompraDetalle)

    Private _idFacturaCompraDetalle As Integer
    Private _Descripcion As String
    Private _Unidad As String
    Private _Cantidad As Double
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Remitado As String
    Private _Eliminado As String
    Private _ascArticulos As ModeloArticulos
    Private _ascFacturaCompra As ModeloFacturaCompra
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesFacturaCompraDetalle(), "FACTURA COMPRA DETALLE")

        Err = New Errores()
        AscArticulos = New ModeloArticulos()
        AscFacturaCompra = New ModeloFacturaCompra()
    End Sub

    Public Sub New(idFacturaCompraDetalle As Integer, descripcion As String, unidad As String, cantidad As Double, precio As Double,
                   importe As Double, alicuotaIVA As Double, eliminado As String, ascArticulos As ModeloArticulos,
                   ascFacturaCompra As ModeloFacturaCompra, err As Errores, remitado As String)
        MyBase.New(New TransaccionesFacturaCompraDetalle(), "FACTURA COMPRA DETALLE")

        Me.IdFacturaCompraDetalle = idFacturaCompraDetalle
        Me.Descripcion = descripcion
        Me.Unidad = unidad
        Me.Cantidad = cantidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscFacturaCompra = ascFacturaCompra
        Me.Err = err
        Me.Remitado = remitado
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaCompraDetalle As Integer
        Get
            Return _idFacturaCompraDetalle
        End Get
        Set(value As Integer)
            _idFacturaCompraDetalle = value
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

    Public Property AscFacturaCompra As ModeloFacturaCompra
        Get
            Return _ascFacturaCompra
        End Get
        Set(value As ModeloFacturaCompra)
            _ascFacturaCompra = value
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

    Public Function EliminarPorIdFacturaCompra() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID FACTURA COMPRA"

        EjecutarTransaccion("EliminarPorIdFacturaCompra", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdFacturaCompraDetalle + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoPorIdFacturaCompra() As List(Of ModeloFacturaCompraDetalle)
        Dim resultado As New List(Of TablaFacturaCompraDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE DETALLE FACTURA POR ID FACTURA COMPRA"

        EjecutarTransaccion("ListadoPorIdFacturaCompra", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloFacturaCompraDetalle(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
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
                    Err.Descripcion = "No se pudo modificar el estado de Remitado del registro [ID: " + IdFacturaCompraDetalle + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function


    Public Function ListadoFiltradoPorIdProveedorYRemitado() As List(Of ModeloFacturaCompraDetalle)
        Dim resultado As New List(Of TablaFacturaCompraDetalle)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LISTADO FILTRADO POR UN ID PROVEEDOR Y ESTADO DE REMITACION"

        EjecutarTransaccion("ListadoFiltradoPorIdProveedorYRemitado", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloDetalleFacturaCompra_FacturaCompra(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaFacturaCompraDetalle

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idFacturaCompraDetalle
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
    Private Function listModeloDetalleFacturaCompra_FacturaCompra(objeto As List(Of TablaFacturaCompraDetalle)) As List(Of ModeloFacturaCompraDetalle)
        Dim detalleFactura As New List(Of ModeloFacturaCompraDetalle)

        For Each item In objeto
            detalleFactura.Add(New ModeloFacturaCompraDetalle With {
                                    .IdFacturaCompraDetalle = item.idFacturaCompraDetalle,
                                    .Descripcion = item.Descripcion,
                                    .Cantidad = item.Cantidad,
                                    .Unidad = item.Unidad,
                                    .Precio = item.Precio,
                                    .Importe = item.Importe,
                                    .AlicuotaIVA = item.AlicuotaIVA,
                                    .Remitado = item.Remitado,
                                    .AscArticulos = New ModeloArticulos With {
                                        .IdArticulo = item.ascArticulos.idArticulo,
                                        .CodArticulo = item.ascArticulos.CodArticulo,
                                        .Detalle = item.ascArticulos.Detalle
                                    },
                                    .AscFacturaCompra = New ModeloFacturaCompra With {
                                        .IdFacturaCompra = item.ascFacturaCompra.idFacturaCompra,
                                        .Fecha = item.ascFacturaCompra.Fecha,
                                        .FechaVto = item.ascFacturaCompra.FechaVto,
                                        .Prefijo = item.ascFacturaCompra.Prefijo,
                                        .NroComprobante = item.ascFacturaCompra.NroComprobante,
                                        .ImporteNeto = item.ascFacturaCompra.ImporteNeto,
                                        .DescuentoGral = item.ascFacturaCompra.DescuentoGral,
                                        .BaseImponible = item.ascFacturaCompra.BaseImponible,
                                        .Iva = item.ascFacturaCompra.Iva,
                                        .ImporteTotal = item.ascFacturaCompra.ImporteTotal,
                                        .Observaciones = item.ascFacturaCompra.Observaciones,
                                        .Remitado = item.ascFacturaCompra.Remitado,
                                        .Eliminado = item.ascFacturaCompra.Eliminado,
                                        .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascFacturaCompra.ascUsuarios.idUsuario},
                                        .AscCuentaCorrienteCompra = New ModeloCuentaCorrienteCompra With {.IdCuentaCorrienteCompra = item.ascFacturaCompra.ascCuentaCorrienteCompra.idCuentaCorrienteCompra},
                                        .AscProveedores = New ModeloProveedores With {.IdProveedor = item.ascFacturaCompra.ascProveedores.idProveedor}
                                    }
                              })
        Next

        Return detalleFactura
    End Function

    Private Function listModeloFacturaCompraDetalle(objeto As List(Of TablaFacturaCompraDetalle)) As List(Of ModeloFacturaCompraDetalle)
        Dim detalleFactura As New List(Of ModeloFacturaCompraDetalle)

        For Each item In objeto
            detalleFactura.Add(New ModeloFacturaCompraDetalle With {
                                    .IdFacturaCompraDetalle = item.idFacturaCompraDetalle,
                                    .Descripcion = item.Descripcion,
                                    .Cantidad = item.Cantidad,
                                    .Unidad = item.Unidad,
                                    .Precio = item.Precio,
                                    .Importe = item.Importe,
                                    .AlicuotaIVA = item.AlicuotaIVA,
                                    .Remitado = Remitado,
                                    .AscArticulos = New ModeloArticulos With {
                                        .IdArticulo = item.ascArticulos.idArticulo,
                                        .CodArticulo = item.ascArticulos.CodArticulo,
                                        .Detalle = item.ascArticulos.Detalle
                                    }
                              })
        Next

        Return detalleFactura
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaFacturaCompraDetalle With {
                                                                    .Descripcion = Descripcion,
                                                                    .Cantidad = Cantidad,
                                                                    .Unidad = Unidad,
                                                                    .Precio = Precio,
                                                                    .Importe = Importe,
                                                                    .AlicuotaIVA = AlicuotaIVA,
                                                                    .Remitado = Remitado,
                                                                    .Eliminado = Eliminado,
                                                                    .ascArticulos = New TablaArticulos With {.idArticulo = AscArticulos.IdArticulo},
                                                                    .ascFacturaCompra = New TablaFacturaCompra With {.idFacturaCompra = AscFacturaCompra.IdFacturaCompra}
                                                           })
                Case "ModificarRemitado"
                    resultado = Me.Transaccion.modEstadoRemitado(IdFacturaCompraDetalle, Remitado)
                Case "EliminarPorIdFacturaCompra"
                    resultado = Me.Transaccion.elimRegistroPorIdFacturaCompra(AscFacturaCompra.IdFacturaCompra)
                Case "ListadoFiltradoPorIdProveedorYRemitado"
                    resultado = Me.Transaccion.verRegistroPorIdProveedor_Remitado(AscFacturaCompra.AscProveedores.IdProveedor, Remitado)
                Case "ListadoPorIdFacturaCompra"
                    resultado = Me.Transaccion.verRegistrosPorIdFacturaCompra(AscFacturaCompra.IdFacturaCompra)
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
