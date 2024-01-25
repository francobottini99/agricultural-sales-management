CREATE DEFINER=`root`@`localhost` PROCEDURE `modCaja`(
	in IdC int(11),
    in cFec date,  
    in cMov varchar(255),
    in cCom varchar(255),
    in cDet varchar(255),
    in cMon varchar(45),
    in cIng double,
    in cEgr double,
    in cObs varchar(255),
    in cEli varchar(2),
    in cIdUs int(11)
)
BEGIN
	UPDATE Caja
	SET 
		Fecha = cFec,
        Movimiento = cMov,
        Comprobante = cCom,
        Detalle = cDet,
        Moneda = cMon,
        Ingreso = cIng,
        Egreso = cEgr,
        Observaciones = cObs,
        Eliminado = cEli,
        Usuarios_idUsuarios = cIdUs
	WHERE 
		idCaja = IdC;
END