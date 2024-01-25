CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaCompraDetalle_idFacturaCompra`(
	in IdFc int(11)
)
BEGIN
	UPDATE FacturaCompraDetalle
	SET 
		Eliminado = "SI"
	WHERE 
		FacturaCompra_idFacturaCompra = IdFc;
END