CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitosCompra_Sin_Facturar`(
)
BEGIN
	SELECT
		RemitosCompra.*,
        Usuarios.*,
        Proveedores.*
	FROM
		RemitosCompra JOIN Usuarios ON RemitosCompra.Usuarios_idUsuarios = Usuarios.idUsuarios
        JOIN Proveedores ON RemitosCompra.Proveedores_idProveedores = Proveedores.idProveedores
	WHERE
		RemitosCompra.Eliminado = "NO" AND RemitosCompra.Facturado = "NO";
END