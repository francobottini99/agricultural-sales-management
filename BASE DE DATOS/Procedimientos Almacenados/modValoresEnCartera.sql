CREATE DEFINER=`root`@`localhost` PROCEDURE `modValoresEnCartera`(
	in vecIdV int(11),
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
	UPDATE ValoresEnCartera
	SET 
        TipoValor = vecTip,
        Banco = vecBan,
        Sucursal = vecSuc,
        Numero = vecNum,
		Librador = vecLib,
		FechaCobro = vecFecC,
        Importe = vecImp,
        Moneda = vecMon,
        Disponible = vecDisp,
        Eliminado = vecEli,
		Usuarios_idUsuarios = vecIdUs
	WHERE 
		idValoresEnCartera = vecIdV;
END