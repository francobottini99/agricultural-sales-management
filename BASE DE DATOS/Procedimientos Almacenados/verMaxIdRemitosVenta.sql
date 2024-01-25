CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdRemitosVenta`()
BEGIN
	SELECT
		Max(idRemitosVenta) as UltimoId
	FROM
		RemitosVenta;
END