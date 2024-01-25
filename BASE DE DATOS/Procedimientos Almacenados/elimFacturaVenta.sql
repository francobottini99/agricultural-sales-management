CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaVenta`(
	in IdFv int(11)
)
BEGIN
	UPDATE FacturaVenta
	SET 
		Eliminado = "SI"
	WHERE 
		idFacturaVenta = IdFv;
END