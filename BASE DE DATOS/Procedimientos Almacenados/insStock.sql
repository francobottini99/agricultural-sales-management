CREATE DEFINER=`root`@`localhost` PROCEDURE `insStock`(
    in sFec date,
    in sMov varchar(100),
    in sCan double,
    in sEli varchar(2),
    in sIdA int(11),
    in sIdD int(11),
    in sIdU int(11)
)
BEGIN
INSERT INTO Stock (
		Fecha,
		Movimiento,
		Cantidad,
        Eliminado,
        Articulos_idArticulos,
        Depositos_idDepositos,
		Usuarios_idUsuarios
)
	VALUES (sFec, sMov, sCan, sEli, sIdA, sIdD, sIdU);
END