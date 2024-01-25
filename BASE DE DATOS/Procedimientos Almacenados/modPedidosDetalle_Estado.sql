CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedidosDetalle_Estado`(
	in pdId int(11),
    in pdRem varchar(2),
    in pdFac varchar(2)
)
BEGIN
	UPDATE PedidosDetalle
	SET 
		Remitado = pdRem,
        Facturado = pdFac
	WHERE 
		idPedidosDetalle = pdId;
END