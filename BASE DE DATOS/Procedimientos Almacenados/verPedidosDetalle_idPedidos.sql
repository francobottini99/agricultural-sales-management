CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidosDetalle_idPedidos`(
	in idP int(11)
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
		PedidosDetalle.Eliminado = "NO" AND Pedidos_idPedidos = idP;
END