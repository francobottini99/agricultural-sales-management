CREATE DEFINER=`root`@`localhost` PROCEDURE `insMovimientos_Reserva_Remito`(
	in mrrFec date,
    in mrrTip varchar(100),  
	in mrrCan double,
	in mrrEli varchar(2),
    in mrrIdP int(11),
    in mrrIdD int(11)
)
BEGIN
INSERT INTO Movimientos_Reserva_Remito (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
		PedidosMovimientos_idPedidosMovimientos,
        RemitosVentasMovimientos_idRemitosMovimientos
)
	VALUES (mrrFec, mrrTip, mrrCan, mrrEli, mrrIdP, mrrIdD);
END