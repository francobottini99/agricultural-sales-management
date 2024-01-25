CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedidos_Remitado`(
	in pId int(11),
    in pRem varchar(2)
)
BEGIN
	UPDATE Pedidos
	SET 
		Remitado = pRem
	WHERE 
		idPedidos = pId;
END