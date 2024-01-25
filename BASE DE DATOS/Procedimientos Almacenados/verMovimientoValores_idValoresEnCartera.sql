CREATE DEFINER=`root`@`localhost` PROCEDURE `verMovimientoValores_idValoresEnCartera`(
    in mvIdVal int(11)
)
BEGIN
	SELECT
		*
	FROM
		MovimientoValores
	WHERE
		ValoresEnCartera_idValoresEnCartera = mvIdVal And Eliminado = "NO";
END