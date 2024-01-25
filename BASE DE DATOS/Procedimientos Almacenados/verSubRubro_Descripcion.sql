CREATE DEFINER=`root`@`localhost` PROCEDURE `verSubRubro_Descripcion`(
	in srDes varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Subrubro
	WHERE
		Descripcion = srDes  And Eliminado = "NO";
END