CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetallePedido`(
	in dpCan double,
	in dpRemi varchar(2),
    in dpFact varchar(2),
    in dpElim varchar(2),
    in dpIdArt int(11),
    in dpIdPed int(11)
)
BEGIN
INSERT INTO PedidosDetalle (
		Cantidad,
        Remitado,
        Facturado,
		Eliminado,
        Articulos_idArticulos,
        Pedidos_idPedidos
)
	VALUES (dpCan, dpRemi, dpFact, dpElim, dpIdArt, dpIdPed);
END