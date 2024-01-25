CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitoVtaMonedas_idRemitosVenta`(
	in idRv int(11)
)
BEGIN
	SELECT
		*
	FROM
		RemitoVtaMonedas
	WHERE
		RemitosVenta_idRemitosVenta = idRv And Eliminado = "NO";
END