CREATE DEFINER=`root`@`localhost` PROCEDURE `insRemitoCompra`(
    in rcNroComp varchar (100),
    in rcFec date,
    in rcImp double,
    in rcObs text,    
    in rcImpO int(11),    
    in rcImpC int(11),
    in rcElim varchar(2),
	in rcFac varchar(2),
    in rcIdProv int(11),
    in rcIdUs int(11)
)
BEGIN
INSERT INTO RemitosCompra (
		NroComprobante,
		Fecha,
		Importe,
        Observaciones,
        ImpOriginal,
        ImpCopia,
		Eliminado,
        Facturado,
        Proveedores_idProveedores,
        Usuarios_idUsuarios
)
	VALUES (rcNroComp, rcFec, rcImp, rcObs, rcImpO, rcImpC, rcElim, rcFac, rcIdProv, rcIdUs);
END