CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdFacturaCompra`()
BEGIN
	SELECT
		Max(idFacturaCompra) as UltimoId
	FROM
		FacturaCompra;
END