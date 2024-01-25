CREATE DEFINER=`root`@`localhost` PROCEDURE `verChequera_NroChq`(
	in nroChq int(11)
)
BEGIN
	SELECT
		*
	FROM
		Chequera
	WHERE
		NroChqInicial = nroChq  And Eliminada = "NO";
END