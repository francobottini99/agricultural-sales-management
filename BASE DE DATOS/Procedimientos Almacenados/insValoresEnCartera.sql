CREATE DEFINER=`root`@`localhost` PROCEDURE `insValoresEnCartera`(
	in vecTip varchar(255),
    in vecBan varchar(255),
	in vecSuc varchar(255),
	in vecNum varchar(45),
    in vecLib varchar(255),
    in vecFecC date,
	in vecMon varchar(45),
	in vecImp double,
	in vecDisp varchar(2),   
    in vecEli varchar(2), 
    in vecIdUs int(11)
)
BEGIN
INSERT INTO ValoresEnCartera (
		TipoValor,
        Banco,
        Sucursal,
        Numero,
        Librador,
        FechaCobro,
        Moneda,
        Importe,
        Disponible,
		Eliminado,
        Usuarios_idUsuarios
)
	VALUES (vecTip, vecBan, vecSuc, vecNum, vecLib, vecFecC, vecMon, vecImp, vecDisp, vecEli, vecIdUs);
END