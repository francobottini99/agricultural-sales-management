CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaValoresEnCartera_Dolares`(
)
BEGIN
	SELECT
		Sum(Importe) as Saldo
	FROM
		ValoresEnCartera
	WHERE 
		Moneda = "DOLAR" AND Disponible = "SI" AND Eliminado = "NO";
END