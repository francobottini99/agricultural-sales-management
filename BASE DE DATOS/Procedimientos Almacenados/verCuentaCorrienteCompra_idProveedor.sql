CREATE DEFINER=`root`@`localhost` PROCEDURE `verCuentaCorrienteCompra_idProveedor`(
	in cccIdProv int(11)
)
BEGIN
	SELECT
		*
	FROM
		CuentaCorrienteCompra
	WHERE
		Proveedores_idProveedores = cccIdProv  And Eliminado = "NO";
END