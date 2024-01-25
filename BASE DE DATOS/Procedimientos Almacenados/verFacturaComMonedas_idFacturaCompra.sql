CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaComMonedas_idFacturaCompra`(
	in idFc int(11)
)
BEGIN
	SELECT
		*
	FROM
		FacturaComMonedas
	WHERE
		FacturaCompra_idFacturaCompra = idFc And Eliminado = "NO";
END