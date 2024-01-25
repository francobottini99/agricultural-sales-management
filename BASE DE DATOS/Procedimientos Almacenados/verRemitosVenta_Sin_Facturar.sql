CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitosVenta_Sin_Facturar`(
)
BEGIN
	SELECT
		RemitosVenta.*,
        Usuarios.*,
        Clientes.*
	FROM
		RemitosVenta JOIN Usuarios ON RemitosVenta.Usuarios_idUsuarios = Usuarios.idUsuarios
        JOIN Clientes ON RemitosVenta.Clientes_idClientes = Clientes.idClientes
	WHERE
		RemitosVenta.Eliminado = "NO" AND RemitosVenta.Facturado = "NO";
END