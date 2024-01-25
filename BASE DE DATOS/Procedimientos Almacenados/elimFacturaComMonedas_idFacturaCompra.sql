CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaComMonedas_idFacturaCompra`(
	in IdFc int(11)
)
BEGIN
	UPDATE FacturaComMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		FacturaCompra_idFacturaCompra = IdFc;
END