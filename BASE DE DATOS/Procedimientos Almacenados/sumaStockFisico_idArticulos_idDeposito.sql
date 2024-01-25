CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaStockFisico_idArticulos_idDeposito`(
	in idArt int(11),
    in idDep int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as TotStock
	FROM
		Stock
	WHERE 
		Articulos_idArticulos = idArt AND Depositos_idDepositos = idDep AND (Movimiento = "INGRESO" OR Movimiento = "EGRESO") AND Eliminado = "NO";

END