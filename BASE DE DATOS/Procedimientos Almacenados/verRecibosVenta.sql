CREATE DEFINER=`root`@`localhost` PROCEDURE `verRecibosVenta`(
)
BEGIN
	SELECT
		*
	FROM
		RecibosVenta
	WHERE
		Eliminado = "NO";
END