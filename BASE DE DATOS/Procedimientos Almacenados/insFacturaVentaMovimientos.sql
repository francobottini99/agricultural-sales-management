CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaVentaMovimientos`(
	in fvmFec date,
    in fvmTip varchar(100),  
	in fvmCan double,
	in fvmEli varchar(2),
    in fvmIdU int(11),
    in fvmIdF int(11)
)
BEGIN
INSERT INTO FacturaVentaMovimientos (
		Fecha,
        Tipo,
        Cantidad,
        Eliminado,
        Usuarios_idUsuarios,
		FacturaVentaDetalle_idFacturaVentaDetalle
)
	VALUES (fvmFec, fvmTip, fvmCan, fvmEli, fvmIdU, fvmIdF);
END