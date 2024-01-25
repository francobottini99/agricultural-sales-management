Imports Comunicacion

Public Class TareasChequera
    Inherits EnlaceTransacciones(Of TransaccionesChequera)

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
    Public Async Function Servicio_Insertar(_Chqra As Chequeras) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(Drivers.Chequeras(_Chqra))

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

    Public Async Function Servicio_Modificar(_Chqra As Chequeras) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_modRegistro(Drivers.Chequeras(_Chqra))

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

    Public Async Function Servicio_Eliminar(Id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_elimRegistro(Id)

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

    Public Async Function ListadoCompleto() As Task(Of List(Of Chequeras))
        Try
            Dim list As New List(Of Chequeras)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Chequeras(item))
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

    Public Async Function ListadoSinCompletar() As Task(Of List(Of Chequeras))
        Try
            Dim list As New List(Of Chequeras)

            For Each item In Await Transaccion.verRegistrosSinCompletar()
                list.Add(Drivers.Chequeras(item))
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
#End Region

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listChequera As List(Of Chequeras))
        For Each Item In _listChequera
            DGV.Rows.Add(Item.IdChequera, Item.NroCuenta, Format(Item.FechaAlta, "dd/MM/yyy"), Item.Banco, Item.NroChqInicial, Item.CantidadChq, Item.ChqEmitidos,
                         Item.ChqAnulados, Item.ChqDisponibles, Item.Observaciones, Item.Eliminada, Item.AscUsuarios.IdUsuario)
        Next
    End Sub
#End Region



End Class
