CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidosDetalle`(
)
BEGIN
	SELECT
		PedidosDetalle.*,
        Articulos.CodArticulo,
        Articulos.Detalle,
        Articulos.Unidad
	FROM
		PedidosDetalle JOIN Articulos ON PedidosDetalle.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		PedidosDetalle.Eliminado = "NO";
END