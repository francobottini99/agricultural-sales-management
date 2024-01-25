CREATE DEFINER=`root`@`localhost` PROCEDURE `insRemitosVentasMovimientos`(
	in rvmFec date,
    in rvmTip varchar(100),  
	in rvmCan double,
	in rvmEli varchar(2),
    in rvmIdU int(11),
    in rvmIdD int(11),
    in rvmIdS int(11)
)
BEGIN
INSERT INTO RemitosVentasMovimientos (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
        Usuarios_idUsuarios,
		DetalleRemitosVenta_idDetalleRemitosVenta,
        Stock_idStock
)
	VALUES (rvmFec, rvmTip, rvmCan, rvmEli, rvmIdU, rvmIdD, rvmIdS);
END