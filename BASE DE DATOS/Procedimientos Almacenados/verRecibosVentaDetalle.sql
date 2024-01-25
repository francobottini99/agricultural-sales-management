CREATE DEFINER=`root`@`localhost` PROCEDURE `verRecibosVentaDetalle`(
)
BEGIN
	SELECT
		*
	FROM
		RecibosVentaDetalle
	WHERE
		Eliminado = "NO";
END