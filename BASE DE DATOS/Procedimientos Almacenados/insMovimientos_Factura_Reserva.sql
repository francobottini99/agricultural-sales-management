CREATE DEFINER=`root`@`localhost` PROCEDURE `insMovimientos_Factura_Reserva`(
	in mfrFec date,
    in mfrTip varchar(100),  
	in mfrCan double,
	in mfrEli varchar(2),
    in mfrIdF int(11),
    in mfrIdP int(11)
)
BEGIN
INSERT INTO Movimientos_Factura_Reseva (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
		FacturaVentaMovimientos_idRemitosMovimientos,
        PedidosMovimientos_idPedidosMovimientos
)
	VALUES (mfrFec, mfrTip, mfrCan, mfrEli, mfrIdF, mfrIdP);
END
