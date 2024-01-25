Imports System.IO
Imports MySql.Data.MySqlClient

Public Class TransaccionesArticulos
    Inherits Transacciones
    Implements ITransaccionesArticulos

    Public Function verRegistrosSinImagenes() As List(Of TablaArticulos) Implements ITransaccionesArticulos.verRegistrosSinImagenes
        Return listArticulos(ExecuteReader("sigeva.verArtiuclosSinImagenes"))
    End Function

    Public Function verImagenPorId(id As Integer) As TablaArticulos Implements ITransaccionesArticulos.verImagenPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdArt", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verArticulo_idArticulo")

        If resultTable.Rows.Count > 0 Then
            Dim img As Byte() = resultTable.Rows(0).Item("Imagen")

            Return New TablaArticulos With {.Imagen = Convert.ToBase64String(New MemoryStream(img).ToArray())}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaArticulos Implements ITransaccionesArticulos.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdArt", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verArticulo_idArticulo")

        If resultTable.Rows.Count > 0 Then
            Dim img As Byte() = resultTable.Rows(0).Item("Imagen")

            Return New TablaArticulos With {
                    .idArticulo = resultTable.Rows(0).Item("idArticulos"),
                    .CodArticulo = resultTable.Rows(0).Item("CodArticulo"),
                    .Detalle = resultTable.Rows(0).Item("Detalle"),
                    .Unidad = resultTable.Rows(0).Item("Unidad"),
                    .Costo = resultTable.Rows(0).Item("Costo"),
                    .FechaActCosto = resultTable.Rows(0).Item("FechaActualizacionCosto"),
                    .Precio = resultTable.Rows(0).Item("Precio"),
                    .FechaActPrec = resultTable.Rows(0).Item("FechaActualizacionPrecio"),
                    .AlicuotaIVA = resultTable.Rows(0).Item("AlicuotaIVA"),
                    .StkMinimo = resultTable.Rows(0).Item("StockMinimo"),
                    .Observaciones = resultTable.Rows(0).Item("Observaciones"),
                    .ascUsuarios = New TablaUsuarios With {
                        .idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios"),
                        .Nombre = resultTable.Rows(0).Item("Nombre")
                    },
                    .ascRubro = New TablaRubro With {
                        .idRubro = resultTable.Rows(0).Item("Rubro_idRubro"),
                        .Descripcion = resultTable.Rows(0).Item("RubDescripcion"),
                        .Abrebiatura = resultTable.Rows(0).Item("RubroAbreviatura")
                    },
                    .ascSubRubro = New TablaSubRubro With {
                        .idSubRubro = resultTable.Rows(0).Item("SubRubro_idSubRubro"),
                        .Descripcion = resultTable.Rows(0).Item("SubRubDescripcion"),
                        .Abrebiatura = resultTable.Rows(0).Item("SubRubAbreviatura")
                    },
                    .Imagen = Convert.ToBase64String(New MemoryStream(img).ToArray())
                }
        Else
            Return Nothing
        End If
    End Function

    Public Function verUltimoId() As TablaArticulos Implements ITransaccionesArticulos.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdArticulos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaArticulos With {.idArticulo = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function modCostoRegistro(id As Integer, cost As Double, fec As Date) As Integer Implements ITransaccionesArticulos.modCostoRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idAr", id))
        parametros.Add(New MySqlParameter("@aCosto", cost))
        parametros.Add(New MySqlParameter("@aFechaActualizacionCosto", fec))

        Return ExecuteNonQuery("sigeva.actArticulo_Costo")
    End Function

    Public Function modPrecioRegistro(id As Integer, precio As Double, fec As Date) As Integer Implements ITransaccionesArticulos.modPrecioRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idAr", id))
        parametros.Add(New MySqlParameter("@aPrecio", precio))
        parametros.Add(New MySqlParameter("@aFechaActualizacionPrecio", fec))

        Return ExecuteNonQuery("sigeva.actArticulo_Precio")
    End Function

    Public Function verRegistros() As List(Of TablaArticulos) Implements ITransaccionesGenericas(Of TablaArticulos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaArticulos) As Integer Implements ITransaccionesGenericas(Of TablaArticulos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@aCdArt", param.CodArticulo))
        parametros.Add(New MySqlParameter("@aDetalle", param.Detalle))
        parametros.Add(New MySqlParameter("@aUnidad", param.Unidad))
        parametros.Add(New MySqlParameter("@aCosto", param.Costo))
        parametros.Add(New MySqlParameter("@aFechaActualizacionCosto", param.FechaActCosto))
        parametros.Add(New MySqlParameter("@aPrecio", param.Precio))
        parametros.Add(New MySqlParameter("@aFechaActualizacionPrecio", param.FechaActPrec))
        parametros.Add(New MySqlParameter("@aAlicuotaIVA", param.AlicuotaIVA))
        parametros.Add(New MySqlParameter("@aStockMinimo", param.StkMinimo))
        parametros.Add(New MySqlParameter("@aObservaciones", param.Observaciones))
        parametros.Add(New MySqlParameter("@aImagen", New MemoryStream(Convert.FromBase64String(param.Imagen)).ToArray()))
        parametros.Add(New MySqlParameter("@aidUsuarios", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@aidRubro", param.ascRubro.idRubro))
        parametros.Add(New MySqlParameter("@aidSubRubro", param.ascSubRubro.idSubRubro))

        Return ExecuteNonQuery("sigeva.insArticulo")
    End Function

    Public Function modRegistro(param As TablaArticulos) As Integer Implements ITransaccionesGenericas(Of TablaArticulos).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idAr", param.idArticulo))
        parametros.Add(New MySqlParameter("@aCdArt", param.CodArticulo))
        parametros.Add(New MySqlParameter("@aDetalle", param.Detalle))
        parametros.Add(New MySqlParameter("@aUnidad", param.Unidad))
        parametros.Add(New MySqlParameter("@aCosto", param.Costo))
        parametros.Add(New MySqlParameter("@aFechaActualizacionCosto", param.FechaActCosto))
        parametros.Add(New MySqlParameter("@aPrecio", param.Precio))
        parametros.Add(New MySqlParameter("@aFechaActualizacionPrecio", param.FechaActPrec))
        parametros.Add(New MySqlParameter("@aAlicuotaIVA", param.AlicuotaIVA))
        parametros.Add(New MySqlParameter("@aStockMinimo", param.StkMinimo))
        parametros.Add(New MySqlParameter("@aObservaciones", param.Observaciones))
        parametros.Add(New MySqlParameter("@aImagen", New MemoryStream(Convert.FromBase64String(param.Imagen)).ToArray()))
        parametros.Add(New MySqlParameter("@aidUsuarios", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@aidRubro", param.ascRubro.idRubro))
        parametros.Add(New MySqlParameter("@aidSubRubro", param.ascSubRubro.idSubRubro))

        Return ExecuteNonQuery("sigeva.modArticulo")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaArticulos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdArt", id))

        Return ExecuteNonQuery("sigeva.elimArticulo")
    End Function

    Private Function listArticulos(tabla As DataTable) As List(Of TablaArticulos)
        If tabla.Rows.Count > 0 Then
            Dim articulos As New List(Of TablaArticulos)

            For Each item As DataRow In tabla.Rows
                articulos.Add(New TablaArticulos With {
                    .idArticulo = item("idArticulos"),
                    .CodArticulo = item("CodArticulo"),
                    .Detalle = item("Detalle"),
                    .Unidad = item("Unidad"),
                    .Costo = item("Costo"),
                    .FechaActCosto = item("FechaActualizacionCosto"),
                    .Precio = item("Precio"),
                    .FechaActPrec = item("FechaActualizacionPrecio"),
                    .AlicuotaIVA = item("AlicuotaIVA"),
                    .StkMinimo = item("StockMinimo"),
                    .Observaciones = item("Observaciones"),
                    .ascUsuarios = New TablaUsuarios With {
                        .idUsuario = item("Usuarios_idUsuarios"),
                        .Nombre = item("Nombre")
                    },
                    .ascRubro = New TablaRubro With {
                        .idRubro = item("Rubro_idRubro"),
                        .Descripcion = item("RubDescripcion"),
                        .Abrebiatura = item("RubroAbreviatura")
                    },
                    .ascSubRubro = New TablaSubRubro With {
                        .idSubRubro = item("SubRubro_idSubRubro"),
                        .Descripcion = item("SubRubDescripcion"),
                        .Abrebiatura = item("SubRubAbreviatura")
                    }
                })
            Next

            Return articulos
        Else
            Return Nothing
        End If
    End Function
End Class
