CREATE DEFINER=`root`@`localhost` PROCEDURE `insMovimientos_RemitoCompra_FacturaCompra`(
	in mrfFec date,
    in mrfTip varchar(100),  
	in mrfCan double,
	in mrfEli varchar(2),
    in mrfIdD int(11),
    in mrfIdF int(11)
)
BEGIN
INSERT INTO Movimientos_RemitoCompra_FacturaCompra (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
		RemitosCompraMovimientos_idRemitosCompraMovimientos,
        FacturaCompraMovimientos_idFacturaCompraMovimientos
)
	VALUES (mrfFec, mrfTip, mrfCan, mrfEli, mrfIdD, mrfIdF);
END