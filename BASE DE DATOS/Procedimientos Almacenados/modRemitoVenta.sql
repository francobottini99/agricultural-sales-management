CREATE DEFINER=`root`@`localhost` PROCEDURE `modRemitoVenta`(
	in rvID int(11),
    in rvComp varchar(100),
	in rvFec date,
    in rvImp double,
    in rvObs varchar (255),
    in rvImOr int(11),
    in rvImCop int(11),    
	in rvFac varchar(2),    
    in rvElim varchar(2),
	in rvCAE varchar(100),
	in rvFecCAE date,
    in rvIdCli int(11),
    in rvIdUs int(11)
)
BEGIN
	UPDATE RemitosVenta
	SET 
		NroComprobante = rvComp,
		Fecha = rvFec,
		Importe = rvImp,
		Observaciones = rvObs,
        ImpOriginal = rvImOr,
        ImpCopia = rvImCop,
        Facturado = rvFac,        
        Eliminado = rvElim,
        CAE = rvCAE,
        FechaVtoCAE = rvFecCAE,
		Clientes_idClientes = rvIdCli,
        Usuarios_idUsuarios = rvIdUs
	WHERE 
		idRemitosVenta = rvID;
END