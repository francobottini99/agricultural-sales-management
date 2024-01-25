CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidos`(
)
BEGIN
	SELECT
		Pedidos.*,
        Clientes.RazonSocial
	FROM
		Pedidos JOIN Clientes ON Pedidos.Clientes_idClientes = Clientes.idClientes
	WHERE
		Eliminado = "NO";
END