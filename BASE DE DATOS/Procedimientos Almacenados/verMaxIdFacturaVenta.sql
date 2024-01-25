CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdFacturaVenta`()
BEGIN
	SELECT
		Max(idFacturaVenta) as UltimoId
	FROM
		FacturaVenta;
END