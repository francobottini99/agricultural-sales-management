CREATE DEFINER=`root`@`localhost` PROCEDURE `insDevoluciones`(
    in dNroComp varchar(255),
    in dFec date,
    in dImp double,
    in dObs text,    
    in dImpO int(11),    
    in dImpC int(11),
    in dElim varchar(2),
    in dIdCli int(11),
    in dIdUs int(11)
)
BEGIN
INSERT INTO Devoluciones (
		NroComprobante,
		Fecha,
		Importe,
        Observaciones,
        ImpOriginal,
        ImpCopia,	
        Eliminado,
        Clientes_idClientes,
        Usuarios_idUsuarios
)
	VALUES (dNroComp, dFec, dImp, dObs, dImpO, dImpC, dElim, dIdCli, dIdUs);
END