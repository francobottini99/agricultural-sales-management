CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaVtaMonedas_idFacturaVenta`(
	in IdFv int(11)
)
BEGIN
	UPDATE FacturaVtaMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		FacturaVenta_idFacturaVenta = IdFv;
END