CREATE DEFINER=`root`@`localhost` PROCEDURE `verCliente_Nombre_CUIT`(
	in cNombre varchar(255),
    in cCuit varchar(13)
)
BEGIN
	SELECT
		*
	FROM
		Clientes
	WHERE
		UPPER(RazonSocial) = UPPER(cNombre)  And CUIT = cCuit;
END