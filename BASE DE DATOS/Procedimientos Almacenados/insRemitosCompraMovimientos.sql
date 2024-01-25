CREATE DEFINER=`root`@`localhost` PROCEDURE `insRemitosCompraMovimientos`(
	in rcmFec date,
    in rcmTip varchar(100),  
	in rcmCan double,
	in rcmEli varchar(2),
    in rcmIdU int(11),
    in rcmIdD int(11),
    in rcmIdS int(11)
)
BEGIN
INSERT INTO RemitosCompraMovimientos (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
        Usuarios_idUsuarios,
		DetalleRemitosCompra_idDetalleRemitosCompra,
        Stock_idStock
)
	VALUES (rcmFec, rcmTip, rcmCan, rcmEli, rcmIdU, rcmIdD, rcmIdS);
END