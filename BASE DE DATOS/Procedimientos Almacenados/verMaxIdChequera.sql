CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdChequera`()
BEGIN
	SELECT
		Max(idChequera) as UltimoId
	FROM
		Chequera;
END