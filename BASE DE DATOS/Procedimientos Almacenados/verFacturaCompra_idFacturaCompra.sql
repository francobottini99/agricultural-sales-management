CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaCompra_idFacturaCompra`(
	in idFc int(11)
)
BEGIN
	SELECT
		FacturaCompra.*,
        Proveedores.*
	FROM
		FacturaCompra JOIN Proveedores ON FacturaCompra.Proveedores_idProveedores = Proveedores.idProveedores
	WHERE
		FacturaCompra.idFacturaCompra = idFc AND FacturaCompra.Eliminado = "NO";
END