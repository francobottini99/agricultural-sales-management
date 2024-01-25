CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedido_FechaCierrePedido`(
	in pdId int(11),
    in pdFecCierre date
)
BEGIN
	UPDATE Pedidos
	SET 
        FechaCierrePedido = pdFecCierre
	WHERE 
		idPedidos = pdId;
END