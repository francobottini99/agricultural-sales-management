CREATE DEFINER=`root`@`localhost` PROCEDURE `modEmpresa`(
	in ID int(11),
	in RS varchar(255),
    in Dir varchar(255),
    in Loc varchar(255),
    in Prov varchar(255),
    in CP varchar(255),
    in Pais varchar(255),
    in TE varchar(255),
    in Mail varchar(255),
    in Cuit varchar(255),
    in IB varchar(255),
    in InAct date,
    in PrefFac varchar(255),
    in Web varchar(255),
    in CondIva varchar(255),
    in Log mediumblob,
    in Us int(11)
)
BEGIN
	UPDATE Empresa
	SET 
		RazonSocial = RS,
        Direccion = Dir,
		Localidad = Loc,
		Provincia = Prov,
        CP = CP,
        Pais = Pais,
        TE = TE,
		Mail = Mail,
        CUIT = Cuit,
        IIBB = IB,
        InicioActividad = InAct,
        PrefijoFacturacion = PrefFac,
        Web = Web,
        CondicionIVA = CondIva,
        Logo = Log,
        Usuarios_idUsuarios = Us
	WHERE
		idEmpresa = ID;
END