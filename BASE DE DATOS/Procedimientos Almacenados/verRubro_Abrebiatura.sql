CREATE DEFINER=`root`@`localhost` PROCEDURE `verRubro_Abrebiatura`(
	in rAb varchar(4)
)
BEGIN
	SELECT
		*
	FROM
		Rubro
	WHERE
		Abrebiatura = rAb  And Eliminado = "NO";
END