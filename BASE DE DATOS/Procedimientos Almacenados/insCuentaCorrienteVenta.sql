CREATE DEFINER=`root`@`localhost` PROCEDURE `insCuentaCorrienteVenta`(
    in ccvFec date,
	in ccvVto date,
    in ccvCom varchar(150),
    in ccvNum varchar(100),
    in ccvDet varchar(255),    
    in ccvDeb double,    
    in ccvCre double,
    in ccvEli varchar(2),
	in ccvVis varchar(2),
	in ccvIdCli int(11),
    in ccvIdUs int(11)
)
BEGIN
INSERT INTO CuentaCorrienteVentas (
		Fecha,
        FechaVto,
		Comprobante,
		Numero,
        Detalle,
        Debito,
        Credito,
        Eliminado,
        `Visible`,
        Clientes_idClientes,
        Usuarios_idUsuarios
)
	VALUES (ccvFec, ccvVto, ccvCom, ccvNum, ccvDet, ccvDeb, ccvCre, ccvEli, ccvVis, ccvIdCli, ccvIdUs);
END