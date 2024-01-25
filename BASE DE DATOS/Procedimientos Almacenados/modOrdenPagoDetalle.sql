CREATE DEFINER=`root`@`localhost` PROCEDURE `modOrdenPagoDetalle`(
    in opdId int(11),
	in opdMed varchar(100),
	in opdNro varchar(45),
    in opdBan varchar(255),
    in opdSuc varchar(255),
    in opdLib varchar(255),
    in opdCob date,
    in opdMon varchar(45),
    in opdImp double,
    in opdEli varchar(2),
    in opdIdOp int(11)
)
BEGIN
	UPDATE OrdenPagoDetalle
	SET 
		MedioPago = opdMed,
        NroComprobante = opdNro,
        EntidadEmisora = opdBan,
		SucursalEntidad = opdSuc,
        Librador = opdLib,
        FechaCobro = opdCob,
        Moneda = opdMon,
        Importe = opdImp,
        Eliminado = opdEli,
        OrdenDePago_idOrdenDePago = opdIdOp
	WHERE 
		idOrdenPagoDetalle = opdId;
END