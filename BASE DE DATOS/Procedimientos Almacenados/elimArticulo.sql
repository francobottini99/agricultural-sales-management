CREATE DEFINER=`root`@`localhost` PROCEDURE `elimArticulo`(
	in IdArt int(11)
)
BEGIN
	UPDATE Articulos
	SET 
		Eliminado = "SI"
	WHERE 
		idArticulos = IdArt;
END