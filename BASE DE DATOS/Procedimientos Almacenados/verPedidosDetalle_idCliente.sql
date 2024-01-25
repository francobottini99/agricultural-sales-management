CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidosDetalle_idCliente`(
	in idCli int(11)
)
BEGIN
	SELECT
		PedidosDetalle.*,
		Pedidos.*, 
        Articulos.Detalle,
        Articulos.CodArticulo
	FROM
		PedidosDetalle JOIN Pedidos ON PedidosDetalle.Pedidos_idPedidos = Pedidos.idPedidos
					   JOIN Articulos ON PedidosDetalle.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		Pedidos.Clientes_idClientes = idCli And PedidosDetalle.Eliminado = "NO";
END