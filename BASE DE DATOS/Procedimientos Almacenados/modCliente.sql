CREATE DEFINER=`root`@`localhost` PROCEDURE `modCliente`(
	in idC int(11),
    in cFec date,
    in cRS varchar (255),
    in cDir varchar(255),
    in cLoc varchar (255),
    in cProv varchar (255),
    in cCP varchar (45),
    in cPais varchar (255),
    in cTE varchar (255),
    in cMail varchar (255),
    in cWeb varchar (255),
	in cCUIT varchar (13),
	in cIB varchar (45),
	in cSIva varchar (100),
	in cCred double,
	in cClas varchar (100)
)
BEGIN
	UPDATE Clientes
	SET 
		FechaAlta = cFec,
		RazonSocial = cRS,
		Direccion = cDir,
        Localidad = cLoc,
        Provincia = cProv,
        CP = cCP,
        Pais = cPais,
        TE = cTE,
        Mail = cMail,
        Web = cWeb,
        CUIT = cCUIT,
        IIBB = cIB,
        SituacionIVA = cSIva,
        CreditoAsignado = cCred,
        Clasificacion = cClas
	WHERE 
		idClientes = idC;
END