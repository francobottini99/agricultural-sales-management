Imports AccesoDatos

Public Class ModeloRemitosCompra
    Inherits EnlaceTransacciones(Of TransaccionesRemitosCompra)

    Private _idRemitosCompra As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _Importe As Double
    Private _Observaciones As String
    Private _ImpOriginal As Integer
    Private _ImpCopia As Integer
    Private _Eliminado As String
    Private _Facturado As String
    Private _ascProveedores As ModeloProveedores
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRemitosCompra(), "REMITOS COMPRA")

        Err = New Errores()
        AscProveedores = New ModeloProveedores()
        ascUsuarios = New ModeloUsuario()
    End Sub

    Public Sub New(idRemitosCompra As Integer, nroComprobante As String, fecha As Date, importe As Double, observaciones As String,
                   impOriginal As Integer, impCopia As Integer, eliminado As String, facturado As String, ascProveedores As ModeloProveedores,
                   ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesRemitosCompra(), "REMITOS COMPRA")

        Me.IdRemitosCompra = idRemitosCompra
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.Importe = importe
        Me.Observaciones = observaciones
        Me.ImpOriginal = impOriginal
        Me.ImpCopia = impCopia
        Me.Eliminado = eliminado
        Me.Facturado = facturado
        Me.AscProveedores = ascProveedores
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRemitosCompra As Integer
        Get
            Return _idRemitosCompra
        End Get
        Set(value As Integer)
            _idRemitosCompra = value
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

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
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

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property

    Public Property ImpOriginal As Integer
        Get
            Return _ImpOriginal
        End Get
        Set(value As Integer)
            _ImpOriginal = value
        End Set
    End Property

    Public Property ImpCopia As Integer
        Get
            Return _ImpCopia
        End Get
        Set(value As Integer)
            _ImpCopia = value
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

    Public Property Facturado As String
        Get
            Return _Facturado
        End Get
        Set(value As String)
            _Facturado = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdRemitosCompra + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRemitosCompra + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloRemitosCompra)
        Dim resultado As New List(Of TablaRemitosCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE REMITOS COMPRA"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloRemitosCompra(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloRemitosCompra
        Dim resultado As New TablaRemitosCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO REMITOS COMPRA IDENTIFICADO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloRemitosCompra With {
                            .IdRemitosCompra = resultado.idRemitosCompra,
                            .NroComprobante = resultado.NroComprobante,
                            .Fecha = resultado.Fecha,
                            .Importe = resultado.Importe,
                            .Observaciones = resultado.Observaciones,
                            .ImpOriginal = resultado.ImpOriginal,
                            .ImpCopia = resultado.ImpCopia,
                            .Facturado = resultado.Facturado,
                            .AscProveedores = New ModeloProveedores With {
                                .IdProveedor = resultado.ascProveedores.idProveedor,
                                .RazonSocial = resultado.ascProveedores.RazonSocial
                            },
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
                Err.Descripcion = "No se pudo modificar el estado de facturacion del registro [ID: " + IdRemitosCompra + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoSinFacturar() As List(Of ModeloRemitosCompra)
        Dim resultado As New List(Of TablaRemitosCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE REMITOS SIN FACTURAR"

        EjecutarTransaccion("ListadoSinFacturar", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloRemitosCompra(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de remitos sin facturar de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaRemitosCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idRemitosCompra
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
    Private Function listModeloRemitosCompra(objeto As List(Of TablaRemitosCompra)) As List(Of ModeloRemitosCompra)
        Dim remito As New List(Of ModeloRemitosCompra)

        For Each item In objeto
            remito.Add(New ModeloRemitosCompra With {
                            .IdRemitosCompra = item.idRemitosCompra,
                            .NroComprobante = item.NroComprobante,
                            .Fecha = item.Fecha,
                            .Importe = item.Importe,
                            .Observaciones = item.Observaciones,
                            .ImpOriginal = item.ImpOriginal,
                            .ImpCopia = item.ImpCopia,
                            .Facturado = item.Facturado,
                            .AscProveedores = New ModeloProveedores With {
                                .IdProveedor = item.ascProveedores.idProveedor,
                                .RazonSocial = item.ascProveedores.RazonSocial,
                                .Direccion = item.ascProveedores.Direccion,
                                .Localidad = item.ascProveedores.Localidad,
                                .Provincia = item.ascProveedores.Provincia,
                                .CodPostal = item.ascProveedores.CodPostal,
                                .Telefono = item.ascProveedores.Telefono,
                                .Mail = item.ascProveedores.Mail,
                                .Web = item.ascProveedores.Web,
                                .CUIT = item.ascProveedores.CUIT,
                                .IIBB = item.ascProveedores.IIBB,
                                .Estado = item.ascProveedores.Estado
                            },
                            .AscUsuarios = New ModeloUsuario With {
                                .IdUsuarios = item.ascUsuarios.idUsuario,
                                .Nombre = item.ascUsuarios.Nombre
                            }
                       })
        Next

        Return remito
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaRemitosCompra With {
                                                                .NroComprobante = NroComprobante,
                                                                .Fecha = Fecha,
                                                                .Importe = Importe,
                                                                .Observaciones = Observaciones,
                                                                .ImpOriginal = ImpOriginal,
                                                                .ImpCopia = ImpCopia,
                                                                .Eliminado = Eliminado,
                                                                .Facturado = Facturado,
                                                                .ascProveedores = New TablaProveedores With {.idProveedor = AscProveedores.IdProveedor},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaRemitosCompra With {
                                                                .idRemitosCompra = IdRemitosCompra,
                                                                .NroComprobante = NroComprobante,
                                                                .Fecha = Fecha,
                                                                .Importe = Importe,
                                                                .Observaciones = Observaciones,
                                                                .ImpOriginal = ImpOriginal,
                                                                .ImpCopia = ImpCopia,
                                                                .Eliminado = Eliminado,
                                                                .Facturado = Facturado,
                                                                .ascProveedores = New TablaProveedores With {.idProveedor = AscProveedores.IdProveedor},
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdRemitosCompra)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdRemitosCompra)
                Case "ModificarEstadoFacturacion"
                    resultado = Me.Transaccion.modEstadoFacturacion(IdRemitosCompra, Facturado)
                Case "ListadoSinFacturar"
                    resultado = Me.Transaccion.verSinFacturar()
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
