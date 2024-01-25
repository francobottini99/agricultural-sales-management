CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaCompraMovimientos`(
	in fcmFec date,
    in fcmTip varchar(100),  
	in fcmCan double,
	in fcmEli varchar(2),
    in fcmIdU int(11),
    in fcmIdF int(11)
)
BEGIN
INSERT INTO FacturaCompraMovimientos (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
        Usuarios_idUsuarios,
		FacturaCompraDetalle_idFacturaCompraDetalle
)
	VALUES (fcmFec, fcmTip, fcmCan, fcmEli, fcmIdU, fcmIdF);
END
