CREATE DEFINER=`root`@`localhost` PROCEDURE `verRecibosVentaMonedas`(
)
BEGIN
	SELECT
		*
	FROM
		RecibosVentaMonedas
	WHERE
		Eliminado = "NO";
END