CREATE DEFINER=`root`@`localhost` PROCEDURE `verSubRubro_Abrebiatura`(
	in srAb varchar(4)
)
BEGIN
	SELECT
		*
	FROM
		Subrubro
	WHERE
		Abrebiatura = srAb  And Eliminado = "NO";
END