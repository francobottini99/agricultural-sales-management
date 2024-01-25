CREATE DEFINER=`root`@`localhost` PROCEDURE `verOrdenPagoDetalle`(
)
BEGIN
	SELECT
		*
	FROM
		OrdenPagoDetalle
	WHERE
		Eliminado = "NO";
END
