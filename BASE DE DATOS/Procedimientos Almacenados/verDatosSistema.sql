CREATE DEFINER=`root`@`localhost` PROCEDURE `verDatosSistema`()
BEGIN
	SELECT
		*
	FROM
		DatosSistema;
END