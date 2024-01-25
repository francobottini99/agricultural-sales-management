CREATE DEFINER=`root`@`localhost` PROCEDURE `insPedidoMovimientos`(
	in dpFecha date,
	in dpTip varchar(100),
    in dpCant double,
    in dpElim varchar(2),
    in dpIdUs int(11), 
    in dpIdPed int(11),
    in dpIdStk int(11)
)
BEGIN
INSERT INTO PedidosMovimientos (
		Fecha,
		Tipo,
		Cantidad,
		Eliminado,
        Usuarios_idUsuarios,  
        PedidosDetalle_idPedidosDetalle,
        Stock_idStock
)
	VALUES (dpFecha, dpTip, dpCant, dpElim, dpIdUs, dpIdPed, dpIdStk);
END