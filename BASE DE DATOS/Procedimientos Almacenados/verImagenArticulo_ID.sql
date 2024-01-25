CREATE DEFINER=`root`@`localhost` PROCEDURE `verImagenArticulo_ID`(
	in IdArt int(11)
)
BEGIN
	SELECT
        Articulos.Imagen
	FROM
        Articulos
	WHERE
		Eliminado = "NO" And idArticulos = IdArt;
END