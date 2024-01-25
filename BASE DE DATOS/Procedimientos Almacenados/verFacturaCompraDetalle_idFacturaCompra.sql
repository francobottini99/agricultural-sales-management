CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaCompraDetalle_idFacturaCompra`(
	in idFc int(11)
)
BEGIN
	SELECT
		FacturaCompraDetalle.*,
        Articulos.CodArticulo
	FROM
		FacturaCompraDetalle JOIN Articulos ON FacturaCompraDetalle.Articulos_idArticulos = Articulos.idArticulos
    WHERE
		FacturaCompraDetalle.FacturaCompra_idFacturaCompra = idFc And FacturaCompraDetalle.Eliminado = "NO";
END