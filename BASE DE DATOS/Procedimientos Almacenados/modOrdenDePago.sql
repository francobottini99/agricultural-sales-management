CREATE DEFINER=`root`@`localhost` PROCEDURE `modOrdenDePago`(
	in opId int(11),
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
	UPDATE OrdenDePago
	SET 
		NroComprobante = opNro,
        Fecha = opFec,
		ImportePesos = opImP,
        ImporteDolares = opImD,
		Observaciones = opObs,
        Eliminado = opEli,
        Usuarios_idUsuarios = opIdUs,
        Proveedores_idProveedores = opIdProv,
        CuentaCorrienteCompra_idCuentaCorrienteCompra = opIdCtaCte
	WHERE 
		idOrdenDePago = opId;
END