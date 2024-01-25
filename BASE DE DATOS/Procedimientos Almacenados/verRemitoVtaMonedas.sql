CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitoVtaMonedas`(
)
BEGIN
	SELECT
		*
	FROM
		RemitoVtaMonedas
	WHERE
		Eliminado = "NO";
END