CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVenta`(
)
BEGIN
	SELECT
		FacturaVenta.*,
        Clientes.*
	FROM
		FacturaVenta JOIN Clientes ON FacturaVenta.Clientes_idClientes = Clientes.idClientes
	WHERE
		FacturaVenta.Eliminado = "NO";
END