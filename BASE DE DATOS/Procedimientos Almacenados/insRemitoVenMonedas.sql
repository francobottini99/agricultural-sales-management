CREATE DEFINER=`root`@`localhost` PROCEDURE `insRemitoVenMonedas`(
    in rvmTic double,
    in rvmImN double,
    in rvmDsc double,
    in rvmBim double,    
    in rvmIva double,    
    in rvmImT double,
    in rvmElim varchar(2),
    in rvmIdRv int(11)
)
BEGIN
INSERT INTO RemitoVtaMonedas (
		TipoCambio,
		ImporteNeto,
		DescuentoGral,
        BaseImponible,
        Iva,
        ImporteTotal,
		Eliminado,
        RemitosVenta_idRemitosVenta
)
	VALUES (rvmTic, rvmImN, rvmDsc, rvmBim, rvmIva, rvmImT, rvmElim, rvmIdRv);
END