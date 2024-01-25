CREATE DEFINER=`root`@`localhost` PROCEDURE `insChequera`(
	in NroCta varchar(100),
	in Fec date,
    in Bco varchar(255),
    in NroCh int(11),
    in CantCh int(11),
    in ChEm int(11),
    in ChAn int(11),
    in ChDisp int(11),    
    in Observ varchar(255),    
    in Elim varchar(2),
    in Us int(11)
)
BEGIN
INSERT INTO Chequera (
		NroCuenta,
		FechaAlta,
        Banco,
        NroChqInicial,
		CantidadChq,
		ChqEmitidos,
        ChqAnulados,
        ChqDisponibles,
        Observaciones,
		Eliminada,
        Usuarios_idUsuarios
)
	VALUES (NroCta, Fec, Bco, NroCh, CantCh, ChEm, ChAn, ChDisp, Observ, Elim, Us);
END