Imports MySql.Data.MySqlClient

Public Class TransaccionesDevolucionesMonedas
    Inherits Transacciones
    Implements ITransaccionesDevolucionesMonedas

    Public Function verRegistros() As List(Of TablaDevolucionesMonedas) Implements ITransaccionesGenericas(Of TablaDevolucionesMonedas).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaDevolucionesMonedas) As Integer Implements ITransaccionesGenericas(Of TablaDevolucionesMonedas).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@dmTic", param.TipoCambio),
            New MySqlParameter("@dmImN", param.ImporteNeto),
            New MySqlParameter("@dmDsc", param.DescuentoGral),
            New MySqlParameter("@dmBim", param.BaseImponible),
            New MySqlParameter("@dmIva", param.IVA),
            New MySqlParameter("@dmImT", param.ImporteTotal),
            New MySqlParameter("@dmElim", param.Eliminado),
            New MySqlParameter("@dmIdD", param.ascDevoluciones.idDevoluciones)
        }

        Return ExecuteNonQuery("sigeva.insDevolucionesMonedas")
    End Function

    Public Function modRegistro(param As TablaDevolucionesMonedas) As Integer Implements ITransaccionesGenericas(Of TablaDevolucionesMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDevolucionesMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistroPorIdDevoluciones(id As Integer) As Integer Implements ITransaccionesDevolucionesMonedas.elimRegistroPorIdDevoluciones
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@dmIdD", id)
        }

        Return ExecuteNonQuery("sigeva.elimDevolucionesMonedas_idDevoluciones")
    End Function
End Class
