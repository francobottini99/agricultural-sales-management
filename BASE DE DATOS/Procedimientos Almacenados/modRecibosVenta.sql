CREATE DEFINER=`root`@`localhost` PROCEDURE `modRecibosVenta`(
	in rvId int(11),
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
	UPDATE RecibosVenta
	SET 
		NroComprobante = rvNro,
        Fecha = rvFec,
		ImportePesos = rvImP,
        ImporteDolares = rvImD,
		Observaciones = rvObs,
        Eliminado = rvEli,
        Usuarios_idUsuarios = rvIdUs,
        Clientes_idClientes = rvIdCli,
        CuentaCorrienteVentas_idCuentaCorrienteVentas = rvIdCtaCte
	WHERE 
		idRecibosVenta = rvId;
END