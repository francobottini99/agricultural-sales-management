CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion`(
	in nId int(11),
	in nPtoVta int(11),
	in nDes varchar(255),
    in nRes int(11),
    in nRem int(11),
	in nDev int(11),
    in nFacA int(11),
    in nFacB int(11),
    in nFacC int(11),
    in nFacX int(11),
    in nNCA int(11),
    in nNCB int(11),
    in nNCC int(11),
    in nNCX int(11),
    in nNDA int(11),
    in nNDB int(11),
    in nNDC int(11),
    in nNDX int(11),
    in nRec int(11),
    in nOrdCom int(11),
    in nEli varchar(2),
    in nIdUs int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
		PuntoVenta = nPtoVta,
		Descripcion = nDes,
        NroReserva = nRes,
        NroRemito = nRem,
        NroDevolucion = nDev,
        NroFacturaA = nFacA,
        NroFacturaB = nFacB,
        NroFacturaC = nFacC,
        NroFacturaX = nFacX,
        NroNotaCreditoA = nNCA,
        NroNotaCreditoB = nNCB,
        NroNotaCreditoC = nNCC,
        NroNotaCreditoX = nNCX,
        NroNotaDebitoA = nNDA,
        NroNotaDebitoB = nNDB,
        NroNotaDebitoC = nNDC,
        NroNotaDebitoX = nNDX,
        NroRecibo = nRec,
        NroOrdenCompra = nOrdCom,
		Eliminado = nEli,
        Usuarios_idUsuarios = nIdUs
	WHERE 
		idNumeracion = nId;
END