CREATE DEFINER=`root`@`localhost` PROCEDURE `verOrdenDePagoMonedas_idOrdenDePago`(
	in idOpm int(11)
)
BEGIN
	SELECT
		*
	FROM
		OrdenDePagoMonedas
	WHERE
		OrdenDePago_idOrdenDePago = idOpm And Eliminado = "NO";
END