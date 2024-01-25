CREATE DEFINER=`root`@`localhost` PROCEDURE `verCaja_MinFecha`()
BEGIN
	SELECT
		Min(Fecha) as minFecha
	FROM
		Caja;
END