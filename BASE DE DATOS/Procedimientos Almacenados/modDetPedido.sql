CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetPedido`(
	in dpId int(11),
    in dpCant double,
	in dpRemi varchar(2),
    in dpFact varchar(2),
    in dpElim varchar(2),
    in dpIdArt int(11),
    in dpIdPed int(11)
)
BEGIN
	UPDATE PedidosDetalle
	SET 
		Cantidad = dpCant,
		Remitado = dpRemi,
        Facturado = dpFact,
		Eliminado = dpElim,
        Articulos_idArticulos = dpIdArt,
        Pedidos_idPedidos = dpIdPed
	WHERE 
		idPedidosDetalle = dpId;
END