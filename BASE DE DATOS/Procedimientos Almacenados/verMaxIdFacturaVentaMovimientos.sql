CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdFacturaVentaMovimientos`()
BEGIN
	SELECT
		Max(idFacturaVentaMovimientos) as UltimoId
	FROM
		FacturaVentaMovimientos;
END