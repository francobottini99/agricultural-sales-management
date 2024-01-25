CREATE DEFINER=`root`@`localhost` PROCEDURE `verCliente_CUIT`(
    in cCuit varchar(13)
)
BEGIN
	SELECT
		*
	FROM
		Clientes
	WHERE
		CUIT = cCuit;
END