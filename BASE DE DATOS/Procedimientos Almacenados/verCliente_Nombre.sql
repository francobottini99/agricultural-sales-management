CREATE DEFINER=`root`@`localhost` PROCEDURE `verCliente_Nombre`(
	in cNombre varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Clientes
	WHERE
		UPPER(RazonSocial) = UPPER(cNombre);
END