Imports MySql.Data.MySqlClient

Public Class TransaccionesPerfilUsuario
    Inherits Transacciones
    Implements ITransaccionesPerfilUsuario

    Public Function verExistePerfilPorNombre(nombre As String) As Boolean Implements ITransaccionesPerfilUsuario.verExistePerfilPorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pNombre", nombre))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verPerfil_Nombre")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verPerfilUsuarioID(id As Integer) As TablaPerfilUsuario Implements ITransaccionesPerfilUsuario.verPerfilUsuarioID
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verPerfil_idP")

        If resultTable.Rows.Count > 0 Then
            Dim ARR(100) As Boolean

            ARR(0) = resultTable.Rows(0).Item("Sistema_Empresa")
            ARR(1) = resultTable.Rows(0).Item("Sistema_Moneda")
            ARR(2) = resultTable.Rows(0).Item("Sistema_Comprobantes")
            ARR(3) = resultTable.Rows(0).Item("Sistema_Alicuotas")
            ARR(4) = resultTable.Rows(0).Item("Altas_Usuarios")
            ARR(5) = resultTable.Rows(0).Item("Altas_Clientes")
            ARR(6) = resultTable.Rows(0).Item("Altas_Proveedores")
            ARR(7) = resultTable.Rows(0).Item("Altas_Articulos")
            ARR(8) = resultTable.Rows(0).Item("Altas_Categorias")
            ARR(9) = resultTable.Rows(0).Item("Altas_Bancos")
            ARR(10) = resultTable.Rows(0).Item("Altas_Gastos")
            ARR(11) = resultTable.Rows(0).Item("Altas_Depositos")
            ARR(12) = resultTable.Rows(0).Item("Gestion_Compras_Remitos")
            ARR(13) = resultTable.Rows(0).Item("Gestion_Compras_Facturas")
            ARR(14) = resultTable.Rows(0).Item("Gestion_Compras_NotasCredito")
            ARR(15) = resultTable.Rows(0).Item("Gestion_Compras_NotasDebito")
            ARR(16) = resultTable.Rows(0).Item("Gestion_Compras_OrdenPago")
            ARR(17) = resultTable.Rows(0).Item("Gestion_Ventas_Pedidos")
            ARR(18) = resultTable.Rows(0).Item("Gestion_Ventas_Remitos")
            ARR(19) = resultTable.Rows(0).Item("Gestion_Ventas_Facturas")
            ARR(20) = resultTable.Rows(0).Item("Gestion_Ventas_NotasCredito")
            ARR(21) = resultTable.Rows(0).Item("Gestion_Ventas_NotasDebito")
            ARR(22) = resultTable.Rows(0).Item("Gestion_Ventas_Recibos")
            ARR(23) = resultTable.Rows(0).Item("Gestion_Canjes_EmisionContratos")
            ARR(24) = resultTable.Rows(0).Item("Gestion_Canjes_FijacionContratos")
            ARR(25) = resultTable.Rows(0).Item("Gestion_Canjes_CartaPorte")
            ARR(26) = resultTable.Rows(0).Item("Gestion_Canjes_Liquidaciones")
            ARR(27) = resultTable.Rows(0).Item("Gestion_Caja_Manual")
            ARR(28) = resultTable.Rows(0).Item("Gestion_Caja_Gastos")
            ARR(29) = resultTable.Rows(0).Item("Gestion_Caja_Cartera")
            ARR(30) = resultTable.Rows(0).Item("Gestion_Bancos_Depositos")
            ARR(31) = resultTable.Rows(0).Item("Gestion_Bancos_Retiros")
            ARR(32) = resultTable.Rows(0).Item("Stock_Mantenimiento")
            ARR(33) = resultTable.Rows(0).Item("Stock_Transferencias")
            ARR(34) = resultTable.Rows(0).Item("Consultas_Usuarios")
            ARR(35) = resultTable.Rows(0).Item("Consultas_Clientes")
            ARR(36) = resultTable.Rows(0).Item("Consultas_Proveedores")
            ARR(37) = resultTable.Rows(0).Item("Consultas_Articulos")
            ARR(38) = resultTable.Rows(0).Item("Consultas_Compras_Remitos")
            ARR(39) = resultTable.Rows(0).Item("Consultas_Compras_Facturas")
            ARR(40) = resultTable.Rows(0).Item("Consultas_Compras_NotasCredito")
            ARR(41) = resultTable.Rows(0).Item("Consultas_Compras_NotasDebito")
            ARR(42) = resultTable.Rows(0).Item("Consultas_Ventas_Pedidos")
            ARR(43) = resultTable.Rows(0).Item("Consultas_Ventas_Remitos")
            ARR(44) = resultTable.Rows(0).Item("Consultas_Ventas_Facturas")
            ARR(45) = resultTable.Rows(0).Item("Consultas_Ventas_NotasCredito")
            ARR(46) = resultTable.Rows(0).Item("Consultas_Ventas_NotasDebito")
            ARR(47) = resultTable.Rows(0).Item("Consultas_Ventas_Recibos")
            ARR(48) = resultTable.Rows(0).Item("Consultas_Stock")
            ARR(49) = resultTable.Rows(0).Item("Consultas_Canjes_Contratos")
            ARR(50) = resultTable.Rows(0).Item("Consultas_Canjes_CartaPorte")
            ARR(51) = resultTable.Rows(0).Item("Consultas_Canjes_Liquidaciones")
            ARR(52) = resultTable.Rows(0).Item("Consultas_Caja_MovHistoricos")
            ARR(53) = resultTable.Rows(0).Item("Consultas_Caja_Arqueos")
            ARR(54) = resultTable.Rows(0).Item("Consultas_Caja_Cartera")
            ARR(55) = resultTable.Rows(0).Item("Consultas_Bancos")
            ARR(56) = resultTable.Rows(0).Item("Seguridad_Respaldos")
            ARR(57) = resultTable.Rows(0).Item("Seguridad_Perfiles")
            ARR(58) = resultTable.Rows(0).Item("Seguridad_RegistroRespaldo")
            ARR(59) = resultTable.Rows(0).Item("Seguridad_RegistroActividad")

            Return New TablaPerfilUsuario With {
                    .IdPerfil = resultTable.Rows(0).Item("idPerfilesUsuario"),
                    .NombrePerfil = resultTable.Rows(0).Item("NombrePerfil"),
                    .Accesos = ARR
            }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaPerfilUsuario) Implements ITransaccionesGenericas(Of TablaPerfilUsuario).verRegistros
        Return listPerfiles(ExecuteReader("sigeva.verPerfiles"))
    End Function

    Public Function insRegistro(param As TablaPerfilUsuario) As Integer Implements ITransaccionesGenericas(Of TablaPerfilUsuario).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pNombrePerfil", param.NombrePerfil))
        parametros.Add(New MySqlParameter("@pSistema_Empresa", param.Accesos(0)))
        parametros.Add(New MySqlParameter("@pSistema_Moneda", param.Accesos(1)))
        parametros.Add(New MySqlParameter("@pSistema_Comprobantes", param.Accesos(2)))
        parametros.Add(New MySqlParameter("@pSistema_Alicuotas", param.Accesos(3)))
        parametros.Add(New MySqlParameter("@pAltas_Usuarios", param.Accesos(4)))
        parametros.Add(New MySqlParameter("@pAltas_Clientes", param.Accesos(5)))
        parametros.Add(New MySqlParameter("@pAltas_Proveedores", param.Accesos(6)))
        parametros.Add(New MySqlParameter("@pAltas_Articulos", param.Accesos(7)))
        parametros.Add(New MySqlParameter("@pAltas_Categorias", param.Accesos(8)))
        parametros.Add(New MySqlParameter("@pAltas_Bancos", param.Accesos(9)))
        parametros.Add(New MySqlParameter("@pAltas_Gastos", param.Accesos(10)))
        parametros.Add(New MySqlParameter("@pAltas_Depositos", param.Accesos(11)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_Remitos", param.Accesos(12)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_Facturas", param.Accesos(13)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_NotasCredito", param.Accesos(14)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_NotasDebito", param.Accesos(15)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_OrdenPago", param.Accesos(16)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Pedidos", param.Accesos(17)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Remitos", param.Accesos(18)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Facturas", param.Accesos(19)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_NotasCredito", param.Accesos(20)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_NotasDebito", param.Accesos(21)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Recibos", param.Accesos(22)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_EmisionContratos", param.Accesos(23)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_FijacionContratos", param.Accesos(24)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_CartaPorte", param.Accesos(25)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_Liquidaciones", param.Accesos(26)))
        parametros.Add(New MySqlParameter("@pGestion_Caja_Manual", param.Accesos(27)))
        parametros.Add(New MySqlParameter("@pGestion_Caja_Gastos", param.Accesos(28)))
        parametros.Add(New MySqlParameter("@pGestion_Caja_Cartera", param.Accesos(29)))
        parametros.Add(New MySqlParameter("@pGestion_Bancos_Depositos", param.Accesos(30)))
        parametros.Add(New MySqlParameter("@pGestion_Bancos_Retiros", param.Accesos(31)))
        parametros.Add(New MySqlParameter("@pStock_Mantenimiento", param.Accesos(32)))
        parametros.Add(New MySqlParameter("@pStock_Transferencias", param.Accesos(33)))
        parametros.Add(New MySqlParameter("@pConsultas_Usuarios", param.Accesos(34)))
        parametros.Add(New MySqlParameter("@pConsultas_Clientes", param.Accesos(35)))
        parametros.Add(New MySqlParameter("@pConsultas_Proveedores", param.Accesos(36)))
        parametros.Add(New MySqlParameter("@pConsultas_Articulos", param.Accesos(37)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_Remitos", param.Accesos(38)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_Facturas", param.Accesos(39)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_NotasCredito", param.Accesos(40)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_NotasDebito", param.Accesos(41)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Pedidos", param.Accesos(42)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Remitos", param.Accesos(43)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Facturas", param.Accesos(44)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_NotasCredito", param.Accesos(45)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_NotasDebito", param.Accesos(46)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Recibos", param.Accesos(47)))
        parametros.Add(New MySqlParameter("@pConsultas_Stock", param.Accesos(48)))
        parametros.Add(New MySqlParameter("@pConsultas_Canjes_Contratos", param.Accesos(49)))
        parametros.Add(New MySqlParameter("@pConsultas_Canjes_CartaPorte", param.Accesos(50)))
        parametros.Add(New MySqlParameter("@pConsultas_Canjes_Liquidaciones", param.Accesos(51)))
        parametros.Add(New MySqlParameter("@pConsultas_Caja_MovHistoricos", param.Accesos(52)))
        parametros.Add(New MySqlParameter("@pConsultas_Caja_Arqueos", param.Accesos(53)))
        parametros.Add(New MySqlParameter("@pConsultas_Caja_Cartera", param.Accesos(54)))
        parametros.Add(New MySqlParameter("@pConsultas_Bancos", param.Accesos(55)))
        parametros.Add(New MySqlParameter("@pSeguridad_Respaldos", param.Accesos(56)))
        parametros.Add(New MySqlParameter("@pSeguridad_Perfiles", param.Accesos(57)))
        parametros.Add(New MySqlParameter("@pSeguridad_RegistroRespaldo", param.Accesos(58)))
        parametros.Add(New MySqlParameter("@pSeguridad_RegistroActividad", param.Accesos(59)))

        Return ExecuteNonQuery("sigeva.insPerfil")
    End Function

    Public Function modRegistro(param As TablaPerfilUsuario) As Integer Implements ITransaccionesGenericas(Of TablaPerfilUsuario).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", param.IdPerfil))
        parametros.Add(New MySqlParameter("@pNombrePerfil", param.NombrePerfil))
        parametros.Add(New MySqlParameter("@pSistema_Empresa", param.Accesos(0)))
        parametros.Add(New MySqlParameter("@pSistema_Moneda", param.Accesos(1)))
        parametros.Add(New MySqlParameter("@pSistema_Comprobantes", param.Accesos(2)))
        parametros.Add(New MySqlParameter("@pSistema_Alicuotas", param.Accesos(3)))
        parametros.Add(New MySqlParameter("@pAltas_Usuarios", param.Accesos(4)))
        parametros.Add(New MySqlParameter("@pAltas_Clientes", param.Accesos(5)))
        parametros.Add(New MySqlParameter("@pAltas_Proveedores", param.Accesos(6)))
        parametros.Add(New MySqlParameter("@pAltas_Articulos", param.Accesos(7)))
        parametros.Add(New MySqlParameter("@pAltas_Categorias", param.Accesos(8)))
        parametros.Add(New MySqlParameter("@pAltas_Bancos", param.Accesos(9)))
        parametros.Add(New MySqlParameter("@pAltas_Gastos", param.Accesos(10)))
        parametros.Add(New MySqlParameter("@pAltas_Depositos", param.Accesos(11)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_Remitos", param.Accesos(12)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_Facturas", param.Accesos(13)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_NotasCredito", param.Accesos(14)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_NotasDebito", param.Accesos(15)))
        parametros.Add(New MySqlParameter("@pGestion_Compras_OrdenPago", param.Accesos(16)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Pedidos", param.Accesos(17)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Remitos", param.Accesos(18)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Facturas", param.Accesos(19)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_NotasCredito", param.Accesos(20)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_NotasDebito", param.Accesos(21)))
        parametros.Add(New MySqlParameter("@pGestion_Ventas_Recibos", param.Accesos(22)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_EmisionContratos", param.Accesos(23)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_FijacionContratos", param.Accesos(24)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_CartaPorte", param.Accesos(25)))
        parametros.Add(New MySqlParameter("@pGestion_Canjes_Liquidaciones", param.Accesos(26)))
        parametros.Add(New MySqlParameter("@pGestion_Caja_Manual", param.Accesos(27)))
        parametros.Add(New MySqlParameter("@pGestion_Caja_Gastos", param.Accesos(28)))
        parametros.Add(New MySqlParameter("@pGestion_Caja_Cartera", param.Accesos(29)))
        parametros.Add(New MySqlParameter("@pGestion_Bancos_Depositos", param.Accesos(30)))
        parametros.Add(New MySqlParameter("@pGestion_Bancos_Retiros", param.Accesos(31)))
        parametros.Add(New MySqlParameter("@pStock_Mantenimiento", param.Accesos(32)))
        parametros.Add(New MySqlParameter("@pStock_Transferencias", param.Accesos(33)))
        parametros.Add(New MySqlParameter("@pConsultas_Usuarios", param.Accesos(34)))
        parametros.Add(New MySqlParameter("@pConsultas_Clientes", param.Accesos(35)))
        parametros.Add(New MySqlParameter("@pConsultas_Proveedores", param.Accesos(36)))
        parametros.Add(New MySqlParameter("@pConsultas_Articulos", param.Accesos(37)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_Remitos", param.Accesos(38)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_Facturas", param.Accesos(39)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_NotasCredito", param.Accesos(40)))
        parametros.Add(New MySqlParameter("@pConsultas_Compras_NotasDebito", param.Accesos(41)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Pedidos", param.Accesos(42)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Remitos", param.Accesos(43)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Facturas", param.Accesos(44)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_NotasCredito", param.Accesos(45)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_NotasDebito", param.Accesos(46)))
        parametros.Add(New MySqlParameter("@pConsultas_Ventas_Recibos", param.Accesos(47)))
        parametros.Add(New MySqlParameter("@pConsultas_Stock", param.Accesos(48)))
        parametros.Add(New MySqlParameter("@pConsultas_Canjes_Contratos", param.Accesos(49)))
        parametros.Add(New MySqlParameter("@pConsultas_Canjes_CartaPorte", param.Accesos(50)))
        parametros.Add(New MySqlParameter("@pConsultas_Canjes_Liquidaciones", param.Accesos(51)))
        parametros.Add(New MySqlParameter("@pConsultas_Caja_MovHistoricos", param.Accesos(52)))
        parametros.Add(New MySqlParameter("@pConsultas_Caja_Arqueos", param.Accesos(53)))
        parametros.Add(New MySqlParameter("@pConsultas_Caja_Cartera", param.Accesos(54)))
        parametros.Add(New MySqlParameter("@pConsultas_Bancos", param.Accesos(55)))
        parametros.Add(New MySqlParameter("@pSeguridad_Respaldos", param.Accesos(56)))
        parametros.Add(New MySqlParameter("@pSeguridad_Perfiles", param.Accesos(57)))
        parametros.Add(New MySqlParameter("@pSeguridad_RegistroRespaldo", param.Accesos(58)))
        parametros.Add(New MySqlParameter("@pSeguridad_RegistroActividad", param.Accesos(59)))

        Return ExecuteNonQuery("sigeva.modPerfil")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaPerfilUsuario).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdP", id))

        Return ExecuteNonQuery("sigeva.elimPerfil")
    End Function

    Public Function verUsuarioPorIDperfil(id As Integer) As Boolean Implements ITransaccionesPerfilUsuario.verUsuarioPorIDperfil
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verUsuarios_idP")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function listPerfiles(tabla As DataTable) As List(Of TablaPerfilUsuario)
        If tabla.Rows.Count > 0 Then
            Dim perflles As New List(Of TablaPerfilUsuario)

            For Each item As DataRow In tabla.Rows
                Dim ARR(100) As Boolean

                ARR(0) = item("Sistema_Empresa")
                ARR(1) = item("Sistema_Moneda")
                ARR(2) = item("Sistema_Comprobantes")
                ARR(3) = item("Sistema_Alicuotas")
                ARR(4) = item("Altas_Usuarios")
                ARR(5) = item("Altas_Clientes")
                ARR(6) = item("Altas_Proveedores")
                ARR(7) = item("Altas_Articulos")
                ARR(8) = item("Altas_Categorias")
                ARR(9) = item("Altas_Bancos")
                ARR(10) = item("Altas_Gastos")
                ARR(11) = item("Altas_Depositos")
                ARR(12) = item("Gestion_Compras_Remitos")
                ARR(13) = item("Gestion_Compras_Facturas")
                ARR(14) = item("Gestion_Compras_NotasCredito")
                ARR(15) = item("Gestion_Compras_NotasDebito")
                ARR(16) = item("Gestion_Compras_OrdenPago")
                ARR(17) = item("Gestion_Ventas_Pedidos")
                ARR(18) = item("Gestion_Ventas_Remitos")
                ARR(19) = item("Gestion_Ventas_Facturas")
                ARR(20) = item("Gestion_Ventas_NotasCredito")
                ARR(21) = item("Gestion_Ventas_NotasDebito")
                ARR(22) = item("Gestion_Ventas_Recibos")
                ARR(23) = item("Gestion_Canjes_EmisionContratos")
                ARR(24) = item("Gestion_Canjes_FijacionContratos")
                ARR(25) = item("Gestion_Canjes_CartaPorte")
                ARR(26) = item("Gestion_Canjes_Liquidaciones")
                ARR(27) = item("Gestion_Caja_Manual")
                ARR(28) = item("Gestion_Caja_Gastos")
                ARR(29) = item("Gestion_Caja_Cartera")
                ARR(30) = item("Gestion_Bancos_Depositos")
                ARR(31) = item("Gestion_Bancos_Retiros")
                ARR(32) = item("Stock_Mantenimiento")
                ARR(33) = item("Stock_Transferencias")
                ARR(34) = item("Consultas_Usuarios")
                ARR(35) = item("Consultas_Clientes")
                ARR(36) = item("Consultas_Proveedores")
                ARR(37) = item("Consultas_Articulos")
                ARR(38) = item("Consultas_Compras_Remitos")
                ARR(39) = item("Consultas_Compras_Facturas")
                ARR(40) = item("Consultas_Compras_NotasCredito")
                ARR(41) = item("Consultas_Compras_NotasDebito")
                ARR(42) = item("Consultas_Ventas_Pedidos")
                ARR(43) = item("Consultas_Ventas_Remitos")
                ARR(44) = item("Consultas_Ventas_Facturas")
                ARR(45) = item("Consultas_Ventas_NotasCredito")
                ARR(46) = item("Consultas_Ventas_NotasDebito")
                ARR(47) = item("Consultas_Ventas_Recibos")
                ARR(48) = item("Consultas_Stock")
                ARR(49) = item("Consultas_Canjes_Contratos")
                ARR(50) = item("Consultas_Canjes_CartaPorte")
                ARR(51) = item("Consultas_Canjes_Liquidaciones")
                ARR(52) = item("Consultas_Caja_MovHistoricos")
                ARR(53) = item("Consultas_Caja_Arqueos")
                ARR(54) = item("Consultas_Caja_Cartera")
                ARR(55) = item("Consultas_Bancos")
                ARR(56) = item("Seguridad_Respaldos")
                ARR(57) = item("Seguridad_Perfiles")
                ARR(58) = item("Seguridad_RegistroRespaldo")
                ARR(59) = item("Seguridad_RegistroActividad")

                perflles.Add(New TablaPerfilUsuario With {
                    .IdPerfil = item("idPerfilesUsuario"),
                    .NombrePerfil = item("NombrePerfil"),
                    .Accesos = ARR
                })
            Next

            Return perflles
        Else
            Return Nothing
        End If
    End Function
End Class
