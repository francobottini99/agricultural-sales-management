Imports AccesoDatos

Public Class ModeloArticulos
    Inherits EnlaceTransacciones(Of TransaccionesArticulos)

    Private _idArticulo As Integer
    Private _CodArticulo As String
    Private _Detalle As String
    Private _Unidad As String
    Private _Costo As Double
    Private _FechaActCosto As Date
    Private _Precio As Double
    Private _FechaActPrec As Date
    Private _AlicuotaIVA As Double
    Private _StkMinimo As Double
    Private _Observaciones As String
    Private _Imagen As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _ascRubro As ModeloRubro
    Private _ascSubRubro As ModeloSubRubro
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesArticulos(), "ARTICULOS")

        AscUsuarios = New ModeloUsuario()
        AscRubro = New ModeloRubro()
        AscSubRubro = New ModeloSubRubro()
        Err = New Errores()
    End Sub

    Public Sub New(idArticulo As Integer, codArticulo As String, detalle As String, unidad As String, costo As Double, fechaActCosto As Date,
                   precio As Double, fechaActPrec As Date, alicuotaIVA As Double, stkMinimo As Double, observaciones As String, imagen As String,
                   eliminado As String, ascUsuarios As ModeloUsuario, ascRubro As ModeloRubro, ascSubRubro As ModeloSubRubro, err As Errores)
        MyBase.New(New TransaccionesArticulos(), "ARTICULOS")

        Me.IdArticulo = idArticulo
        Me.CodArticulo = codArticulo
        Me.Detalle = detalle
        Me.Unidad = unidad
        Me.Costo = costo
        Me.FechaActCosto = fechaActCosto
        Me.Precio = precio
        Me.FechaActPrec = fechaActPrec
        Me.AlicuotaIVA = alicuotaIVA
        Me.StkMinimo = stkMinimo
        Me.Observaciones = observaciones
        Me.Imagen = imagen
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscRubro = ascRubro
        Me.AscSubRubro = ascSubRubro
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdArticulo As Integer
        Get
            Return _idArticulo
        End Get
        Set(value As Integer)
            _idArticulo = value
        End Set
    End Property

    Public Property CodArticulo As String
        Get
            Return _CodArticulo
        End Get
        Set(value As String)
            _CodArticulo = value
        End Set
    End Property

    Public Shadows Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
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

    Public Property Costo As Double
        Get
            Return _Costo
        End Get
        Set(value As Double)
            _Costo = value
        End Set
    End Property

    Public Property FechaActCosto As Date
        Get
            Return _FechaActCosto
        End Get
        Set(value As Date)
            _FechaActCosto = value
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

    Public Property FechaActPrec As Date
        Get
            Return _FechaActPrec
        End Get
        Set(value As Date)
            _FechaActPrec = value
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

    Public Property StkMinimo As Double
        Get
            Return _StkMinimo
        End Get
        Set(value As Double)
            _StkMinimo = value
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

    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
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

    Public Property AscRubro As ModeloRubro
        Get
            Return _ascRubro
        End Get
        Set(value As ModeloRubro)
            _ascRubro = value
        End Set
    End Property

    Public Property AscSubRubro As ModeloSubRubro
        Get
            Return _ascSubRubro
        End Get
        Set(value As ModeloSubRubro)
            _ascSubRubro = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdArticulo.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdArticulo.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarCosto() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL COSTO DE UN ARTICULO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarCosto", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el costo del registro [ID: " + IdArticulo.ToString() + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarPrecio() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA EL PRECIO DE UN ARTICULO ESPECIFICADO POR SU ID"

        EjecutarTransaccion("ModificarPrecio", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el precio del registro [ID: " + IdArticulo.ToString() + "] en la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaArticulos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idArticulo
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoSinImagenes() As List(Of ModeloArticulos)
        Dim resultado As New List(Of TablaArticulos)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE ARTICULOS SIN CARGAR IMAGENES"

        EjecutarTransaccion("ListadoSinImagenes", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Articulos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloArticulos
        Dim resultado As New TablaArticulos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR UN ARTICULO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Articulos(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarImagenPorId() As String
        Dim resultado As New TablaArticulos

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR LA IMAGEN DE UN ARTICULO POR SU ID"

        EjecutarTransaccion("ConsultarImagenPorId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.Imagen
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener la imagen del registro de la tabla " + tabla
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
                    resultado = Me.Transaccion.insRegistro(Drivers.Articulos(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.Articulos(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdArticulo)
                Case "ModificarCosto"
                    resultado = Me.Transaccion.modCostoRegistro(IdArticulo, Costo, FechaActCosto)
                Case "ModificarPrecio"
                    resultado = Me.Transaccion.modPrecioRegistro(IdArticulo, Precio, FechaActPrec)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdArticulo)
                Case "ConsultarImagenPorId"
                    resultado = Me.Transaccion.verImagenPorId(IdArticulo)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
                Case "ListadoSinImagenes"
                    resultado = Me.Transaccion.verRegistrosSinImagenes()
                Case Else
                    Err.Identificador = EnumErrores.TRANSACCION_DESCONOCIDA
                    Err.Descripcion = "La transaccion """ + transaccion + """ no se encuentra en el servidor"

                    resultado = Nothing
            End Select
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Err.Identificador = EnumErrores.ERROR_MYSQL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace + " | " + ex.StackTrace

            resultado = Nothing
        Catch ex As Exception
            Err.Identificador = EnumErrores.ERROR_GENERAL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace + " | " + ex.StackTrace

            resultado = Nothing
        Finally
            detalleResultado = Err.Descripcion

            AñadirOperacion()
        End Try
    End Sub
#End Region
End Class
