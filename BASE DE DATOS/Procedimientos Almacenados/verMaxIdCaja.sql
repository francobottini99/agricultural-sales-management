CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdCaja`()
BEGIN
	SELECT
		Max(idCaja) as UltimoId
	FROM
		Caja;
END