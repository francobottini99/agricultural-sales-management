CREATE DEFINER=`root`@`localhost` PROCEDURE `verCaja_FecDesde_FecHasta`(
	in cFecD date,
    in cFecH date
)
BEGIN
	SELECT
		*
	FROM
		Caja
	WHERE
		Fecha >= cFecD And Fecha <= cFecH And Eliminado = "NO"
	ORDER BY Fecha ASC;
END