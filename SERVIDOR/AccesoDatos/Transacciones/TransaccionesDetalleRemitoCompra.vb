Imports MySql.Data.MySqlClient

Public Class TransaccionesDetalleRemitoCompra
    Inherits Transacciones
    Implements ITransaccionesDetalleRemitoCompra

    Public Function modEstadoDeFacturacion(id As Integer, fac As String) As Integer Implements ITransaccionesDetalleRemitoCompra.modEstadoDeFacturacion
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@drcID", id))
        parametros.Add(New MySqlParameter("@drcFac", fac))

        Return ExecuteNonQuery("sigeva.modDetalleRemitosCompra_Facturado")
    End Function

    Public Function modCantidadFacturada(id As Integer, cant As Double) As Integer Implements ITransaccionesDetalleRemitoCompra.modCantidadFacturada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@drcID", id))
        parametros.Add(New MySqlParameter("@drcCant", cant))

        Return ExecuteNonQuery("sigeva.modDetalleRemitosCompra_CantidadFacturada")
    End Function

    Public Function elimDetalleRemCompraPorIDremyPorIDart(idRC As Integer, idArt As Integer) As Integer Implements ITransaccionesDetalleRemitoCompra.elimDetalleRemCompraPorIDremyPorIDart
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdRc", idRC))
        parametros.Add(New MySqlParameter("@IdArt", idArt))

        Return ExecuteNonQuery("sigeva.elimDetalleRemCompra_IdArticulo_IdRemCompra")
    End Function

    Public Function verUltimoID() As TablaDetalleRemitoCompra Implements ITransaccionesDetalleRemitoCompra.verUltimoID
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdDetalleRemitosCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaDetalleRemitoCompra With {.idDetalleRemitosCompra = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistrosPorIdRemtiosCompra(id As Integer) As List(Of TablaDetalleRemitoCompra) Implements ITransaccionesDetalleRemitoCompra.verRegistrosPorIdRemtiosCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRC", id))

        Return listDetalleRemitoCompra(ExecuteReader("sigeva.verDetalleRemitosCompra_idRC"))
    End Function

    Public Function verCantidad(id As Integer) As Double Implements ITransaccionesDetalleRemitoCompra.verCantidad
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDRC", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verDetalleRemitoCompraCantidad_idDRC")

        If resultTable.Rows.Count > 0 Then
            Return resultTable.Rows(0).Item("Cantidad")
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaDetalleRemitoCompra) Implements ITransaccionesGenericas(Of TablaDetalleRemitoCompra).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaDetalleRemitoCompra) As Integer Implements ITransaccionesGenericas(Of TablaDetalleRemitoCompra).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@drcDes", param.Descripcion))
        parametros.Add(New MySqlParameter("@drcCant", param.Cantidad))
        parametros.Add(New MySqlParameter("@drcUni", param.Unidad))
        parametros.Add(New MySqlParameter("@drcPre", param.Precio))
        parametros.Add(New MySqlParameter("@drcImp", param.Importe))
        parametros.Add(New MySqlParameter("@drcIva", param.AlicuotaIVA))
        parametros.Add(New MySqlParameter("@drcFac", param.Facturado))
        parametros.Add(New MySqlParameter("@drcEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@drcIdA", param.ascArticulos.idArticulo))
        parametros.Add(New MySqlParameter("@drcIdR", param.ascRemitosCompra.idRemitosCompra))

        Return ExecuteNonQuery("sigeva.insDetalleRemitoCompra")
    End Function

    Public Function modRegistro(param As TablaDetalleRemitoCompra) As Integer Implements ITransaccionesGenericas(Of TablaDetalleRemitoCompra).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDetalleRemitoCompra).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistroPorIdRemitosCompra(id As Integer) As Integer Implements ITransaccionesDetalleRemitoCompra.elimRegistroPorIdRemitosCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdDRC", id))

        Return ExecuteNonQuery("sigeva.elimDetalleRemCompra_IdRemCompra")
    End Function

    Public Function verRegistroPorIdProveedor_Facturado(id As Integer, facturado As String) As List(Of TablaDetalleRemitoCompra) Implements ITransaccionesDetalleRemitoCompra.verRegistroPorIdProveedor_Facturado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idProv", id))
        parametros.Add(New MySqlParameter("@fac", facturado))

        Return listDetalleRemitoCompra_RemitoCompra(ExecuteReader("sigeva.verDetalleRemitosCompra_idProveedor_Facturado"))
    End Function

    Private Function listDetalleRemitoCompra(tabla As DataTable) As List(Of TablaDetalleRemitoCompra)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaDetalleRemitoCompra)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaDetalleRemitoCompra With {
                    .idDetalleRemitosCompra = item("idDetalleRemitosCompra"),
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
                    }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function

    Private Function listDetalleRemitoCompra_RemitoCompra(tabla As DataTable) As List(Of TablaDetalleRemitoCompra)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaDetalleRemitoCompra)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaDetalleRemitoCompra With {
                    .idDetalleRemitosCompra = item("idDetalleRemitosCompra"),
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
                    .ascRemitosCompra = New TablaRemitosCompra With {
                        .idRemitosCompra = item("RemitosCompra_idRemitosCompra"),
                        .NroComprobante = item("NroComprobante"),
                        .Fecha = item("Fecha"),
                        .Importe = item("Importe"),
                        .Observaciones = item("Observaciones"),
                        .ImpOriginal = item("ImpOriginal"),
                        .ImpCopia = item("ImpCopia"),
                        .Facturado = item("Facturado"),
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
