CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleCheque`(
	in idChq int(11),
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
    in idChra int(11),
    in Us int(11)
)
BEGIN
	UPDATE DetalleCheque
	SET 
		Numero = Nro,
        FechaEmision = Fem,
        FechaCobro = Fcob,
		PlazoDias = Pl,
		Importe = Imp,
        Destino = Dest,
        EnDisponiblidad = EnDisp,
        Cobrado = Cob,
        Anulado = An,
        Modificado = Mdf,
        Modificacion = Modif,
        Observaciones = Obs,
		Eliminado = Elim,
        Chequera_idChequera = idChra,
        Usuarios_idUsuarios = Us
	WHERE 
		idDetalleCheque = idChq;
END