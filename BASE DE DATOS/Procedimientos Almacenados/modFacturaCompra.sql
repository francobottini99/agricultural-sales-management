CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaCompra`(
	in fcID int(11),
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
    in fcEli varchar(2),
    in fcRem varchar(2),
    in fcIdUs int(11),
    in fcIdProv int(11),
    in fcIdCta int(11)
)
BEGIN
	UPDATE FacturaCompra
	SET 
		TipoComprobante = fcTip,
        ClaseComprobante = fcCla,
		Fecha = fcFec,
        FechaVto = fcFecVto,
		Prefijo = fcPre,
		NroComprobante = fcNro,
        ImporteNeto = fcImN,
        DescuentoGral = fcDsc,
        BaseImponible = fcBim,
		Iva = fcIva,
        ImporteTotal = fcImT,
        Observaciones = fcObs,
		Remitado = fcRem,
        Eliminado = fcEli,
        Usuarios_idUsuarios = fcIdUs,
        Proveedores_idProveedores = fcIdProv,
        CuentaCorrienteCompra_idCuentaCorrienteCompra = fcIdCta
	WHERE 
		idFacturaCompra = fcID;
END