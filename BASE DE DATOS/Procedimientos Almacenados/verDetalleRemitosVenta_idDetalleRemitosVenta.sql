CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitosVenta_idDetalleRemitosVenta`(
	in idDr int(11)
)
BEGIN
	SELECT
		DetalleRemitosVenta.*,
        Articulos.Detalle,
        Articulos.CodArticulo,
        Articulos.Unidad
	FROM
		DetalleRemitosVenta JOIN Articulos ON DetalleRemitosVenta.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		DetalleRemitosVenta.Eliminado = "NO" AND idDetalleRemitosVenta = idDr;
END