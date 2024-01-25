CREATE DEFINER=`root`@`localhost` PROCEDURE `modComprobante`(
    in ciD int(11),
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
	UPDATE Comprobantes
	SET 
		Nombre = cNombre,
		Copias = cCop,
        Tipo = cTip,
        Leyenda = cLey,
        Encabezado = cEnc,
        LeyendaEnc = cLeyEn,
        Pie = cPie,
        LeyendaPie = cLeyP,
        CantidadCompEmitidos = cCantEm,
        CantidadCopiasComp = cCantCop,
        Eliminado = cElim,
        Usuarios_idUsuarios = dIdUs
	WHERE 
		idComprobantes = ciD;
END