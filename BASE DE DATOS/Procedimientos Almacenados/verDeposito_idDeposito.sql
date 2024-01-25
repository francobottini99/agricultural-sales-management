CREATE DEFINER=`root`@`localhost` PROCEDURE `verDeposito_idDeposito`(
	in dId int(11)
)
BEGIN
	SELECT
		*
	FROM
		Depositos
	WHERE
		idDepositos = dId  And Eliminado = "NO";
END