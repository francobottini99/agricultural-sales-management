CREATE DEFINER=`root`@`localhost` PROCEDURE `verSubRubro_idSubRubro`(
	in subrubId int(11)
)
BEGIN
	SELECT
		*
	FROM
		SubRubro
	WHERE
		idSubRubro = subrubId  And Eliminado = "NO";
END