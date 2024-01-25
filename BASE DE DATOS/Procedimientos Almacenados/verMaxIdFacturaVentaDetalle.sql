CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdFacturaVentaDetalle`()
BEGIN
	SELECT
		Max(idFacturaVentaDetalle) as UltimoId
	FROM
		FacturaVentaDetalle;
END