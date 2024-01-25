CREATE DEFINER=`root`@`localhost` PROCEDURE `verClientes`(
)
BEGIN
	SELECT
		*
	FROM
		Clientes
	WHERE
		Eliminado = "NO";
END