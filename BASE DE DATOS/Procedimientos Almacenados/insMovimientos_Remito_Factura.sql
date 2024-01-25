CREATE DEFINER=`root`@`localhost` PROCEDURE `insMovimientos_Remito_Factura`(
	in mrfFec date,
    in mrfTip varchar(100),  
	in mrfCan double,
	in mrfEli varchar(2),
    in mrfIdD int(11),
    in mrfIdF int(11)
)
BEGIN
INSERT INTO Movimientos_Remito_Factura (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
		RemitosVentasMovimientos_idRemitosVentasMovimientos,
        FacturaVentaMovimientos_idFacturaVentaMovimientos
)
	VALUES (mrfFec, mrfTip, mrfCan, mrfEli, mrfIdD, mrfIdF);
END