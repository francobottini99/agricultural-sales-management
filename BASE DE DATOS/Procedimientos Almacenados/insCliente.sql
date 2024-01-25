CREATE DEFINER=`root`@`localhost` PROCEDURE `insCliente`(
	in cFecha date,
    in cRazSoc varchar (255),
    in cDir varchar(255),
    in cLoc varchar (255),
    in cProv varchar (255),    
    in cCP varchar (45),    
    in cPais varchar (255),
    in cTE varchar (255),
    in cMail varchar (255), 
    in cWeb varchar(255),
    in cCuit varchar (13),
    in cIB varchar (45),
    in cSitIVA varchar (100),
    in cCred double,
    in cCons double,
    in cEst varchar (45),
    in cClas varchar (100),
    in cElim varchar(2),
    in cIdUs int(11)
)
BEGIN
INSERT INTO Clientes (
		FechaAlta,
		RazonSocial,
		Direccion,
        Localidad,
        Provincia,
        CP,
		Pais,
        TE,
        Mail,
        Web,
        CUIT,
        IIBB,
        SituacionIVA,
        CreditoAsignado,
        CreditoConsumido,
        Estado,
        Clasificacion,
        Eliminado,
        Usuarios_idUsuarios
)
	VALUES (cFecha, cRazSoc, cDir, cLoc, cProv, cCP, cPais, cTE, cMail, cWeb, cCuit, cIB, cSitIVA, cCred, cCons, cEst, cClas, cElim, cIdUs);
END