CREATE DEFINER=`root`@`localhost` PROCEDURE `verRubro_Descripcion`(
	in rDes varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Rubro
	WHERE
		Descripcion = rDes  And Eliminado = "NO";
END