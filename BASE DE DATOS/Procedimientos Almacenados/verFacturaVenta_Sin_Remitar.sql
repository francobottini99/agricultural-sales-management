CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVenta_Sin_Remitar`(
)
BEGIN
	SELECT
		FacturaVenta.*,
        Clientes.*
	FROM
		FacturaVenta JOIN Clientes ON FacturaVenta.Clientes_idClientes = Clientes.idClientes
	WHERE
		FacturaVenta.Remitado = "NO" AND FacturaVenta.Eliminado = "NO";
END