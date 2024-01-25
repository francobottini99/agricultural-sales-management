CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdValoresEnCartera`()
BEGIN
	SELECT
		Max(idValoresEnCartera) as UltimoId
	FROM
		ValoresEnCartera;
END