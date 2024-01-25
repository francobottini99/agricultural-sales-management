CREATE DEFINER=`root`@`localhost` PROCEDURE `elimOrdenDePagoDetalle_idOrdenDePago`(
	in IdOp int(11)
)
BEGIN
	UPDATE OrdenPagoDetalle
	SET 
		Eliminado = "SI"
	WHERE 
		OrdenDePago_idOrdenDePago = IdOp;
END