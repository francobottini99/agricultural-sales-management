CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdOrdenDePago`()
BEGIN
	SELECT
		Max(idOrdenDePago) as UltimoId
	FROM
		OrdenDePago;
END