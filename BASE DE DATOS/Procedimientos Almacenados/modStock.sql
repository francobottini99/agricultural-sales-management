CREATE DEFINER=`root`@`localhost` PROCEDURE `modStock`(
	in idStk int(11),
    in stkF date,
	in stkMov varchar(100),
    in stkCan double,
    in stkElim varchar(2),
    in stkIdArt int(11),
    in stkIdDep int(11),    
    in stkIdUs int(11)
)
BEGIN
	UPDATE Stock
	SET 
		Fecha = stkF,
		Movimiento = stkMov,
		Cantidad = stkCan,
		Eliminado = stkElim,
        Articulos_idArticulos = stkIdArt,
        Depositos_idDepositos = stkIdDep,
        Usuarios_idUsuarios = stkIdUs
	WHERE 
		idStock = idStk;
END