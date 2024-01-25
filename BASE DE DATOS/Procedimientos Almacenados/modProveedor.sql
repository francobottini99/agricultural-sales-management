CREATE DEFINER=`root`@`localhost` PROCEDURE `modProveedor`(
	in idP int(11),
    in pFec date,
    in pRS varchar (255),
    in pDir varchar(255),
    in pLoc varchar (255),
    in pProv varchar (255),
    in pCP varchar (45),
    in pPais varchar (255),
    in pTE varchar (255),
    in pMail varchar (255),
    in pWeb varchar (255),
	in pCUIT varchar (13),
	in pIB varchar (45),
	in pSIva varchar (100)
)
BEGIN
	UPDATE Proveedores
	SET 
		FechaAlta = pFec,
		RazonSocial = pRS,
		Direccion = pDir,
        Localidad = pLoc,
        Provincia = pProv,
        CP = pCP,
        Pais = pPais,
        TE = pTE,
        Mail = pMail,
        Web = pWeb,
        CUIT = pCUIT,
        IIBB = pIB,
        SituacionIVA = pSIva
	WHERE 
		idProveedores = idP;
END