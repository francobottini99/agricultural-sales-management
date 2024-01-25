CREATE DEFINER=`root`@`localhost` PROCEDURE `verCliente_idCliente`(
    in idCli int(11)
)
BEGIN
	SELECT
		*
	FROM
		Clientes
	WHERE
		idClientes = idCli;
END