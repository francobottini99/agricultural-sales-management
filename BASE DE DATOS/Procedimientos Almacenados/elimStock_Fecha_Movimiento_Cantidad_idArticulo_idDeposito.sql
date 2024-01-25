CREATE DEFINER=`root`@`localhost` PROCEDURE `elimStock_Fecha_Movimiento_Cantidad_idArticulo_idDeposito`(
	in stkFec date,
    in stkMov varchar(100),
    in stkCan double,
    in stkIdArt int(11),
    in stkIdDep int(11)
)
BEGIN
	UPDATE Stock
	SET 
		Eliminado = "SI"
	WHERE 
		Fecha = stkFec AND Movimiento = stkMov AND Cantidad = stkCan AND Articulos_idArticulos = stkIdArt AND Depositos_idDepositos = stkIdDep;
END