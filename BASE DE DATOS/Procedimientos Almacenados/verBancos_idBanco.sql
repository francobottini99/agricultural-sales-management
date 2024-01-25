CREATE DEFINER=`root`@`localhost` PROCEDURE `verBancos_idBanco`(
	in bId int(11)
)
BEGIN
	SELECT
		*
	FROM
		Bancos
	WHERE
		idBancos = bId  And Eliminado = "NO";
END