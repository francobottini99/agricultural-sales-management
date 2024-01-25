Imports AccesoDatos

Public Class ModeloMovimientos_RemitoCompra_FacturaCompra
    Inherits EnlaceTransacciones(Of TransaccionesMovimientos_RemitoCompra_FacturaCompra)

    Private _idMovimientos_RemitoCompra_FacturaCompra As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascRemitosCompraMovimientos As ModeloRemitosCompraMovimientos
    Private _ascFacturaCompraMovimientos As ModeloFacturaCompraMovimientos
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesMovimientos_RemitoCompra_FacturaCompra(), "MOVIMIENTOS REMITO COMPRA FACTURA COMPRA")

        AscRemitosCompraMovimientos = New ModeloRemitosCompraMovimientos()
        AscFacturaCompraMovimientos = New ModeloFacturaCompraMovimientos()
        Err = New Errores()
    End Sub

    Public Sub New(idMovimientos_RemitoCompra_FacturaCompra As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascRemitosCompraMovimientos As ModeloRemitosCompraMovimientos, ascFacturaCompraMovimientos As ModeloFacturaCompraMovimientos, err As Errores)
        MyBase.New(New TransaccionesMovimientos_RemitoCompra_FacturaCompra(), "MOVIMIENTOS REMITO COMPRA FACTURA COMPRA")

        Me.IdMovimientos_RemitoCompra_FacturaCompra = idMovimientos_RemitoCompra_FacturaCompra
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscRemitosCompraMovimientos = ascRemitosCompraMovimientos
        Me.AscFacturaCompraMovimientos = ascFacturaCompraMovimientos
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMovimientos_RemitoCompra_FacturaCompra As Integer
        Get
            Return _idMovimientos_RemitoCompra_FacturaCompra
        End Get
        Set(value As Integer)
            _idMovimientos_RemitoCompra_FacturaCompra = value
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

    Public Property AscRemitosCompraMovimientos As ModeloRemitosCompraMovimientos
        Get
            Return _ascRemitosCompraMovimientos
        End Get
        Set(value As ModeloRemitosCompraMovimientos)
            _ascRemitosCompraMovimientos = value
        End Set
    End Property

    Public Property AscFacturaCompraMovimientos As ModeloFacturaCompraMovimientos
        Get
            Return _ascFacturaCompraMovimientos
        End Get
        Set(value As ModeloFacturaCompraMovimientos)
            _ascFacturaCompraMovimientos = value
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

    Public Function Eliminar() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"

        EjecutarTransaccion("Eliminar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdMovimientos_RemitoCompra_FacturaCompra.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function CantidadRemitada() As Double
        Dim resultado As New TablaMovimientos_RemitoCompra_FacturaCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD REMITADA DE UN DETALLE FACTURA IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadRemitada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad remitada del registro [ID: " + IdMovimientos_RemitoCompra_FacturaCompra + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function CantidadFacturada() As Double
        Dim resultado As New TablaMovimientos_RemitoCompra_FacturaCompra

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA CANTIDAD FACTURADA DE UN REGISTRO IDENTIFICADO POR SU ID"

        EjecutarTransaccion("CantidadFacturada", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Cantidad
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la cantidad facturada del registro [ID: " + IdMovimientos_RemitoCompra_FacturaCompra + "] de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListasdoPorIdRemitosCompra() As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
        Dim resultado As New List(Of TablaMovimientos_RemitoCompra_FacturaCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO POR ID REMITOS COMPRA"

        EjecutarTransaccion("ListasdoPorIdRemitosCompra", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

            For Each item In resultado
                lista.Add(Drivers.Movimientos_RemitoCompra_FacturaCompra(item))
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

    Public Function ListasdoPorIdFacturaCompra() As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
        Dim resultado As New List(Of TablaMovimientos_RemitoCompra_FacturaCompra)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO POR ID FACTURA COMPRA"

        EjecutarTransaccion("ListasdoPorIdFacturaCompra", resultado)

        If Not IsNothing(resultado) Then
            Dim lista As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

            For Each item In resultado
                lista.Add(Drivers.Movimientos_RemitoCompra_FacturaCompra(item))
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
                    resultado = Me.Transaccion.insRegistro(New TablaMovimientos_RemitoCompra_FacturaCompra With {
                                    .Fecha = Fecha,
                                    .Tipo = Tipo,
                                    .Cantidad = Cantidad,
                                    .Eliminado = Eliminado,
                                    .ascFacturaCompraMovimientos = New TablaFacturaCompraMovimientos With {
                                        .idFacturaCompraMovimientos = AscFacturaCompraMovimientos.IdFacturaCompraMovimientos
                                    },
                                    .ascRemitosCompraMovimientos = New TablaRemitosCompraMovimientos With {
                                        .idRemitosCompraMovimientos = AscRemitosCompraMovimientos.IdRemitosCompraMovimientos
                                    }
                                })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdMovimientos_RemitoCompra_FacturaCompra)
                Case "CantidadRemitada"
                    resultado = Me.Transaccion.verCantidadRemitada(AscFacturaCompraMovimientos.AscFacturaCompraDetalle.IdFacturaCompraDetalle)
                Case "CantidadFacturada"
                    resultado = Me.Transaccion.verCantidadFacturada(AscRemitosCompraMovimientos.AscDetalleRemtioCompra.IdDetalleRemitosCompra)
                Case "ListasdoPorIdRemitosCompra"
                    resultado = Me.Transaccion.verRegistrosPorIdRemitosCompra(AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.IdRemitosCompra)
                Case "ListasdoPorIdFacturaCompra"
                    resultado = Me.Transaccion.verRegistrosPorIdFacturaCompra(AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.IdFacturaCompra)
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
