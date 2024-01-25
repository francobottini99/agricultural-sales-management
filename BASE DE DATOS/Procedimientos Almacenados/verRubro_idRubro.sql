CREATE DEFINER=`root`@`localhost` PROCEDURE `verRubro_idRubro`(
	in rId int(11)
)
BEGIN
	SELECT
		*
	FROM
		Rubro
	WHERE
		idRubro = rId  And Eliminado = "NO";
END