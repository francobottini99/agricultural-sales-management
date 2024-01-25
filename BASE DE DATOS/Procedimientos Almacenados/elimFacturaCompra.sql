CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaCompra`(
	in IdFc int(11)
)
BEGIN
	UPDATE FacturaCompra
	SET 
		Eliminado = "SI"
	WHERE 
		idFacturaCompra = IdFc;
END