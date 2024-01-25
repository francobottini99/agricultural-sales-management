CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaVenta`(
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
INSERT INTO FacturaVenta (
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
        CAE,
        FechaVtoCAE,
        Clientes_idClientes,
        Usuarios_idUsuarios,
        CuentaCorrienteVentas_idCuentaCorrienteVentas
)
	VALUES (fvTipo, fvClase, fvFec, fvFecVto, fvPre, fvNro, fvImN, fvDsc, fvBim, fvIva, fvImT, fvObs, fvRem, fvEli, fvCAE, fvFecCAE, fvIdCli, fvIdUs, fvIdCta);
END