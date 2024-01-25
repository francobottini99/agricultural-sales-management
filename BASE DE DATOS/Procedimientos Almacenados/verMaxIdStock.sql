CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdStock`()
BEGIN
	SELECT
		Max(idStock) as UltimoId
	FROM
		Stock;
END