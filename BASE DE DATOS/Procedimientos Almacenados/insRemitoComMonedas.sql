CREATE DEFINER=`root`@`localhost` PROCEDURE `insRemitoComMonedas`(
    in rcmTic double,
    in rcmImN double,
    in rcmDsc double,
    in rcmBim double,    
    in rcmIva double,    
    in rcmImT double,
    in rcmElim varchar(2),
    in rcmIdRc int(11)
)
BEGIN
INSERT INTO RemitoComMonedas (
		TipoCambio,
		ImporteNeto,
		DescuentoGral,
        BaseImponible,
        Iva,
        ImporteTotal,
		Eliminado,
        RemitosCompra_idRemitosCompra
)
	VALUES (rcmTic, rcmImN, rcmDsc, rcmBim, rcmIva, rcmImT, rcmElim, rcmIdRc);
END