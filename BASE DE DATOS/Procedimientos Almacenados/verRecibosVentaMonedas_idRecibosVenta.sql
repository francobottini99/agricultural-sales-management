CREATE DEFINER=`root`@`localhost` PROCEDURE `verRecibosVentaMonedas_idRecibosVenta`(
	in idRvm int(11)
)
BEGIN
	SELECT
		*
	FROM
		RecibosVentaMonedas
	WHERE
		RecibosVenta_idRecibosVenta = idRvm And Eliminado = "NO";
END