CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitosCompra_idRC`(
	in idRC int(11)
)
BEGIN
	SELECT
		DetalleRemitosCompra.*,
        Articulos.CodArticulo
	FROM
		DetalleRemitosCompra JOIN Articulos ON DetalleRemitosCompra.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		RemitosCompra_idRemitosCompra = idRC And DetalleRemitosCompra.Eliminado = "NO";
END