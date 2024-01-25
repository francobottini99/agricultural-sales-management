CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaCompra`(
	in fcTip varchar(45),
    in fcCla varchar(45),
    in fcFec date,
    in fcFecVto date,
    in fcPre varchar(45),
    in fcNro varchar(100),
    in fcImN double,    
    in fcDsc double,    
    in fcBim double,
    in fcIva double,
    in fcImT double,
    in fcObs text,
    in fcRem varchar(2),
    in fcEli varchar(2),
    in fcIdUs int(11),
    in fcIdProv int(11),
    in fcIdCta int(11)
)
BEGIN
INSERT INTO FacturaCompra (
		TipoComprobante,
        ClaseComprobante,
		Fecha,
        FechaVto,
		Prefijo,
		NroComprobante,
        ImporteNeto,
        DescuentoGral,
        BaseImponible,
		Iva,
        ImporteTotal,
        Observaciones,
        Remitado,
        Eliminado,
        Usuarios_idUsuarios,
        Proveedores_idProveedores,
        CuentaCorrienteCompra_idCuentaCorrienteCompra
)
	VALUES (fcTip, fcCla ,fcFec, fcFecVto, fcPre, fcNro, fcImN, fcDsc, fcBim, fcIva, fcImT, fcObs, fcRem, fcEli, fcIdUs, fcIdProv, fcIdCta);
END