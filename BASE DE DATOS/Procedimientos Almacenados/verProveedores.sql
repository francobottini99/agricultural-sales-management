CREATE DEFINER=`root`@`localhost` PROCEDURE `verProveedores`(
)
BEGIN
	SELECT
		*
	FROM
		Proveedores
	WHERE
		Eliminado = "NO";
END