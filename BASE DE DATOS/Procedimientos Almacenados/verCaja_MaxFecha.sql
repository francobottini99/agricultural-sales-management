CREATE DEFINER=`root`@`localhost` PROCEDURE `verCaja_MaxFecha`()
BEGIN
	SELECT
		Max(Fecha) as maxFecha
	FROM
		Caja;
END