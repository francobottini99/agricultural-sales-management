CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVtaMonedas_idFacturaVenta`(
	in idFv int(11)
)
BEGIN
	SELECT
		*
	FROM
		FacturaVtaMonedas
	WHERE
		FacturaVenta_idFacturaVenta = idFv And Eliminado = "NO";
END