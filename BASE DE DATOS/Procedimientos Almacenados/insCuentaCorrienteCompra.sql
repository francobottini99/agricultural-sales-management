CREATE DEFINER=`root`@`localhost` PROCEDURE `insCuentaCorrienteCompra`(
    in cccFec date,
	in cccVto date,
    in cccCom varchar(150),
    in cccNum varchar(100),
    in cccDet varchar(255),    
    in cccDeb double,    
    in cccCre double,
    in cccEli varchar(2),
    in cccVis varchar(2),
	in cccIdProv int(11),
    in cccIdUs int(11)
)
BEGIN
INSERT INTO CuentaCorrienteCompra (
		Fecha,
        FechaVto,
		Comprobante,
		Numero,
        Detalle,
        Debito,
        Credito,
        Eliminado,
        Visible,
        Proveedores_idProveedores,
        Usuarios_idUsuarios
)
	VALUES (cccFec, cccVto, cccCom, cccNum, cccDet, cccDeb, cccCre, cccEli, cccVis, cccIdProv, cccIdUs);
END