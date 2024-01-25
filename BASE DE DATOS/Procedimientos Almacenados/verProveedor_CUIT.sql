CREATE DEFINER=`root`@`localhost` PROCEDURE `verProveedor_CUIT`(
    in pCuit varchar(13)
)
BEGIN
	SELECT
		*
	FROM
		Proveedores
	WHERE
		CUIT = pCuit;
END