Imports Comunicacion

Public Class TareasValoresEnCartera
    Inherits EnlaceTransacciones(Of TransaccionesValoresEnCartera)

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
    Public Async Function Insertar(_VeC As ValoresEnCartera) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.ValoreEnCartera(_VeC))

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

    Public Async Function Modificar(_VeC As ValoresEnCartera) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.ValoreEnCartera(_VeC))

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

    Public Async Function ListadoCompleto() As Task(Of List(Of ValoresEnCartera))
        Try
            Dim list As New List(Of ValoresEnCartera)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.ValoreEnCartera(item))
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

    Public Async Function ListadoDisponible() As Task(Of List(Of ValoresEnCartera))
        Try
            Dim list As New List(Of ValoresEnCartera)

            For Each item In Await Transaccion.verListadoDisponible("SI")
                list.Add(Drivers.ValoreEnCartera(item))
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

    Public Async Function ListadoNoDisponible() As Task(Of List(Of ValoresEnCartera))
        Try
            Dim list As New List(Of ValoresEnCartera)

            For Each item In Await Transaccion.verListadoDisponible("NO")
                list.Add(Drivers.ValoreEnCartera(item))
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

    Public Async Function SaldoPesos() As Task(Of Double)
        Try
            Return Await Transaccion.verSaldoPesos()
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

    Public Async Function SaldoDolares() As Task(Of Double)
        Try
            Return Await Transaccion.verSaldoDolares()
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
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listValores As List(Of ValoresEnCartera))
        For Each Item In _listValores
            Dim importe As String = ""

            If Item.Moneda = "DOLAR" Then
                importe = Format(UtilidadesVarias.SoloNumeros(Item.Importe), "U$S #,##0.00")
            ElseIf Item.Moneda = "PESO" Then
                importe = Format(UtilidadesVarias.SoloNumeros(Item.Importe), "$ #,##0.00")
            End If

            DGV.Rows.Add(Item.IdValoresEnCartera, Item.TipoValor, Item.Banco, Item.Sucursal, Item.Numero, Item.Librador,
                         Format(Item.FechaCobro, "dd/MM/yyyy"), Item.Moneda, importe, Item.Disponible, Item.Eliminado, Item.AscUsuarios.IdUsuario)
        Next
    End Sub
#End Region
End Class
