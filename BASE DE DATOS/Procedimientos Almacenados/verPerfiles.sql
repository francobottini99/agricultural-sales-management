CREATE DEFINER=`root`@`localhost` PROCEDURE `verPerfiles`(
)
BEGIN
	SELECT
		*
	FROM
		Perfilesusuario
	WHERE
		Eliminar = "NO";
END