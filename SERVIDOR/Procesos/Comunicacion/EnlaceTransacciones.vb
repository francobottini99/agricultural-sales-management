Imports AccesoDatos

Public MustInherit Class EnlaceTransacciones(Of Entidad As Transacciones)
    Protected Property Transaccion As Entidad
    Protected Shared Property Operaciones As List(Of ModeloRegistroOperaciones)

    Protected ReadOnly tabla As String
    Protected operacion As String
    Protected detalle As String
    Protected detalleOperacion As String
    Protected resultado As String
    Protected detalleResultado As String
    Protected documentosEmitidos As String
    Protected reportesEmitidos As String
    Protected idUs As Integer

    Public Sub New(_rep As Entidad, tabla As String)
        If IsNothing(Operaciones) Then
            Operaciones = New List(Of ModeloRegistroOperaciones)
        End If

        Me.tabla = tabla
        valoresPorDefecto()
        Transaccion = _rep
    End Sub

#Region "METODOS PUBLICOS"
    Public Sub BeginTransaction()
        Transaccion.BeginTransaction()
    End Sub

    Public Sub Rollback()
        Transaccion.Rollback()
        RegistrarOperaciones()
    End Sub

    Public Sub Commit()
        Transaccion.Commit()
        RegistrarOperaciones()
    End Sub
#End Region

#Region "METODOS PROTEGIDOS"
    Protected Sub AñadirOperacion()
        If operacion = "ELIMINAR" Then
            If detalleOperacion = "-" Then
                detalleOperacion = "ELIMINAR UN REGISTRO"
            End If
        ElseIf operacion = "INSERTAR" Then
            If detalleOperacion = "-" Then
                detalleOperacion = "INSERTAR UN NUEVO REGISTRO"
            End If
        ElseIf operacion = "MODIFICAR" Then
            If detalleOperacion = "-" Then
                detalleOperacion = "MODIFICAR UN REGISTRO EXISTENTE"
            End If
        ElseIf operacion = "CONSULTAR" Then
            If detalleOperacion = "-" Then
                detalleOperacion = "CONSULTAR TODOS LOS REGISTROS"
            End If
        ElseIf operacion = "RECUPERAR" Then
            If detalleOperacion = "-" Then
                detalleOperacion = "RESTAURAR UN REGISTRO ELIMINADO"
            End If
        End If

        If detalleResultado = "-" And resultado = "-" Then
            resultado = "COMPLETADO"
        ElseIf detalleResultado <> "-" And resultado = "-" Then
            resultado = "ERROR"
        End If

        Operaciones.Add(New ModeloRegistroOperaciones With {
                    .Fecha = Date.Now.Date,
                    .Hora = DateTime.Now,
                    .Operacion = operacion,
                    .TablasAfectadas = tabla,
                    .ProcedimientoAlmacenado = Transaccion.ProcedimientoAlmacenado,
                    .DetalleOperacion = detalleOperacion,
                    .ResultadoOperacion = resultado,
                    .DetalleResultado = detalleResultado,
                    .DocumentosEmitidos = documentosEmitidos,
                    .ReportesEmitidos = reportesEmitidos,
                    .AscUsuarios = New ModeloUsuario With {.IdUsuarios = idUs}
                })

        valoresPorDefecto()
        RegistrarOperaciones()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub valoresPorDefecto()
        detalle = "-"
        detalleOperacion = "-"
        resultado = "-"
        detalleResultado = "-"
        documentosEmitidos = "-"
        reportesEmitidos = "-"
        idUs = 1
    End Sub

    Private Sub RegistrarOperaciones()
        If Not Transacciones.enTransaccion Then
            For Each item In Operaciones
                item.Insertar()
            Next

            Operaciones.Clear()
        End If
    End Sub
#End Region
End Class
