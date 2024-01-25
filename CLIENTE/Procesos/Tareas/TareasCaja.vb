Imports Comunicacion

Public Class TareasCaja
    Inherits EnlaceTransacciones(Of TransaccionesCaja)

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
    Public Async Function Insertar(_Caja As Caja) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.Caja(_Caja))

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

    Public Async Function Modificar(_Caja As Caja) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.Caja(_Caja))

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

    Public Async Function ListadoCompleto() As Task(Of List(Of Caja))
        Try
            Dim list As New List(Of Caja)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Caja(item))
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

    Public Async Function ListadoPorFechas(fecDesde As Date, fecHasta As Date) As Task(Of List(Of Caja))
        Try
            Dim list As New List(Of Caja)

            For Each item In Await Transaccion.verCajaPorFechas(fecDesde, fecHasta)
                list.Add(Drivers.Caja(item))
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

    Public Async Function MaxFecha() As Task(Of Date)
        Try
            Return Await Transaccion.verMaxFecha()
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

    Public Async Function MinFecha() As Task(Of Date)
        Try
            Return Await Transaccion.verMinFecha()
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
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listCaja As List(Of Caja))
        For Each Item In _listCaja
            Dim ingreso As String = ""
            Dim egreso As String = ""

            If Item.Moneda = "DOLAR" Then
                ingreso = Format(UtilidadesVarias.SoloNumeros(Item.Ingreso), "U$S #,##0.00")
                egreso = Format(UtilidadesVarias.SoloNumeros(Item.Egreso), "U$S #,##0.00")
            ElseIf Item.Moneda = "PESO" Then
                ingreso = Format(UtilidadesVarias.SoloNumeros(Item.Ingreso), "$ #,##0.00")
                egreso = Format(UtilidadesVarias.SoloNumeros(Item.Egreso), "$ #,##0.00")
            End If

            DGV.Rows.Add(Item.IdCaja, Format(Item.Fecha, "dd/MM/yyyy"), Item.Movimiento, Item.Comprobante, Item.Descripcion,
                         Item.Moneda, ingreso, egreso, Item.Observaciones, Item.Eliminado, Item.AscUsuarios.IdUsuario)
        Next
    End Sub
#End Region
End Class
