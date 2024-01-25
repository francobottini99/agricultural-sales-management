CREATE DEFINER=`root`@`localhost` PROCEDURE `insRecibosVentaMonedas`(
	in rvmTpc double,
	in rvmImN double,
    in rvmDes double,  
	in rvmBas double,
	in rvmIva double,
    in rvmImT double,
    in rvmEli varchar(2),
    in rvmIdRv int(11)
)
BEGIN
INSERT INTO RecibosVentaMonedas (
		TipoCambio,
		ImporteNeto,
        DescuentoGral,
        BaseImponible,
        Iva,
        ImporteTotal,
        Eliminado,
		RecibosVenta_idRecibosVenta
)
	VALUES (rvmTpc, rvmImN, rvmDes, rvmBas, rvmIva, rvmImT, rvmEli, rvmIdRv);
END