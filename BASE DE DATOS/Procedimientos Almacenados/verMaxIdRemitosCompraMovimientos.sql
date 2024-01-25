CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdRemitosCompraMovimientos`()
BEGIN
	SELECT
		Max(idRemitosCompraMovimientos) as UltimoId
	FROM
		RemitosCompraMovimientos;
END
