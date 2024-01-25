Imports MySql.Data.MySqlClient

Public Class TransaccionesDetalleRemitoVenta
    Inherits Transacciones
    Implements ITransaccionesDetalleRemitoVenta

    Public Function elimRegistroPorIdRemitosVenta(id As Integer) As Integer Implements ITransaccionesDetalleRemitoVenta.elimRegistroPorIdRemitosVenta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@IdDRV", id)
        }

        Return ExecuteNonQuery("sigeva.elimDetalleRemVenta_IdRemVenta")
    End Function

    Public Function elimRegistroPorIdRemitosVentaYIdArticulo(idRem As Integer, idArt As Integer) As Integer Implements ITransaccionesDetalleRemitoVenta.elimRegistroPorIdRemitosVentaYIdArticulo
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@IdRc", idRem),
            New MySqlParameter("@IdArt", idArt)
        }

        Return ExecuteNonQuery("sigeva.elimDetalleRemVenta_IdArticulo_IdRemVenta")
    End Function

    Public Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaDetalleRemitoVenta) Implements ITransaccionesDetalleRemitoVenta.verRegistrosPorIdRemitosVenta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idRV", id)
        }

        Return listDetalleRemitoVenta(ExecuteReader("sigeva.verDetalleRemitosVenta_idRV"))
    End Function

    Public Function verUltimoId() As TablaDetalleRemitoVenta Implements ITransaccionesDetalleRemitoVenta.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdDetalleRemitosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaDetalleRemitoVenta With {.idDetalleRemitosVenta = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function modEstadoFacturacion(id As Integer, EstFac As String) As Integer Implements ITransaccionesDetalleRemitoVenta.modEstadoFacturacion
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@drcID", id),
            New MySqlParameter("@drcFac", EstFac)
        }

        Return ExecuteNonQuery("sigeva.modDetalleRemitosVenta_Facturado")
    End Function

    Public Function verRegistros() As List(Of TablaDetalleRemitoVenta) Implements ITransaccionesGenericas(Of TablaDetalleRemitoVenta).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function verRegistroPorIdCliente_Facturado(id As Integer, facturado As String) As List(Of TablaDetalleRemitoVenta) Implements ITransaccionesDetalleRemitoVenta.verRegistroPorIdCliente_Facturado
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idCli", id),
            New MySqlParameter("@fac", facturado)
        }

        Return listDetalleRemitoVenta_RemitoVenta(ExecuteReader("sigeva.verDetalleRemitosVenta_idCliente_Facturado"))
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaDetalleRemitoVenta Implements ITransaccionesDetalleRemitoVenta.verRegistroPorId
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDr", id)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.verDetalleRemitosVenta_idDetalleRemitosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaDetalleRemitoVenta With {
                    .idDetalleRemitosVenta = resultTable.Rows(0).Item("idDetalleRemitosVenta"),
                    .Descripcion = resultTable.Rows(0).Item("Descripcion"),
                    .Cantidad = resultTable.Rows(0).Item("Cantidad"),
                    .Unidad = resultTable.Rows(0).Item("Unidad"),
                    .Precio = resultTable.Rows(0).Item("Precio"),
                    .Importe = resultTable.Rows(0).Item("Importe"),
                    .AlicuotaIVA = resultTable.Rows(0).Item("AlicuotaIVA"),
                    .Facturado = resultTable.Rows(0).Item("Facturado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = resultTable.Rows(0).Item("Articulos_idArticulos"),
                        .CodArticulo = resultTable.Rows(0).Item("CodArticulo"),
                        .Detalle = resultTable.Rows(0).Item("Detalle"),
                        .Unidad = resultTable.Rows(0).Item("Unidad")
                    },
                    .ascRemitosVenta = New TablaRemitosVenta With {
                        .idRemitosVenta = resultTable.Rows(0).Item("RemitosVenta_idRemitosVenta")
                    }
                }
        Else
            Return Nothing
        End If
    End Function

    Public Function insRegistro(param As TablaDetalleRemitoVenta) As Integer Implements ITransaccionesGenericas(Of TablaDetalleRemitoVenta).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@drcDes", param.Descripcion),
            New MySqlParameter("@drcCant", param.Cantidad),
            New MySqlParameter("@drcUni", param.Unidad),
            New MySqlParameter("@drcPre", param.Precio),
            New MySqlParameter("@drcImp", param.Importe),
            New MySqlParameter("@drcIva", param.AlicuotaIVA),
            New MySqlParameter("@drcFac", param.Facturado),
            New MySqlParameter("@drcEli", param.Eliminado),
            New MySqlParameter("@drcIdA", param.ascArticulos.idArticulo),
            New MySqlParameter("@drcIdR", param.ascRemitosVenta.idRemitosVenta)
        }

        Return ExecuteNonQuery("sigeva.insDetalleRemitoVenta")
    End Function

    Public Function modRegistro(param As TablaDetalleRemitoVenta) As Integer Implements ITransaccionesGenericas(Of TablaDetalleRemitoVenta).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDetalleRemitoVenta).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function verRegistroPorIdCliente(id As Integer) As List(Of TablaDetalleRemitoVenta) Implements ITransaccionesDetalleRemitoVenta.verRegistroPorIdCliente
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idCli", id)
        }

        Return listDetalleRemitoVenta_RemitoVenta(ExecuteReader("sigeva.verDetalleRemitosVenta_idCliente"))
    End Function

    Private Function listDetalleRemitoVenta(tabla As DataTable) As List(Of TablaDetalleRemitoVenta)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaDetalleRemitoVenta)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaDetalleRemitoVenta With {
                    .idDetalleRemitosVenta = item("idDetalleRemitosVenta"),
                    .Descripcion = item("Descripcion"),
                    .Cantidad = item("Cantidad"),
                    .Unidad = item("Unidad"),
                    .Precio = item("Precio"),
                    .Importe = item("Importe"),
                    .AlicuotaIVA = item("AlicuotaIVA"),
                    .Facturado = item("Facturado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = item("Articulos_idArticulos"),
                        .CodArticulo = item("CodArticulo")
                    },
                    .ascRemitosVenta = New TablaRemitosVenta With {
                        .idRemitosVenta = item("RemitosVenta_idRemitosVenta")
                    }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function

    Private Function listDetalleRemitoVenta_RemitoVenta(tabla As DataTable) As List(Of TablaDetalleRemitoVenta)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaDetalleRemitoVenta)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaDetalleRemitoVenta With {
                    .idDetalleRemitosVenta = item("idDetalleRemitosVenta"),
                    .Descripcion = item("Descripcion"),
                    .Cantidad = item("Cantidad"),
                    .Unidad = item("Unidad"),
                    .Precio = item("Precio"),
                    .Importe = item("Importe"),
                    .AlicuotaIVA = item("AlicuotaIVA"),
                    .Facturado = item("Facturado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = item("Articulos_idArticulos"),
                        .CodArticulo = item("CodArticulo"),
                        .Detalle = item("Detalle")
                    },
                    .ascRemitosVenta = New TablaRemitosVenta With {
                        .idRemitosVenta = item("RemitosVenta_idRemitosVenta"),
                        .NroComprobante = item("NroComprobante"),
                        .Fecha = item("Fecha"),
                        .Importe = item("Importe"),
                        .Observaciones = item("Observaciones"),
                        .ImpOriginal = item("ImpOriginal"),
                        .ImpCopia = item("ImpCopia"),
                        .Facturado = item("Facturado"),
                        .CAE = item("CAE"),
                        .FechaVtoCAE = item("FechaVtaCAE"),
                        .ascUsuarios = New TablaUsuarios With {
                            .idUsuario = item("Usuarios_idUsuarios")
                        }
                    }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function
End Class
