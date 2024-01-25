CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaCaja_Pesos`(
)
BEGIN
	SELECT
		Sum(Ingreso) - Sum(Egreso) as Saldo
	FROM
		Caja
	WHERE 
		Moneda = "PESO" AND Eliminado = "NO";
END