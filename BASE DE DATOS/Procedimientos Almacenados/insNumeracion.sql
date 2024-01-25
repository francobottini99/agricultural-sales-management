CREATE DEFINER=`root`@`localhost` PROCEDURE `insNumeracion`(
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
INSERT INTO Numeracion (
		PuntoVenta,
		Descripcion,
        NroReserva,
        NroRemito,
        NroDevolucion,
        NroFacturaA,
        NroFacturaB,
        NroFacturaC,
        NroFacturaX,
        NroNotaCreditoA,
        NroNotaCreditoB,
        NroNotaCreditoC,
        NroNotaCreditoX,
        NroNotaDebitoA,
        NroNotaDebitoB,
        NroNotaDebitoC,
        NroNotaDebitoX,
        NroRecibo,
        NroOrdenCompra,
		Eliminado,
        Usuarios_idUsuarios
)
	VALUES (nPtoVta, nDes, nRes, nRem, nDev, nFacA, nFacB, nFacC, nFacX, nNCA, nNCB, nNCC, nNCX, nNDA, nNDB, nNDC, nNDX, nRec, nOrdCom, nEli, nIdUs);
END