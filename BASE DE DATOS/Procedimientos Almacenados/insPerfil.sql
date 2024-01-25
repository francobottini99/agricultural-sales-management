CREATE DEFINER=`root`@`localhost` PROCEDURE `insPerfil`(
	in pNombrePerfil varchar (255),
    in pSistema_Empresa tinyint(4),
	in pSistema_Moneda tinyint(4),
    in pSistema_Comprobantes tinyint(4),
    in pSistema_Alicuotas tinyint(4),
    in pAltas_Usuarios tinyint(4),
    in pAltas_Clientes tinyint(4),
    in pAltas_Proveedores tinyint(4),
    in pAltas_Articulos tinyint(4),
    in pAltas_Categorias tinyint(4),
    in pAltas_Bancos tinyint(4),
    in pAltas_Gastos tinyint(4),
    in pAltas_Depositos tinyint(4),
    in pGestion_Compras_Remitos tinyint(4),
    in pGestion_Compras_Facturas tinyint(4),
    in pGestion_Compras_NotasCredito tinyint(4),
    in pGestion_Compras_NotasDebito tinyint(4),
    in pGestion_Compras_OrdenPago tinyint(4),
    in pGestion_Ventas_Pedidos tinyint(4),
    in pGestion_Ventas_Remitos tinyint(4),
    in pGestion_Ventas_Facturas tinyint(4),
    in pGestion_Ventas_NotasCredito tinyint(4),
    in pGestion_Ventas_NotasDebito tinyint(4),
    in pGestion_Ventas_Recibos tinyint(4),
    in pGestion_Canjes_EmisionContratos tinyint(4),
    in pGestion_Canjes_FijacionContratos tinyint(4),
    in pGestion_Canjes_CartaPorte tinyint(4),
    in pGestion_Canjes_Liquidaciones tinyint(4),
    in pGestion_Caja_Manual tinyint(4),
    in pGestion_Caja_Gastos tinyint(4),
    in pGestion_Caja_Cartera tinyint(4),
    in pGestion_Bancos_Depositos tinyint(4),
    in pGestion_Bancos_Retiros tinyint(4),
    in pStock_Mantenimiento tinyint(4),
    in pStock_Transferencias tinyint(4),
    in pConsultas_Usuarios tinyint(4),
    in pConsultas_Clientes tinyint(4),
    in pConsultas_Proveedores tinyint(4),
    in pConsultas_Articulos tinyint(4),
    in pConsultas_Compras_Remitos tinyint(4),
    in pConsultas_Compras_Facturas tinyint(4),
    in pConsultas_Compras_NotasCredito tinyint(4),
    in pConsultas_Compras_NotasDebito tinyint(4),
    in pConsultas_Ventas_Pedidos tinyint(4),
    in pConsultas_Ventas_Remitos tinyint(4),
    in pConsultas_Ventas_Facturas tinyint(4),
    in pConsultas_Ventas_NotasCredito tinyint(4),
    in pConsultas_Ventas_NotasDebito tinyint(4),
    in pConsultas_Ventas_Recibos tinyint(4),
    in pConsultas_Stock tinyint(4),
    in pConsultas_Canjes_Contratos tinyint(4),
    in pConsultas_Canjes_CartaPorte tinyint(4),
    in pConsultas_Canjes_Liquidaciones tinyint(4),
    in pConsultas_Caja_MovHistoricos tinyint(4),
    in pConsultas_Caja_Arqueos tinyint(4),
    in pConsultas_Caja_Cartera tinyint(4),
    in pConsultas_Bancos tinyint(4),
    in pSeguridad_Respaldos tinyint(4),
    in pSeguridad_Perfiles tinyint(4),
    in pSeguridad_RegistroRespaldo tinyint(4),
    in pSeguridad_RegistroActividad tinyint(4)
)
BEGIN
INSERT INTO Perfilesusuario (
		NombrePerfil,
		Sistema_Empresa,
		Sistema_Moneda,
        Sistema_Comprobantes,
        Sistema_Alicuotas,
        Altas_Usuarios,
        Altas_Clientes,
        Altas_Proveedores,
        Altas_Articulos,
		Altas_Categorias,
		Altas_Bancos,
		Altas_Gastos,
        Altas_Depositos,
        Gestion_Compras_Remitos,
        Gestion_Compras_Facturas,
        Gestion_Compras_NotasCredito,
        Gestion_Compras_NotasDebito,
		Gestion_Compras_OrdenPago,
		Gestion_Ventas_Pedidos,
		Gestion_Ventas_Remitos,
        Gestion_Ventas_Facturas,
        Gestion_Ventas_NotasCredito,
        Gestion_Ventas_NotasDebito,
        Gestion_Ventas_Recibos,
        Gestion_Canjes_EmisionContratos,
		Gestion_Canjes_FijacionContratos,
		Gestion_Canjes_CartaPorte,
		Gestion_Canjes_Liquidaciones,
        Gestion_Caja_Manual,
        Gestion_Caja_Gastos,
        Gestion_Caja_Cartera,
        Gestion_Bancos_Depositos,
        Gestion_Bancos_Retiros,
        Stock_Mantenimiento,
		Stock_Transferencias,
		Consultas_Usuarios,
		Consultas_Clientes,
        Consultas_Proveedores,
        Consultas_Articulos,
        Consultas_Compras_Remitos,
        Consultas_Compras_Facturas,
        Consultas_Compras_NotasCredito,
		Consultas_Compras_NotasDebito,
		Consultas_Ventas_Pedidos,
		Consultas_Ventas_Remitos,
        Consultas_Ventas_Facturas,
        Consultas_Ventas_NotasCredito,
        Consultas_Ventas_NotasDebito,
        Consultas_Ventas_Recibos,
        Consultas_Stock,
		Consultas_Canjes_Contratos,
        Consultas_Canjes_CartaPorte,
        Consultas_Canjes_Liquidaciones,
        Consultas_Caja_MovHistoricos,
		Consultas_Caja_Arqueos,
		Consultas_Caja_Cartera,
		Consultas_Bancos,
        Seguridad_Respaldos,
        Seguridad_Perfiles,
        Seguridad_RegistroRespaldo,
        Seguridad_RegistroActividad,
        Eliminar
)
	VALUES (pNombrePerfil, pSistema_Empresa, pSistema_Moneda, pSistema_Comprobantes, pSistema_Alicuotas, pAltas_Usuarios, pAltas_Clientes, pAltas_Proveedores, pAltas_Articulos, pAltas_Categorias, pAltas_Bancos, pAltas_Gastos, pAltas_Depositos, pGestion_Compras_Remitos, pGestion_Compras_Facturas, pGestion_Compras_NotasCredito, pGestion_Compras_NotasDebito, pGestion_Compras_OrdenPago, pGestion_Ventas_Pedidos, pGestion_Ventas_Remitos, pGestion_Ventas_Facturas, pGestion_Ventas_NotasCredito, pGestion_Ventas_NotasDebito, pGestion_Ventas_Recibos, pGestion_Canjes_EmisionContratos, pGestion_Canjes_FijacionContratos, pGestion_Canjes_CartaPorte, pGestion_Canjes_Liquidaciones, pGestion_Caja_Manual, pGestion_Caja_Gastos, pGestion_Caja_Cartera, pGestion_Bancos_Depositos, pGestion_Bancos_Retiros, pStock_Mantenimiento, pStock_Transferencias, pConsultas_Usuarios, pConsultas_Clientes, pConsultas_Proveedores, pConsultas_Articulos, pConsultas_Compras_Remitos, pConsultas_Compras_Facturas, pConsultas_Compras_NotasCredito, pConsultas_Compras_NotasDebito, pConsultas_Ventas_Pedidos, pConsultas_Ventas_Remitos, pConsultas_Ventas_Facturas, pConsultas_Ventas_NotasCredito, pConsultas_Ventas_NotasDebito, pConsultas_Ventas_Recibos, pConsultas_Stock, pConsultas_Canjes_Contratos, pConsultas_Canjes_CartaPorte, pConsultas_Canjes_Liquidaciones, pConsultas_Caja_MovHistoricos, pConsultas_Caja_Arqueos, pConsultas_Caja_Cartera, pConsultas_Bancos, pSeguridad_Respaldos, pSeguridad_Perfiles, pSeguridad_RegistroRespaldo, pSeguridad_RegistroActividad, "NO");
END