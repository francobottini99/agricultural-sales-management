CREATE DEFINER=`root`@`localhost` PROCEDURE `verCuentaCorrienteVentas_idCliente`(
	in ccvIdCli int(11)
)
BEGIN
	SELECT
		*
	FROM
		CuentaCorrienteVentas
	WHERE
		Clientes_idClientes = ccvIdCli  And Eliminado = "NO";
END