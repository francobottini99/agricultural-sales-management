Imports MySql.Data.MySqlClient

Public Class TransaccionesNumeracion
    Inherits Transacciones
    Implements ITransaccionesNumeracion

    Public Function modNroReserva(id As Integer, Nro As Integer) As Integer Implements ITransaccionesNumeracion.modNroReserva
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", id),
            New MySqlParameter("@nNro", Nro)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion_NroReserva")
    End Function

    Public Function modNroRemito(id As Integer, Nro As Integer) As Integer Implements ITransaccionesNumeracion.modNroRemito
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", id),
            New MySqlParameter("@nNro", Nro)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion_NroRemito")
    End Function

    Public Function modNroFacturaA(id As Integer, Nro As Integer) As Integer Implements ITransaccionesNumeracion.modNroFacturaA
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", id),
            New MySqlParameter("@nNro", Nro)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion_NroFacturaA")
    End Function

    Public Function modNroFacturaB(id As Integer, Nro As Integer) As Integer Implements ITransaccionesNumeracion.modNroFacturaB
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", id),
            New MySqlParameter("@nNro", Nro)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion_NroFacturaB")
    End Function

    Public Function modNroOrdenDeCompra(id As Integer, Nro As Integer) As Integer Implements ITransaccionesNumeracion.modNroOrdenDeCompra
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", id),
            New MySqlParameter("@nNro", Nro)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion_NroOrdenDeCompra")
    End Function

    Public Function modNroRecibo(id As Integer, Nro As Integer) As Integer Implements ITransaccionesNumeracion.modNroRecibo
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", id),
            New MySqlParameter("@nNro", Nro)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion_NroDevolucion")
    End Function

    Public Function modNroDevolucion(id As Integer, Nro As Integer) As Integer Implements ITransaccionesNumeracion.modNroDevolucion
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", id),
            New MySqlParameter("@nNro", Nro)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion_NroRecibo")
    End Function

    Public Function verRegistros() As List(Of TablaNumeracion) Implements ITransaccionesGenericas(Of TablaNumeracion).verRegistros
        Return listNumeracion(ExecuteReader("sigeva.verNumeracion"))
    End Function

    Public Function insRegistro(param As TablaNumeracion) As Integer Implements ITransaccionesGenericas(Of TablaNumeracion).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nPtoVta", param.PuntoVenta),
            New MySqlParameter("@nDes", param.Descripcion),
            New MySqlParameter("@nRes", param.NroReserva),
            New MySqlParameter("@nRem", param.NroRemito),
            New MySqlParameter("@nDev", param.NroDevolucion),
            New MySqlParameter("@nFacA", param.NroFacturaA),
            New MySqlParameter("@nFacB", param.NroFacturaB),
            New MySqlParameter("@nFacC", param.NroFacturaC),
            New MySqlParameter("@nFacX", param.NroFacturaX),
            New MySqlParameter("@nNCA", param.NroNotaCreditoA),
            New MySqlParameter("@nNCB", param.NroNotaCreditoB),
            New MySqlParameter("@nNCC", param.NroNotaCreditoC),
            New MySqlParameter("@nNCX", param.NroNotaCreditoX),
            New MySqlParameter("@nNDA", param.NroNotaDebitoA),
            New MySqlParameter("@nNDB", param.NroNotaDebitoB),
            New MySqlParameter("@nNDC", param.NroNotaDebitoC),
            New MySqlParameter("@nNDX", param.NroNotaDebitoX),
            New MySqlParameter("@nRec", param.NroRecibo),
            New MySqlParameter("@nOrdCom", param.NroOrdenCompra),
            New MySqlParameter("@nEli", param.Eliminado),
            New MySqlParameter("@nIdUs", param.ascUsuarios.idUsuario)
        }

        Return ExecuteNonQuery("sigeva.insNumeracion")
    End Function

    Public Function modRegistro(param As TablaNumeracion) As Integer Implements ITransaccionesGenericas(Of TablaNumeracion).modRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@nId", param.idNumeracion),
            New MySqlParameter("@nPtoVta", param.PuntoVenta),
            New MySqlParameter("@nDes", param.Descripcion),
            New MySqlParameter("@nRes", param.NroReserva),
            New MySqlParameter("@nRem", param.NroRemito),
            New MySqlParameter("@nDev", param.NroDevolucion),
            New MySqlParameter("@nFacA", param.NroFacturaA),
            New MySqlParameter("@nFacB", param.NroFacturaB),
            New MySqlParameter("@nFacC", param.NroFacturaC),
            New MySqlParameter("@nFacX", param.NroFacturaX),
            New MySqlParameter("@nNCA", param.NroNotaCreditoA),
            New MySqlParameter("@nNCB", param.NroNotaCreditoB),
            New MySqlParameter("@nNCC", param.NroNotaCreditoC),
            New MySqlParameter("@nNCX", param.NroNotaCreditoX),
            New MySqlParameter("@nNDA", param.NroNotaDebitoA),
            New MySqlParameter("@nNDB", param.NroNotaDebitoB),
            New MySqlParameter("@nNDC", param.NroNotaDebitoC),
            New MySqlParameter("@nNDX", param.NroNotaDebitoX),
            New MySqlParameter("@nRec", param.NroRecibo),
            New MySqlParameter("@nOrdCom", param.NroOrdenCompra),
            New MySqlParameter("@nEli", param.Eliminado),
            New MySqlParameter("@nIdUs", param.ascUsuarios.idUsuario)
        }

        Return ExecuteNonQuery("sigeva.modNumeracion")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaNumeracion).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@nId", id))

        Return ExecuteNonQuery("sigeva.elimNumeracion")
    End Function

    Private Function listNumeracion(tabla As DataTable) As List(Of TablaNumeracion)
        If tabla.Rows.Count > 0 Then
            Dim numeraciones As New List(Of TablaNumeracion)

            For Each item As DataRow In tabla.Rows
                numeraciones.Add(New TablaNumeracion With {
                    .idNumeracion = item("idNumeracion"),
                    .PuntoVenta = item("PuntoVenta"),
                    .Descripcion = item("Descripcion"),
                    .NroReserva = item("NroReserva"),
                    .NroRemito = item("NroRemito"),
                    .NroDevolucion = item("NroDevolucion"),
                    .NroFacturaA = item("NroFacturaA"),
                    .NroFacturaB = item("NroFacturaB"),
                    .NroFacturaC = item("NroFacturaC"),
                    .NroFacturaX = item("NroFacturaX"),
                    .NroNotaCreditoA = item("NroNotaCreditoA"),
                    .NroNotaCreditoB = item("NroNotaCreditoB"),
                    .NroNotaCreditoC = item("NroNotaCreditoC"),
                    .NroNotaCreditoX = item("NroNotaCreditoX"),
                    .NroNotaDebitoA = item("NroNotaDebitoA"),
                    .NroNotaDebitoB = item("NroNotaDebitoB"),
                    .NroNotaDebitoC = item("NroNotaDebitoC"),
                    .NroNotaDebitoX = item("NroNotaDebitoX"),
                    .NroRecibo = item("NroRecibo"),
                    .NroOrdenCompra = item("NroOrdenCompra"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return numeraciones
        Else
            Return Nothing
        End If
    End Function
End Class
