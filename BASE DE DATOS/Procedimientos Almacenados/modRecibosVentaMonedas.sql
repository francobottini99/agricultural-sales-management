CREATE DEFINER=`root`@`localhost` PROCEDURE `modRecibosVentaMonedas`(
	in rvmId int(11),
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
	UPDATE RecibosVentaMonedas
	SET 
		TipoCambio = rvmTpc,
		ImporteNeto = rvmImN,
        DescuentoGral = rvmDes,
        BaseImponible = rvmBas,
        Iva = rvmIva,
        ImporteTotal = rvmImT,
        Eliminado = rvmEli,
		RecibosVenta_idRecibosVenta = rvmIdRv
	WHERE 
		idRecibosVentaMonedas = rvmId;
END