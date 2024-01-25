CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitosVenta_idRV`(
	in idRV int(11)
)
BEGIN
	SELECT
		DetalleRemitosVenta.*,
        Articulos.CodArticulo
	FROM
		DetalleRemitosVenta JOIN Articulos ON DetalleRemitosVenta.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		RemitosVenta_idRemitosVenta = idRV And DetalleRemitosVenta.Eliminado = "NO";
END