CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdFacturaCompraMovimientos`()
BEGIN
	SELECT
		Max(idFacturaCompraMovimientos) as UltimoId
	FROM
		FacturaCompraMovimientos;
END