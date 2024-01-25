CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaVentaDetalle_idFacturaVenta`(
	in IdFv int(11)
)
BEGIN
	UPDATE FacturaVentaDetalle
	SET 
		Eliminado = "SI"
	WHERE 
		FacturaVenta_idFacturaVenta = IdFv;
END