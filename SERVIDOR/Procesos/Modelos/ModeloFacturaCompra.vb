Imports AccesoDatos

Public Class ModeloFacturaCompra
    Inherits EnlaceTransacciones(Of TransaccionesFacturaCompra)

    Private _idFacturaCompra As Integer
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
    Private _ascUsuarios As ModeloUsuario
    Private _ascProveedores As ModeloProveedores
    Private _ascCuentaCorrienteCompra As ModeloCuentaCorrienteCompra
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesFacturaCompra(), "FACTURA COMPRA")

        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
        ascProveedores = New ModeloProveedores()
        ascCuentaCorrienteCompra = New ModeloCuentaCorrienteCompra()
    End Sub

    Public Sub New(idFacturaCompra As Integer, fecha As Date, fechaVto As Date, prefijo As String, nroComprobante As String, importeNeto As Double,
                   descuentoGral As Double, baseImponible As Double, iva As Double, importeTotal As Double, observaciones As String,
                   eliminado As String, ascUsuarios As ModeloUsuario, ascProveedores As ModeloProveedores, ascCuentaCorrienteCompra As ModeloCuentaCorrienteCompra, err As Errores, remitado As String, tipoComprobante As String, claseComprobante As String)
        MyBase.New(New TransaccionesFacturaCompra(), "FACTURA COMPRA")

        Me.IdFacturaCompra = idFacturaCompra
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
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscProveedores = ascProveedores
        Me.AscCuentaCorrienteCompra = ascCuentaCorrienteCompra
        Me.Err = err
        Me.Remitado = remitado
        Me.TipoComprobante = tipoComprobante
        Me.ClaseComprobante = claseComprobante
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaCompra As Integer
        Get
            Return _idFacturaCompra
        End Get
        Set(value As Integer)
            _idFacturaCompra = value
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

    Public Property AscProveedores As ModeloProveedores
        Get
            Return _ascProveedores
        End Get
        Set(value As ModeloProveedores)
            _ascProveedores = value
        End Set
    End Property

    Public Property AscCuentaCorrienteCompra As ModeloCuentaCorrienteCompra
        Get
            Return _ascCuentaCorrienteCompra
        End Get
        Set(value As ModeloCuentaCorrienteCompra)
            _ascCuentaCorrienteCompra = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdFacturaCompra + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdFacturaCompra + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloFacturaCompra)
        Dim resultado As New List(Of TablaFacturaCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE FACTURAS COMPRA"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloFacturaCompra(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaFacturaCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idFacturaCompra
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloFacturaCompra
        Dim resultado As New TablaFacturaCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO FACTURA COMPRA IDENTIFICADO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloFacturaCompra With {
                            .IdFacturaCompra = resultado.idFacturaCompra,
                            .TipoComprobante = resultado.TipoComprobante,
                            .ClaseComprobante = resultado.ClaseComprobante,
                            .Fecha = resultado.Fecha,
                            .FechaVto = resultado.FechaVto,
                            .Prefijo = resultado.Prefijo,
                            .NroComprobante = resultado.NroComprobante,
                            .ImporteNeto = resultado.ImporteNeto,
                            .DescuentoGral = resultado.DescuentoGral,
                            .BaseImponible = resultado.BaseImponible,
                            .Iva = resultado.Iva,
                            .ImporteTotal = resultado.ImporteTotal,
                            .Observaciones = resultado.Observaciones,
                            .Eliminado = resultado.Eliminado,
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = resultado.ascUsuarios.idUsuario},
                            .AscCuentaCorrienteCompra = New ModeloCuentaCorrienteCompra With {.IdCuentaCorrienteCompra = resultado.ascCuentaCorrienteCompra.idCuentaCorrienteCompra},
                            .AscProveedores = New ModeloProveedores With {
                                .IdProveedor = resultado.ascProveedores.idProveedor,
                                .RazonSocial = resultado.ascProveedores.RazonSocial,
                                .Direccion = resultado.ascProveedores.Direccion,
                                .Localidad = resultado.ascProveedores.Localidad,
                                .Provincia = resultado.ascProveedores.Provincia,
                                .CodPostal = resultado.ascProveedores.CodPostal,
                                .Pais = resultado.ascProveedores.Pais,
                                .Telefono = resultado.ascProveedores.Telefono,
                                .Mail = resultado.ascProveedores.Mail,
                                .Web = resultado.ascProveedores.Web,
                                .CUIT = resultado.ascProveedores.CUIT,
                                .IIBB = resultado.ascProveedores.IIBB,
                                .SituacionIVA = resultado.ascProveedores.SituacionIVA,
                                .Estado = resultado.ascProveedores.Estado,
                                .Eliminado = resultado.ascProveedores.Eliminado
                            }
                       }
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
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
                    Err.Descripcion = "No se pudo modificar el estado de remitado del registro [ID: " + IdFacturaCompra + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloFacturaCompra(objeto As List(Of TablaFacturaCompra)) As List(Of ModeloFacturaCompra)
        Dim factura As New List(Of ModeloFacturaCompra)

        For Each item In objeto
            factura.Add(New ModeloFacturaCompra With {
                            .IdFacturaCompra = item.idFacturaCompra,
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
                            .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario},
                            .AscCuentaCorrienteCompra = New ModeloCuentaCorrienteCompra With {.IdCuentaCorrienteCompra = item.ascCuentaCorrienteCompra.idCuentaCorrienteCompra},
                            .AscProveedores = New ModeloProveedores With {
                                .IdProveedor = item.ascProveedores.idProveedor,
                                .RazonSocial = item.ascProveedores.RazonSocial,
                                .Direccion = item.ascProveedores.Direccion,
                                .Localidad = item.ascProveedores.Localidad,
                                .Provincia = item.ascProveedores.Provincia,
                                .CodPostal = item.ascProveedores.CodPostal,
                                .Pais = item.ascProveedores.Pais,
                                .Telefono = item.ascProveedores.Telefono,
                                .Mail = item.ascProveedores.Mail,
                                .Web = item.ascProveedores.Web,
                                .CUIT = item.ascProveedores.CUIT,
                                .IIBB = item.ascProveedores.IIBB,
                                .SituacionIVA = item.ascProveedores.SituacionIVA,
                                .Estado = item.ascProveedores.Estado,
                                .Eliminado = item.ascProveedores.Eliminado
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
                    resultado = Me.Transaccion.insRegistro(New TablaFacturaCompra With {
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
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascProveedores = New TablaProveedores With {.idProveedor = AscProveedores.IdProveedor},
                                                                .ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra With {.idCuentaCorrienteCompra = AscCuentaCorrienteCompra.IdCuentaCorrienteCompra}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaFacturaCompra With {
                                                                .idFacturaCompra = IdFacturaCompra,
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
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios},
                                                                .ascProveedores = New TablaProveedores With {.idProveedor = AscProveedores.IdProveedor},
                                                                .ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra With {.idCuentaCorrienteCompra = AscCuentaCorrienteCompra.IdCuentaCorrienteCompra}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdFacturaCompra)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdFacturaCompra)
                Case "ModificarEstadoRemitado"
                    resultado = Me.Transaccion.modEstadoRemitado(IdFacturaCompra, Remitado)
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
