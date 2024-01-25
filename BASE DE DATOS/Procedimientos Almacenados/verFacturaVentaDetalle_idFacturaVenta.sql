CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVentaDetalle_idFacturaVenta`(
	in idFv int(11)
)
BEGIN
	SELECT
		FacturaVentaDetalle.*,
        Articulos.CodArticulo
	FROM
		FacturaVentaDetalle JOIN Articulos ON FacturaVentaDetalle.Articulos_idArticulos = Articulos.idArticulos
    WHERE
		FacturaVentaDetalle.FacturaVenta_idFacturaVenta = idFv And FacturaVentaDetalle.Eliminado = "NO";
END