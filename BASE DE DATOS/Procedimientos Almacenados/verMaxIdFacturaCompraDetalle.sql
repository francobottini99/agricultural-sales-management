CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdFacturaCompraDetalle`()
BEGIN
	SELECT
		Max(idFacturaCompraDetalle) as UltimoId
	FROM
		FacturaCompraDetalle;
END