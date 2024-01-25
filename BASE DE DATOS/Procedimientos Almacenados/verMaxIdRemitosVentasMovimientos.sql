CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdRemitosVentasMovimientos`()
BEGIN
	SELECT
		Max(idRemitosVentasMovimientos) as UltimoId
	FROM
		RemitosVentasMovimientos;
END
