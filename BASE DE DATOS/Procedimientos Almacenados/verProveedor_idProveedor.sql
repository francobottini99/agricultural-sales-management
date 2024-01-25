CREATE DEFINER=`root`@`localhost` PROCEDURE `verProveedor_idProveedor`(
    in idProv int(11)
)
BEGIN
	SELECT
		*
	FROM
		Proveedores
	WHERE
		idProveedores = idProv;
END