CREATE DEFINER=`root`@`localhost` PROCEDURE `insOrdenPagoDetalle`(
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
INSERT INTO OrdenPagoDetalle (
		MedioPago,
        NroComprobante,
        EntidadEmisora,
		SucursalEntidad,
        Librador,
        FechaCobro,
        Moneda,
        Importe,
        Eliminado,
        OrdenDePago_idOrdenDePago
)
	VALUES (opdMed, opdNro, opdBan, opdSuc, opdLib, opdCob, opdMon, opdImp, opdEli, opdIdOp);
END