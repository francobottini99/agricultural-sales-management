CREATE DEFINER=`root`@`localhost` PROCEDURE `verProveedor_Nombre`(
	in pNombre varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Proveedores
	WHERE
		UPPER(RazonSocial) = UPPER(pNombre);
END