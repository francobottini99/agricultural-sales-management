Imports MySql.Data.MySqlClient

Public Class TransaccionesDetalleDevoluciones
    Inherits Transacciones
    Implements ITransaccionesDetalleDevoluciones

    Public Function verRegistros() As List(Of TablaDetalleDevoluciones) Implements ITransaccionesGenericas(Of TablaDetalleDevoluciones).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaDetalleDevoluciones) As Integer Implements ITransaccionesGenericas(Of TablaDetalleDevoluciones).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@ddDes", param.Descripcion),
            New MySqlParameter("@ddCant", param.Cantidad),
            New MySqlParameter("@ddUni", param.Unidad),
            New MySqlParameter("@ddPre", param.Precio),
            New MySqlParameter("@ddImp", param.Importe),
            New MySqlParameter("@ddIva", param.AlicuotaIVA),
            New MySqlParameter("@ddEli", param.Eliminado),
            New MySqlParameter("@ddIdA", param.ascArticulos.idArticulo),
            New MySqlParameter("@ddIdDR", param.ascDetalleRemitoVenta.idDetalleRemitosVenta),
            New MySqlParameter("@ddIdD", param.ascDevoluciones.idDevoluciones)
        }

        Return ExecuteNonQuery("sigeva.insDetalleDevoluciones")
    End Function

    Public Function modRegistro(param As TablaDetalleDevoluciones) As Integer Implements ITransaccionesGenericas(Of TablaDetalleDevoluciones).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDetalleDevoluciones).elimRegistro
        Throw New NotImplementedException()
    End Function
End Class
