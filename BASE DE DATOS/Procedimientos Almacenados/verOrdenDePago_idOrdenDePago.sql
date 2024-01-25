CREATE DEFINER=`root`@`localhost` PROCEDURE `verOrdenDePago_idOrdenDePago`(
	in id int(11)
)
BEGIN
	SELECT
		*
	FROM
		OrdenDePago
	WHERE
		Eliminado = "NO" AND idOrdenDePago = id;
END