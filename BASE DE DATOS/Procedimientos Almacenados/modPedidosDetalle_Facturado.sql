CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedidosDetalle_Facturado`(
	in pdId int(11),
    in pdFac varchar(2)
)
BEGIN
	UPDATE PedidosDetalle
	SET 
		Facturado = pdFac
	WHERE 
		idPedidosDetalle = pdId;
END
