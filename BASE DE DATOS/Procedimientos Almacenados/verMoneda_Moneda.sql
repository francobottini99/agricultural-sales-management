CREATE DEFINER=`root`@`localhost` PROCEDURE `verMoneda_Moneda`(
	in mMoneda varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Monedas
	WHERE
		Moneda = mMoneda  And Eliminado = "NO";
END