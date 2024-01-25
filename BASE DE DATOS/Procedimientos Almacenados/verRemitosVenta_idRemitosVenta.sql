CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitosVenta_idRemitosVenta`(
	in idRv int(11)
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
		RemitosVenta.idRemitosVenta = idRv;
END