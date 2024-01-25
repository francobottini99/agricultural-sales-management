CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidos_idPedidos`(
	in id int(11)
)
BEGIN
	SELECT
		*
	FROM
		Pedidos
	WHERE
		Pedidos.Eliminado = "NO" AND idPedidos = id;
END