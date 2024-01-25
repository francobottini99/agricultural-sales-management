CREATE DEFINER=`root`@`localhost` PROCEDURE `insRecibosVentaDetalle`(
	in rvdMed varchar(100),
	in rvdNro varchar(45),
    in rvdBan varchar(255),
    in rvdSuc varchar(255),
    in rvdLib varchar(255),
    in rvdCob date,
	in rvdMon varchar(45),
    in rvdImp double,
    in rvdEli varchar(2),
    in rvdIdRv int(11)
)
BEGIN
INSERT INTO RecibosVentaDetalle (
		MedioPago,
        NroComprobante,
        EntidadEmisora,
		SucursalEntidad,
        Librador,
        FechaCobro,
        Moneda,
        Importe,
        Eliminado,
        RecibosVenta_idRecibosVenta
)
	VALUES (rvdMed, rvdNro, rvdBan, rvdSuc, rvdLib, rvdCob, rvdMon, rvdImp, rvdEli, rvdIdRv);
END