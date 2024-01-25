CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidos_Remitado`(
    in pRem varchar(2)
)
BEGIN
	SELECT
		Pedidos.*,
        Clientes.RazonSocial
	FROM
		Pedidos JOIN Clientes ON Pedidos.Clientes_idClientes = Clientes.idClientes
	WHERE
		Pedidos.Eliminado = "NO" AND Pedidos.Remitado = pRem;
END