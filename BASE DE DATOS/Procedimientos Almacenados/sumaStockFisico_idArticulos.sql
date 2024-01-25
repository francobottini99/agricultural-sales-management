CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaStockFisico_idArticulos`(
	in idArt int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as TotStock
	FROM
		Stock
	WHERE 
		Articulos_idArticulos = idArt AND (Movimiento = "INGRESO" OR Movimiento = "EGRESO") AND Eliminado = "NO";

END