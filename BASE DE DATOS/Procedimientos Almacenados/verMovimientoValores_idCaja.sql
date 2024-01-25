CREATE DEFINER=`root`@`localhost` PROCEDURE `verMovimientoValores_idCaja`(
    in mvIdCaj int(11)
)
BEGIN
	SELECT
		*
	FROM
		MovimientoValores
	WHERE
		Caja_idCaja = mvIdCaj And Eliminado = "NO";
END