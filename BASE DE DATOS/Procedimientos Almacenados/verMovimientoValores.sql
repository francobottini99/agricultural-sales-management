CREATE DEFINER=`root`@`localhost` PROCEDURE `verMovimientoValores`(
)
BEGIN
	SELECT
		*
	FROM
		MovimientoValores
	WHERE
		Eliminado = "NO";
END