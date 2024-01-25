CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVtaMonedas`(
)
BEGIN
	SELECT
		*
	FROM
		FacturaVtaMonedas
	WHERE
		Eliminado = "NO";
END