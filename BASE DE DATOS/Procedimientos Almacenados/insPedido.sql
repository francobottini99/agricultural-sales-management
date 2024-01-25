CREATE DEFINER=`root`@`localhost` PROCEDURE `insPedido`(
	in pdNro varchar(100),
	in pdFecha date,
    in pdFecCierr date,  
	in pdRemi varchar(2),
	in pdFact varchar(2),
    in pdObs text,
    in pdElim varchar(2),
    in pdIdUs int(11),
    in pdIdCli int(11)
)
BEGIN
INSERT INTO Pedidos (
		NroPedido,
		Fecha,
        FechaCierrePedido,
        Remitado,
        Facturado,
        Observaciones,
		Eliminado,
        Usuarios_idUsuarios,
        Clientes_idClientes
)
	VALUES (pdNro, pdFecha, pdFecCierr, pdRemi, pdFact, pdObs, pdElim, pdIdUs, pdIdCli);
END