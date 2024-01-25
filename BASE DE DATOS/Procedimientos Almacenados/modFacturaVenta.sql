CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaVenta`(
	in fvID int(11),
    in fvTipo varchar(45),
    in fvClase varchar(45),
    in fvFec date,
    in fvFecVto date,
    in fvPre varchar(45),
    in fvNro varchar(100),
    in fvImN double,    
    in fvDsc double,    
    in fvBim double,
    in fvIva double,
    in fvImT double,
    in fvObs text,
	in fvRem varchar(2),
    in fvEli varchar(2),
	in fvCAE varchar(100),
    in fvFecCAE date,   
    in fvIdCli int(11),
    in fvIdUs int(11),
    in fvIdCta int(11)
)
BEGIN
	UPDATE FacturaVenta
	SET 
		TipoComprobante = fvTipo,
        ClaseComprobante = fvClase,
		Fecha = fvFec,
        FechaVto = fvFecVto,
		Prefijo = fvPre,
		NroComprobante = fvNro,
        ImporteNeto = fvImN,
        DescuentoGral = fvDsc,
        BaseImponible = fvBim,
		Iva = fvIva,
        ImporteTotal = fvImT,
        Observaciones = fvObs,
		Remitado = fvRem,
        Eliminado = fvEli,
        CAE = fvCAE,
        FechaVtoCAE = fvFecCAE,
        Clientes_idClientes = fvIdCli,
        Usuarios_idUsuarios = fvIdUs,
        CuentaCorrienteVentas_idCuentaCorrienteVentas = fvIdCta
	WHERE
		idFacturaVenta = fvID;
END