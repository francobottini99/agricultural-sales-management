CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaCompra`(
)
BEGIN
	SELECT
		FacturaCompra.*,
        Proveedores.*
	FROM
		FacturaCompra JOIN Proveedores ON FacturaCompra.Proveedores_idProveedores = Proveedores.idProveedores
	WHERE
		FacturaCompra.Eliminado = "NO";
END