CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidos_Facturado_Remitado`(
	in pFac varchar(2),
    in pRem varchar(2)
)
BEGIN
	SELECT
		Pedidos.*,
        Clientes.RazonSocial
	FROM
		Pedidos JOIN Clientes ON Pedidos.Clientes_idClientes = Clientes.idClientes
	WHERE
		Pedidos.Eliminado = "NO" AND Pedidos.Facturado = pFac AND Pedidos.Remitado = pRem;
END