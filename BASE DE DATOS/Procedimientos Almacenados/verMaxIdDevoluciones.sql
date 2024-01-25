CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdDevoluciones`()
BEGIN
	SELECT
		Max(idDevoluciones) as UltimoId
	FROM
		Devoluciones;
END