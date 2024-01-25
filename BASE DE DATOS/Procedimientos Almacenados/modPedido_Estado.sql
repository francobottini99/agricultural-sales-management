CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedido_Estado`(
	in pdId int(11),
    in pdRem varchar(2),
    in pdFac varchar(2)
)
BEGIN
	UPDATE Pedidos
	SET 
		Remitado = pdRem,
        Facturado = pdFac
	WHERE 
		idPedidos = pdId;
END