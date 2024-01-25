CREATE DEFINER=`root`@`localhost` PROCEDURE `elimOrdenDePagoMonedas_idOrdenDePago`(
	in IdOp int(11)
)
BEGIN
	UPDATE OrdenDePagoMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		OrdenDePago_idOrdenDePago = IdOp;
END