CREATE DEFINER=`root`@`localhost` PROCEDURE `insRegistroOperaciones`(
    in roFec date,
    in roHor time,
    in roOpe varchar(255),
    in roDeO text,
    in roTbl varchar(255),   
	in roPro varchar(255),
    in roDoc varchar(255),    
    in roRep varchar(255),
    in roRes varchar(255),
    in roDeR text,
    in roIdU int(11)
)
BEGIN
INSERT INTO RegistroOperaciones (
		Fecha,
        Hora,
		Operacion,
		DetalleOperacion,
        TablasAfectadas,
        ProcedimientoAlmacenado,
        DocumentosEmitidos,
        ReportesEmitidos,
        ResultadoOperacion,
        DetalleResultado,
		Usuarios_idUsuarios
)
	VALUES (roFec, roHor, roOpe, roDeO, roTbl, roPro, roDoc, roRep, roRes, roDeR, roIdU);
END