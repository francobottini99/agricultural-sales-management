CREATE DEFINER=`root`@`localhost` PROCEDURE `insDevolucionesMonedas`(
    in dmTic double,
    in dmImN double,
    in dmDsc double,
    in dmBim double,    
    in dmIva double,    
    in dmImT double,
    in dmElim varchar(2),
    in dmIdD int(11)
)
BEGIN
INSERT INTO DevolucionesMonedas (
		TipoCambio,
		ImporteNeto,
		DescuentoGral,
        BaseImponible,
        Iva,
        ImporteTotal,
		Eliminado,
        Devoluciones_idDevoluciones
)
	VALUES (dmTic, dmImN, dmDsc, dmBim, dmIva, dmImT, dmElim, dmIdD);
END