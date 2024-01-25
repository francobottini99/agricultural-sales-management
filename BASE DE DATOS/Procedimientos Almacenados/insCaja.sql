CREATE DEFINER=`root`@`localhost` PROCEDURE `insCaja`(
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
INSERT INTO Caja (
		Fecha,
        Movimiento,
        Comprobante,
        Detalle,
        Moneda,
        Ingreso,
        Egreso,
        Observaciones,
        Eliminado,
        Usuarios_idUsuarios
)
	VALUES (cFec, cMov, cCom, cDet, cMon, cIng, cEgr, cObs, cEli, cIdUs);
END