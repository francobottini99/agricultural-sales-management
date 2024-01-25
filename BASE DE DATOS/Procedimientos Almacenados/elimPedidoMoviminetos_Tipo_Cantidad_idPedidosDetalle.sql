CREATE DEFINER=`root`@`localhost` PROCEDURE `elimPedidoMoviminetos_Tipo_Cantidad_idPedidosDetalle`(
	in pmTip varchar(100),
    in pmCan double,
    in pmIdPedDet int(11)
)
BEGIN
	UPDATE PedidosMovimientos
	SET 
		Eliminado = "SI"
	WHERE 
		Tipo = pmTip AND Cantidad = pmCan AND PedidosDetalle_idPedidosDetalle = pmIdPedDet;
END