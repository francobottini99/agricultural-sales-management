Imports AccesoDatos

Public Class ModeloNumeracion
    Inherits EnlaceTransacciones(Of TransaccionesNumeracion)

    Private _idNumeracion As Integer
    Private _PuntoVenta As Integer
    Private _Descripcion As String
    Private _NroReserva As Integer
    Private _NroRemito As Integer
    Private _NroDevolucion As Integer
    Private _NroFacturaA As Integer
    Private _NroFacturaB As Integer
    Private _NroFacturaC As Integer
    Private _NroFacturaX As Integer
    Private _NroNotaCreditoA As Integer
    Private _NroNotaCreditoB As Integer
    Private _NroNotaCreditoC As Integer
    Private _NroNotaCreditoX As Integer
    Private _NroNotaDebitoA As Integer
    Private _NroNotaDebitoB As Integer
    Private _NroNotaDebitoC As Integer
    Private _NroNotaDebitoX As Integer
    Private _NroRecibo As Integer
    Private _NroOrdenCompra As Integer
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesNumeracion(), "NUMERACION")

        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idNumeracion As Integer, puntoVenta As Integer, descripcion As String, nroReserva As Integer, nroRemito As Integer,
                   nroDevolucion As Integer, nroFacturaA As Integer, nroFacturaB As Integer, nroFacturaC As Integer, nroFacturaX As Integer, nroNotaCreditoA As Integer,
                   nroNotaCreditoB As Integer, nroNotaCreditoC As Integer, nroNotaCreditoX As Integer, nroNotaDebitoA As Integer,
                   nroNotaDebitoB As Integer, nroNotaDebitoC As Integer, nroNotaDebitoX As Integer, nroRecibo As Integer,
                   nroOrdenCompra As Integer, eliminado As String, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesNumeracion(), "NUMERACION")

        Me.IdNumeracion = idNumeracion
        Me.PuntoVenta = puntoVenta
        Me.Descripcion = descripcion
        Me.NroReserva = nroReserva
        Me.NroRemito = nroRemito
        Me.NroDevolucion = nroDevolucion
        Me.NroFacturaA = nroFacturaA
        Me.NroFacturaB = nroFacturaB
        Me.NroFacturaC = nroFacturaC
        Me.NroFacturaX = nroFacturaX
        Me.NroNotaCreditoA = nroNotaCreditoA
        Me.NroNotaCreditoB = nroNotaCreditoB
        Me.NroNotaCreditoC = nroNotaCreditoC
        Me.NroNotaCreditoX = nroNotaCreditoX
        Me.NroNotaDebitoA = nroNotaDebitoA
        Me.NroNotaDebitoB = nroNotaDebitoB
        Me.NroNotaDebitoC = nroNotaDebitoC
        Me.NroNotaDebitoX = nroNotaDebitoX
        Me.NroRecibo = nroRecibo
        Me.NroOrdenCompra = nroOrdenCompra
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdNumeracion As Integer
        Get
            Return _idNumeracion
        End Get
        Set(value As Integer)
            _idNumeracion = value
        End Set
    End Property

    Public Property PuntoVenta As Integer
        Get
            Return _PuntoVenta
        End Get
        Set(value As Integer)
            _PuntoVenta = value
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

    Public Property NroReserva As Integer
        Get
            Return _NroReserva
        End Get
        Set(value As Integer)
            _NroReserva = value
        End Set
    End Property

    Public Property NroRemito As Integer
        Get
            Return _NroRemito
        End Get
        Set(value As Integer)
            _NroRemito = value
        End Set
    End Property

    Public Property NroFacturaA As Integer
        Get
            Return _NroFacturaA
        End Get
        Set(value As Integer)
            _NroFacturaA = value
        End Set
    End Property

    Public Property NroFacturaB As Integer
        Get
            Return _NroFacturaB
        End Get
        Set(value As Integer)
            _NroFacturaB = value
        End Set
    End Property

    Public Property NroFacturaC As Integer
        Get
            Return _NroFacturaC
        End Get
        Set(value As Integer)
            _NroFacturaC = value
        End Set
    End Property

    Public Property NroFacturaX As Integer
        Get
            Return _NroFacturaX
        End Get
        Set(value As Integer)
            _NroFacturaX = value
        End Set
    End Property

    Public Property NroNotaCreditoA As Integer
        Get
            Return _NroNotaCreditoA
        End Get
        Set(value As Integer)
            _NroNotaCreditoA = value
        End Set
    End Property

    Public Property NroNotaCreditoB As Integer
        Get
            Return _NroNotaCreditoB
        End Get
        Set(value As Integer)
            _NroNotaCreditoB = value
        End Set
    End Property

    Public Property NroNotaCreditoC As Integer
        Get
            Return _NroNotaCreditoC
        End Get
        Set(value As Integer)
            _NroNotaCreditoC = value
        End Set
    End Property

    Public Property NroNotaCreditoX As Integer
        Get
            Return _NroNotaCreditoX
        End Get
        Set(value As Integer)
            _NroNotaCreditoX = value
        End Set
    End Property

    Public Property NroNotaDebitoA As Integer
        Get
            Return _NroNotaDebitoA
        End Get
        Set(value As Integer)
            _NroNotaDebitoA = value
        End Set
    End Property

    Public Property NroNotaDebitoB As Integer
        Get
            Return _NroNotaDebitoB
        End Get
        Set(value As Integer)
            _NroNotaDebitoB = value
        End Set
    End Property

    Public Property NroNotaDebitoC As Integer
        Get
            Return _NroNotaDebitoC
        End Get
        Set(value As Integer)
            _NroNotaDebitoC = value
        End Set
    End Property

    Public Property NroNotaDebitoX As Integer
        Get
            Return _NroNotaDebitoX
        End Get
        Set(value As Integer)
            _NroNotaDebitoX = value
        End Set
    End Property

    Public Property NroRecibo As Integer
        Get
            Return _NroRecibo
        End Get
        Set(value As Integer)
            _NroRecibo = value
        End Set
    End Property

    Public Property NroOrdenCompra As Integer
        Get
            Return _NroOrdenCompra
        End Get
        Set(value As Integer)
            _NroOrdenCompra = value
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

    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property

    Public Property NroDevolucion As Integer
        Get
            Return _NroDevolucion
        End Get
        Set(value As Integer)
            _NroDevolucion = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdNumeracion.ToString() + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloNumeracion)
        Dim resultado As New List(Of TablaNumeracion)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE NUMERACION"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Numeracion(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdNumeracion.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarNroRemito() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE REMITO DE LA TABLA NUMERACION"

        EjecutarTransaccion("ModificarNroRemito", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar numero de remito en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarNroFacturaA() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE FACTURA A DE LA TABLA NUMERACION"

        EjecutarTransaccion("ModificarNroFacturaA", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar numero de Factura A en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarNroFacturaB() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE FACTURA B DE LA TABLA NUMERACION"

        EjecutarTransaccion("ModificarNroFacturaB", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar numero de Factura B en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarNroReserva() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE RESERVA DE LA TABLA NUMERACION"

        EjecutarTransaccion("ModificarNroReserva", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar numero de reserva en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarNroOrdenDeCompra() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE ORDEN DE COMPRA DE LA TABLA NUMERACION"

        EjecutarTransaccion("ModificarNroOrdenDeCompra", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar numero de orden de compra en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarNroRecibo() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE RECIBO DE LA TABLA NUMERACION"

        EjecutarTransaccion("ModificarNroRecibo", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar numero de orden de compra en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarNroDevolucion() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL NUMERO DE DEVOLUCION DE LA TABLA NUMERACION"

        EjecutarTransaccion("ModificarNroDevolucion", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar numero de orden de compra en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.Numeracion(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.Numeracion(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdNumeracion)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ModificarNroRemito"
                    resultado = Me.Transaccion.modNroRemito(IdNumeracion, NroRemito)
                Case "ModificarNroReserva"
                    resultado = Me.Transaccion.modNroReserva(IdNumeracion, NroReserva)
                Case "ModificarNroFacturaA"
                    resultado = Me.Transaccion.modNroFacturaA(IdNumeracion, NroFacturaA)
                Case "ModificarNroFacturaB"
                    resultado = Me.Transaccion.modNroFacturaB(IdNumeracion, NroFacturaB)
                Case "ModificarNroOrdenDeCompra"
                    resultado = Me.Transaccion.modNroOrdenDeCompra(IdNumeracion, NroOrdenCompra)
                Case "ModificarNroRecibo"
                    resultado = Me.Transaccion.modNroRecibo(IdNumeracion, NroRecibo)
                Case "ModificarNroDevolucion"
                    resultado = Me.Transaccion.modNroDevolucion(IdNumeracion, NroRecibo)
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
