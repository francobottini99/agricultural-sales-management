CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdArticulos`()
BEGIN
	SELECT
		Max(idArticulos) as UltimoId
	FROM
		Articulos;
END