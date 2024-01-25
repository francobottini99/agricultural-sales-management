CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedidos_Facturado`(
	in pId int(11),
    in pFac varchar(2)
)
BEGIN
	UPDATE Pedidos
	SET 
		Facturado = pFac
	WHERE 
		idPedidos = pId;
END