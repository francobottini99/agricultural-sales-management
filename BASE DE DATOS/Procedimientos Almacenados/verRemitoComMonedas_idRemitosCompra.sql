CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitoComMonedas_idRemitosCompra`(
	in idRc int(11)
)
BEGIN
	SELECT
		*
	FROM
		RemitoComMonedas
	WHERE
		RemitosCompra_idRemitosCompra = idRc And Eliminado = "NO";
END