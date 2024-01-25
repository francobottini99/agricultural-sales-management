CREATE DEFINER=`root`@`localhost` PROCEDURE `insEmpresa`(
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
INSERT INTO Empresa (
		RazonSocial,
        Direccion,
		Localidad,
		Provincia,
        CP,
        Pais,
        TE,
		Mail,
        CUIT,
        IIBB,
        InicioActividad,
        PrefijoFacturacion,
        Web,
        CondicionIVA,
        Logo,
        Usuarios_idUsuarios
)
	VALUES (RS, Dir, Loc, Prov, CP, Pais, TE, Mail, Cuit, IB, InAct, PrefFac, Web, CondIva, Log, Us);
END