CREATE DEFINER=`root`@`localhost` PROCEDURE `insProveedor`(
	in pFecha date,
    in pRazSoc varchar (255),
    in pDir varchar(255),
    in pLoc varchar (255),
    in pProv varchar (255),    
    in pCP varchar (45),    
    in pPais varchar (255),
    in pTE varchar (255),
    in pMail varchar (255), 
    in pWeb varchar(255),
    in pCuit varchar (13),
    in pIB varchar (45),
    in pSitIVA varchar (100),
    in pEst varchar (45),
    in pElim varchar(2),
    in pIdUs int(11)
)
BEGIN
INSERT INTO Proveedores (
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
        Estado,
        Eliminado,
        Usuarios_idUsuarios
)
	VALUES (pFecha, pRazSoc, pDir, pLoc, pProv, pCP, pPais, pTE, pMail, pWeb, pCuit, pIB, pSitIVA, pEst, pElim, pIdUs);
END