CREATE DEFINER=`root`@`localhost` PROCEDURE `verSubRubro_idR`(
	in idR int(11)
)
BEGIN
	SELECT
		*
	FROM
		Subrubro
	WHERE
		Rubro_idRubro = idR And Eliminado = "NO";
END