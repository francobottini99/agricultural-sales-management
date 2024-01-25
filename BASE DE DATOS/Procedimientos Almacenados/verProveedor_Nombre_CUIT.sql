CREATE DEFINER=`root`@`localhost` PROCEDURE `verProveedor_Nombre_CUIT`(
	in pNombre varchar(255),
    in pCuit varchar(13)
)
BEGIN
	SELECT
		*
	FROM
		Proveedores
	WHERE
		UPPER(RazonSocial) = UPPER(pNombre)  And CUIT = pCuit;
END