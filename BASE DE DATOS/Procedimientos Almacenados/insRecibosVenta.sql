CREATE DEFINER=`root`@`localhost` PROCEDURE `insRecibosVenta`(
    in rvNro varchar(45),
    in rvFec date,
    in rvImP double,
	in rvImD double,
    in rvObs text,
    in rvEli varchar(2),
    in rvIdUs int(11),
    in rvIdCli int(11),
	in rvIdCtaCte int(11)
)
BEGIN
INSERT INTO RecibosVenta (
		NroComprobante,
        Fecha,
		ImportePesos,
        ImporteDolares,
		Observaciones,
        Eliminado,
        Usuarios_idUsuarios,
        Clientes_idClientes,
        CuentaCorrienteVentas_idCuentaCorrienteVentas
)
	VALUES (rvNro, rvFec, rvImP, rvImD, rvObs, rvEli, rvIdUs, rvIdCli, rvIdCtaCte);
END