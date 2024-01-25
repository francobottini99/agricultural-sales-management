Imports MySql.Data.MySqlClient

Public Class TransaccionesRegistroOperaciones
    Inherits Transacciones
    Implements ITransaccionesRegistroOperaciones

    Public Function verRegistros() As List(Of TablaRegistroOpreaciones) Implements ITransaccionesGenericas(Of TablaRegistroOpreaciones).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaRegistroOpreaciones) As Integer Implements ITransaccionesGenericas(Of TablaRegistroOpreaciones).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@roFec", param.Fecha))
        parametros.Add(New MySqlParameter("@roHor", param.Hora))
        parametros.Add(New MySqlParameter("@roOpe", param.Operacion))
        parametros.Add(New MySqlParameter("@roDeO", param.DetalleOperacion))
        parametros.Add(New MySqlParameter("@roTbl", param.TablasAfectadas))
        parametros.Add(New MySqlParameter("@roPro", param.ProcedimientoAlmacenado))
        parametros.Add(New MySqlParameter("@roDoc", param.DocumentosEmitidos))
        parametros.Add(New MySqlParameter("@roRep", param.ReportesEmitidos))
        parametros.Add(New MySqlParameter("@roRes", param.ResultadoOperacion))
        parametros.Add(New MySqlParameter("@roDeR", param.DetalleResultado))
        parametros.Add(New MySqlParameter("@roIdU", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insRegistroOperaciones")
    End Function

    Public Function modRegistro(param As TablaRegistroOpreaciones) As Integer Implements ITransaccionesGenericas(Of TablaRegistroOpreaciones).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRegistroOpreaciones).elimRegistro
        Throw New NotImplementedException()
    End Function
End Class
