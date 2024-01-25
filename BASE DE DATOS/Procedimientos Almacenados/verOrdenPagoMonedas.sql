CREATE DEFINER=`root`@`localhost` PROCEDURE `verOrdenPagoMonedas`(
)
BEGIN
	SELECT
		*
	FROM
		OrdenPagoMonedas
	WHERE
		Eliminado = "NO";
END
