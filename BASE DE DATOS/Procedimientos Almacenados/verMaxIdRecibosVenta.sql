CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdRecibosVenta`()
BEGIN
	SELECT
		Max(idRecibosVenta) as UltimoId
	FROM
		RecibosVenta;
END
