Imports AccesoDatos

Public Class ModeloFacturaVenta
    Inherits EnlaceTransacciones(Of TransaccionesFacturaVenta)

    Private _idFacturaVenta As Integer
    Private _TipoComprobante As String
    Private _ClaseComprobante As String
    Private _Fecha As Date
    Private _FechaVto As Date
    Private _Prefijo As String
    Private _NroComprobante As String
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _Iva As Double
    Private _ImporteTotal As Double
    Private _Observaciones As String
    Private _Remitado As String
    Private _Eliminado As String
    Private _CAE As String
    Private _FechaVtoCAE As Date
    Private _ascClientes As ModeloCliente
    Private _ascUsuarios As ModeloUsuario
    Private _ascCtaCteVenta As ModeloCuentaCorrienteVenta
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesFacturaVenta(), "FACTURA VENTA")

        Err = New Errores()
        AscClientes = New ModeloCliente()
        ascUsuarios = New ModeloUsuario()
        ascCtaCteVenta = New ModeloCuentaCorrienteVenta()
    End Sub

    Public Sub New(idFacturaVenta As Integer, tipoComprobante As String, claseComprobante As String, fecha As Date, fechaVto As Date,
                   prefijo As String, nroComprobante As String, importeNeto As Double, descuentoGral As Double, baseImponible As Double,
                   iva As Double, importeTotal As Double, observaciones As String, remitado As String, eliminado As String, cae As String, fecvtocae As Date,
                   ascClientes As ModeloCliente, ascUsuarios As ModeloUsuario, ascCtaCteVenta As ModeloCuentaCorrienteVenta, err As Errores)
        MyBase.New(New TransaccionesFacturaVenta(), "FACTURA VENTA")

        Me.IdFacturaVenta = idFacturaVenta
        Me.TipoComprobante = tipoComprobante
        Me.ClaseComprobante = claseComprobante
        Me.Fecha = fecha
        Me.FechaVto = fechaVto
        Me.Prefijo = prefijo
        Me.NroComprobante = nroComprobante
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.Iva = iva
        Me.ImporteTotal = importeTotal
        Me.Observaciones = observaciones
        Me.Remitado = remitado
        Me.Eliminado = eliminado
        Me.CAE = cae
        Me.FechaVtoCAE = fecvtocae
        Me.AscClientes = ascClientes
        Me.AscUsuarios = ascUsuarios
        Me.AscCtaCteVenta = ascCtaCteVenta
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaVenta As Integer
        Get
            Return _idFacturaVenta
        End Get
        Set(value As Integer)
            _idFacturaVenta = value
        End Set
    End Property

    Public Property TipoComprobante As String
        Get
            Return _TipoComprobante
        End Get
        Set(value As String)
            _TipoComprobante = value
        End Set
    End Property

    Public Property ClaseComprobante As String
        Get
            Return _ClaseComprobante
        End Get
        Set(value As String)
            _ClaseComprobante = value
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

    Public Property FechaVto As Date
        Get
            Return _FechaVto
        End Get
        Set(value As Date)
            _FechaVto = value
        End Set
    End Property

    Public Property Prefijo As String
        Get
            Return _Prefijo
        End Get
        Set(value As String)
            _Prefijo = value
        End Set
    End Property

    Public Property NroComprobante As String
        Get
            Return _NroComprobante
        End Get
        Set(value As String)
            _NroComprobante = value
        End Set
    End Property

    Public Property ImporteNeto As Double
        Get
            Return _ImporteNeto
        End Get
        Set(value As Double)
            _ImporteNeto = value
        End Set
    End Property

    Public Property DescuentoGral As Double
        Get
            Return _DescuentoGral
        End Get
        Set(value As Double)
            _DescuentoGral = value
        End Set
    End Property

    Public Property BaseImponible As Double
        Get
            Return _BaseImponible
        End Get
        Set(value As Double)
            _BaseImponible = value
        End Set
    End Property

    Public Property Iva As Double
        Get
            Return _Iva
        End Get
        Set(value As Double)
            _Iva = value
        End Set
    End Property

    Public Property ImporteTotal As Double
        Get
            Return _ImporteTotal
        End Get
        Set(value As Double)
            _ImporteTotal = value
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

    Public Property CAE As String
        Get
            Return _CAE
        End Get
        Set(value As String)
            _CAE = value
        End Set
    End Property

    Public Property FechaVtoCAE As Date
        Get
            Return _FechaVtoCAE
        End Get
        Set(value As Date)
            _FechaVtoCAE = value
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

    Public Property AscUsuarios As ModeloUsuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As ModeloUsuario)
            _ascUsuarios = value
        End Set
    End Property

    Public Property AscCtaCteVenta As ModeloCuentaCorrienteVenta
        Get
            Return _ascCtaCteVenta
        End Get
        Set(value As ModeloCuentaCorrienteVenta)
            _ascCtaCteVenta = value
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
                    Err.Descripcion = "No se pudo modificar el registro [ID: " + IdFacturaVenta + "] en la tabla " + tabla
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
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdFacturaVenta + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloFacturaVenta)
        Dim resultado As New List(Of TablaFacturaVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE FACTURAS VENTA"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloFacturaVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ModificarEstadoRemitado() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL ESTADO DE REMITADO DE UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarEstadoRemitado", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el estado de remitado del registro [ID: " + IdFacturaVenta + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarFacturaVentaCAE() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL CAE Y SU FECHA DE VENCIMIENTO DE UN REGISTRO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarFacturaVentaCAE", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el registro [ID: " + IdFacturaVenta + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoSinRemitar() As List(Of ModeloFacturaVenta)
        Dim resultado As New List(Of TablaFacturaVenta)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO SIN REMITAR DE FACTURAS VENTA"

        EjecutarTransaccion("ListadoSinRemitar", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloFacturaVenta(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaFacturaVenta

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idFacturaVenta
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
    Private Function listModeloFacturaVenta(objeto As List(Of TablaFacturaVenta)) As List(Of ModeloFacturaVenta)
        Dim factura As New List(Of ModeloFacturaVenta)

        For Each item In objeto
            factura.Add(New ModeloFacturaVenta With {
                            .IdFacturaVenta = item.idFacturaVenta,
                            .TipoComprobante = item.TipoComprobante,
                            .ClaseComprobante = item.ClaseComprobante,
                            .Fecha = item.Fecha,
                            .FechaVto = item.FechaVto,
                            .Prefijo = item.Prefijo,
                            .NroComprobante = item.NroComprobante,
                            .ImporteNeto = item.ImporteNeto,
                            .DescuentoGral = item.DescuentoGral,
                            .BaseImponible = item.BaseImponible,
                            .Iva = item.Iva,
                            .ImporteTotal = item.ImporteTotal,
                            .Observaciones = item.Observaciones,
                            .Remitado = item.Remitado,
                            .Eliminado = item.Eliminado,
                            .CAE = item.CAE,
                            .FechaVtoCAE = item.FechaVtoCAE,
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario},
                            .AscCtaCteVenta = New ModeloCuentaCorrienteVenta With {.IdCuentaCorrienteVentas = item.ascCtaCteVenta.idCuentaCorrienteVentas},
                            .AscClientes = New ModeloCliente With {
                                .IdCliente = item.ascClientes.idCliente,
                                .RazonSocial = item.ascClientes.RazonSocial,
                                .Direccion = item.ascClientes.Direccion,
                                .Localidad = item.ascClientes.Localidad,
                                .Provincia = item.ascClientes.Provincia,
                                .CodPostal = item.ascClientes.CodPostal,
                                .Pais = item.ascClientes.Pais,
                                .Telefono = item.ascClientes.Telefono,
                                .Mail = item.ascClientes.Mail,
                                .Web = item.ascClientes.Web,
                                .CUIT = item.ascClientes.CUIT,
                                .IIBB = item.ascClientes.IIBB,
                                .SituacionIVA = item.ascClientes.SituacionIVA,
                                .Estado = item.ascClientes.Estado,
                                .Eliminado = item.ascClientes.Eliminado
                            }
                       })
        Next

        Return factura
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaFacturaVenta With {
                                                                .TipoComprobante = TipoComprobante,
                                                                .ClaseComprobante = ClaseComprobante,
                                                                .Fecha = Fecha,
                                                                .FechaVto = FechaVto,
                                                                .Prefijo = Prefijo,
                                                                .NroComprobante = NroComprobante,
                                                                .ImporteNeto = ImporteNeto,
                                                                .DescuentoGral = DescuentoGral,
                                                                .BaseImponible = BaseImponible,
                                                                .Iva = Iva,
                                                                .ImporteTotal = ImporteTotal,
                                                                .Observaciones = Observaciones,
                                                                .Remitado = Remitado,
                                                                .Eliminado = Eliminado,
                                                                .CAE = CAE,
                                                                .FechaVtoCAE = FechaVtoCAE,
                                                                .ascClientes = New TablaClientes With {.idCliente = AscClientes.IdCliente},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascCtaCteVenta = New TablaCuentaCorrienteVenta With {.idCuentaCorrienteVentas = AscCtaCteVenta.IdCuentaCorrienteVentas}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaFacturaVenta With {
                                                                .idFacturaVenta = IdFacturaVenta,
                                                                .TipoComprobante = TipoComprobante,
                                                                .ClaseComprobante = ClaseComprobante,
                                                                .Fecha = Fecha,
                                                                .FechaVto = FechaVto,
                                                                .Prefijo = Prefijo,
                                                                .NroComprobante = NroComprobante,
                                                                .ImporteNeto = ImporteNeto,
                                                                .DescuentoGral = DescuentoGral,
                                                                .BaseImponible = BaseImponible,
                                                                .Iva = Iva,
                                                                .ImporteTotal = ImporteTotal,
                                                                .Observaciones = Observaciones,
                                                                .Remitado = Remitado,
                                                                .Eliminado = Eliminado,
                                                                .CAE = CAE,
                                                                .FechaVtoCAE = FechaVtoCAE,
                                                                .ascClientes = New TablaClientes With {.idCliente = AscClientes.IdCliente},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascCtaCteVenta = New TablaCuentaCorrienteVenta With {.idCuentaCorrienteVentas = AscCtaCteVenta.IdCuentaCorrienteVentas}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdFacturaVenta)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ListadoSinRemitar"
                    resultado = Me.Transaccion.verFacturasVentaSinRemitar()
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoID()
                Case "ModificarEstadoRemitado"
                    resultado = Me.Transaccion.modEstadoRemitado(IdFacturaVenta, Remitado)
                Case "ModificarFacturaVentaCAE"
                    resultado = Me.Transaccion.modFacturaVentaCAE(IdFacturaVenta, CAE, FechaVtoCAE)
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
