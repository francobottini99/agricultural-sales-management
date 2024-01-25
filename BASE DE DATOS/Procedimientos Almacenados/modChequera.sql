CREATE DEFINER=`root`@`localhost` PROCEDURE `modChequera`(
	in idChq int(11),
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
	UPDATE Chequera
	SET 
		FechaAlta = Fec,
        Banco = Bco,
        NroChqInicial = NroCh,
		CantidadChq = CantCh,
		ChqEmitidos = ChEm,
        ChqAnulados = ChAn,
        ChqDisponibles = ChDisp,
        Observaciones = Observ,
		Eliminada = Elim,
        Usuarios_idUsuarios = Us
	WHERE 
		idChequera = idChq;
END