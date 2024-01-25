Imports Comunicacion

Public Class TareasArticulos
    Inherits EnlaceTransacciones(Of TransaccionesArticulos)

    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        Err = New Errores()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS ACCESO A COMUNICACIONES"
    Public Async Function Servicio_Insertar(_Art As Articulos) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(Drivers.Articulos(_Art))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Servicio_Modificar(_Art As Articulos) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_modRegistro(Drivers.Articulos(_Art))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Eliminar(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.elimRegistro(id)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function ListadoCompleto() As Task(Of List(Of Articulos))
        Try
            Dim list As New List(Of Articulos)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Articulos(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function verImgArt(Id As Integer) As Task(Of String)
        Try
            Return Await Transaccion.verImagenPorId(Id)
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function UltimoID() As Task(Of Integer)
        Try
            Return Await Transaccion.verUltimoId
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function ActualizarCosto(Id As Integer, Cost As Double) As Task(Of Boolean)
        Try
            Await Transaccion.modCostoRegistro(Id, Cost, Date.Now.Date)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function ActualizarPrecio(Id As Integer, precio As Double) As Task(Of Boolean)
        Try
            Await Transaccion.modPrecioRegistro(Id, precio, Date.Now.Date)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function


#End Region

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listArt As List(Of Articulos))
        For Each Item In _listArt
            DGV.Rows.Add(Item.IdArticulo, Item.CodArticulo, Item.Detalle, Item.Unidad, Format(Item.Costo, DatosSesion._MonedaPPal.Simbolo & " ##,#0.00"),
                         Format(CDate(Item.FechaActCosto), "dd/MM/yyyy"), Format(Item.Precio, DatosSesion._MonedaPPal.Simbolo & " ##,#0.00"),
                         Format(CDate(Item.FechaActPrec), "dd/MM/yyyy"), Format(Item.AlicuotaIVA / 100, "#0.## %"),
                         Item.StkMinimo, Item.Observaciones, Item.AscUsuarios.IdUsuario, Item.AscRubro.IdRubro, Item.AscSubRubro.IdSubRubro,
                         Item.AscUsuarios.Nombre, Item.AscRubro.Descripcion, If(Item.AscSubRubro.Descripcion = Item.AscRubro.Descripcion, "-",
                         Item.AscSubRubro.Descripcion))
        Next
    End Sub
#End Region

End Class
