CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaCaja_Dolares`(
)
BEGIN
	SELECT
		0 + Sum(Ingreso) - Sum(Egreso) as Saldo
	FROM
		Caja
	WHERE 
		Moneda = "DOLAR" AND Eliminado = "NO";
END