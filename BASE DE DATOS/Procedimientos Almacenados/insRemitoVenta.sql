CREATE DEFINER=`root`@`localhost` PROCEDURE `insRemitoVenta`(
    in rvNroComp varchar(255),
    in rvFec date,
    in rvImp double,
    in rvObs text,    
    in rvImpO int(11),    
    in rvImpC int(11),
	in rvFac varchar(2),    
    in rvElim varchar(2),
	in rvCAE varchar(100),
	in rvFecCAE date,
    in rvIdCli int(11),
    in rvIdUs int(11)
)
BEGIN
INSERT INTO RemitosVenta (
		NroComprobante,
		Fecha,
		Importe,
        Observaciones,
        ImpOriginal,
        ImpCopia,
        Facturado,		
        Eliminado,
        CAE,
        FechaVtaCAE,
        Clientes_idClientes,
        Usuarios_idUsuarios
)
	VALUES (rvNroComp, rvFec, rvImp, rvObs, rvImpO, rvImpC, rvFac, rvElim, rvCAE, rvFecCAE, rvIdCli, rvIdUs);
END