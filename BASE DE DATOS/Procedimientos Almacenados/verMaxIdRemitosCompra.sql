CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdRemitosCompra`()
BEGIN
	SELECT
		Max(idRemitosCompra) as UltimoId
	FROM
		RemitosCompra;
END