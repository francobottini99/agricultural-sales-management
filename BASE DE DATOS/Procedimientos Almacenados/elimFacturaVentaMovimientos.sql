CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaVentaMovimientos`(
	in fvmId int(11)
)
BEGIN
	UPDATE FacturaVentaMovimientos
	SET 
		Eliminado = "SI"
	WHERE 
		idFacturaVentaMovimientos = fvmId;
END