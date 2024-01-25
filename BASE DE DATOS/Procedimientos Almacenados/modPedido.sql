CREATE DEFINER=`root`@`localhost` PROCEDURE `modPedido`(
	in pdId int(11),
    in pdNro varchar(100),
    in pdFec date,
    in pdFecCierre date,
	in pdRemi varchar(2),
	in pdFact varchar(2),
    in pdObs varchar (255),
    in pdElim varchar (2),
    in pdIsUs int(11),
    in pdIdCli int(11)
)
BEGIN
	UPDATE Pedidos
	SET 
		NroPedido = pdNro,
		Fecha = pdFec,
        FechaCierrePedido = pdFecCierre,
		Remitado = pdRemi,
        Facturado = pdFact,
        Observaciones = pdObs,
        Eliminado = pdElim,
        Usuarios_idUsuarios = pdIsUs,
        Clientes_idClientes = pdIdCli
	WHERE 
		idPedidos = pdId;
END