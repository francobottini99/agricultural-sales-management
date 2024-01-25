CREATE DEFINER=`root`@`localhost` PROCEDURE `verCaja`(
)
BEGIN
	SELECT
		*
	FROM
		Caja
	WHERE
		Eliminado = "NO"
	ORDER BY Fecha ASC;
END