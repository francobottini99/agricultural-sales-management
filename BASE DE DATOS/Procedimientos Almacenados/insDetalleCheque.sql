CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleCheque`(
    in Nro int(11),
    in Fem date,
    in Fcob date,
    in Pl int(11),
    in Imp double,
    in Dest varchar(255),    
    in EnDisp varchar(2),
	in Cob varchar(2),
    in An varchar(2),
    in Mdf varchar(2),
    in Modif varchar(255),
    in Obs varchar(255),
    in Elim varchar(2),
    in idChq int(11),
    in Us int(11)
)
BEGIN
INSERT INTO DetalleCheque (
		Numero,
        FechaEmision,
        FechaCobro,
		PlazoDias,
		Importe,
        Destino,
        EnDisponiblidad,
        Cobrado,
        Anulado,
        Modificado,
        Modificacion,
        Observaciones,
		Eliminado,
        Chequera_idChequera,
        Usuarios_idUsuarios
)
	VALUES (Nro, Fem, Fcob, Pl, Imp, Dest, EnDisp, Cob, An, Mdf, Modif, Obs, Elim, idChq, Us);
END