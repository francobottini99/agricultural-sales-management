CREATE DEFINER=`root`@`localhost` PROCEDURE `verParidadCambiaria_idMoneda`(
	in idM int(11)
)
BEGIN
	SELECT
		*
	FROM
		Paridadcambiaria
	WHERE
		Monedas_idMonedas = idM and Eliminado = "NO";
END