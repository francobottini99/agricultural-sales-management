CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidosDetalle_idPedidosDetalle`(
	in idPd int(11)
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
		PedidosDetalle.Eliminado = "NO" AND idPedidosDetalle = idPd;
END