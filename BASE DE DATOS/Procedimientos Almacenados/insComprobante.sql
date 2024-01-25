CREATE DEFINER=`root`@`localhost` PROCEDURE `insComprobante`(
    in cNombre varchar (255),
    in cCop int(11),
    in cTip varchar (255),
    in cLey text,    
    in cEnc varchar (2),    
    in cLeyEn varchar(255),
    in cPie varchar(2),
    in cLeyP varchar(255),
    in cCantEm int(11),
    in cCantCop int(11),
    in cElim varchar(11),
    in dIdUs int(11)
)
BEGIN
INSERT INTO Comprobantes (
		Nombre,
		Copias,
        Tipo,
        Leyenda,
        Encabezado,
        LeyendaEnc,
        Pie,
        LeyendaPie,
        CantidadCompEmitidos,
        CantidadCopiasComp,
        Eliminado,
        Usuarios_idUsuarios
)
	VALUES (cNombre, cCop, cTip, cLey, cEnc, cLeyEn, cPie, cLeyP, cCantEm, cCantCop, cElim, dIdUs);
END