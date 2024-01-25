CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedidoMovimiento`(
    in dpId int(11),
	in dpFecha date,
	in dpTip varchar(100),
    in dpCant double,
    in dpElim varchar(2),
    in dpIdUs int(11), 
    in dpIdPed int(11),
    in dpIdStk int(11)
)
BEGIN
	UPDATE PedidosMovimientos
	SET 
		Fecha = dpFecha,
		Tipo = dpTip,
		Cantidad = dpCant,
		Eliminado = dpElim,
        Usuarios_idUsuarios = dpIdUs,
        PedidosDetalle_idPedidosDetalle = dpIdPed,
        Stock_idStock = dpIdStk
	WHERE 
		idPedidosMovimientos = dpId;
END