CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaValoresEnCartera_Pesos`(
)
BEGIN
	SELECT
		Sum(Importe) as Saldo
	FROM
		ValoresEnCartera
	WHERE 
		Moneda = "PESO" AND Disponible = "SI" AND Eliminado = "NO";
END