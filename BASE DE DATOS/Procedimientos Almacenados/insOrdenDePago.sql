CREATE DEFINER=`root`@`localhost` PROCEDURE `insOrdenDePago`(
    in opNro varchar(45),
    in opFec date,
    in opImP double,
	in opImD double,
    in opObs text,
    in opEli varchar(2),
    in opIdUs int(11),
    in opIdProv int(11),
	in opIdCtaCte int(11)
)
BEGIN
INSERT INTO OrdenDePago (
		NroComprobante,
        Fecha,
		ImportePesos,
        ImporteDolares,
		Observaciones,
        Eliminado,
        Usuarios_idUsuarios,
        Proveedores_idProveedores,
        CuentaCorrienteCompra_idCuentaCorrienteCompra
)
	VALUES (opNro, opFec, opImP, opImD, opObs, opEli, opIdUs, opIdProv, opIdCtaCte);
END