CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitosCompra_idRemitosCompra`(
	in idRc int(11)
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
		RemitosCompra.idRemitosCompra = idRc;
END