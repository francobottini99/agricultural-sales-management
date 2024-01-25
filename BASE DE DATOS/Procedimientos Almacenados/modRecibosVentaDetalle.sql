CREATE DEFINER=`root`@`localhost` PROCEDURE `modRecibosVentaDetalle`(
    in rvdId int(11),
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
	UPDATE RecibosVentaDetalle
	SET 
		MedioPago = rvdMed,
        NroComprobante = rvdNro,
        EntidadEmisora = rvdBan,
		SucursalEntidad = rvdSuc,
        Librador = rvdLib,
        FechaCobro = rvdCob,
        Moneda = rvdMon,
        Importe = rvdImp,
        Eliminado = rvdEli,
        RecibosVenta_idRecibosVenta = rvdIdRv
	WHERE 
		idRecibosVentaDetalle = rvdId;
END