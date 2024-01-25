CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitosCompra_idProveedor_Facturado`(
	in idProv int(11),
    in fac varchar(2)
)
BEGIN
	SELECT
		DetalleRemitosCompra.*,
		RemitosCompra.*, 
        Articulos.Detalle,
        Articulos.CodArticulo
	FROM
		DetalleRemitosCompra JOIN RemitosCompra ON DetalleRemitosCompra.RemitosCompra_idRemitosCompra = RemitosCompra.idRemitosCompra
					         JOIN Articulos ON DetalleRemitosCompra.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		RemitosCompra.Proveedores_idProveedores = idProv And DetalleRemitosCompra.Facturado = fac And DetalleRemitosCompra.Eliminado = "NO";
END