CREATE DEFINER=`root`@`localhost` PROCEDURE `modRemitoCompra`(
	in rcID int(11),
    in rcComp varchar(100),
	in rcFec date,
    in rcImp double,
    in rcObs varchar (255),
    in rcImOr int(11),
    in rcImCop int(11),    
    in rcElim varchar(2), 
	in rcFac varchar(2),
    in rcIdProv int(11),
    in rcIdUs int(11)
)
BEGIN
	UPDATE RemitosCompra
	SET 
		NroComprobante = rcComp,
		Fecha = rcFec,
		Importe = rcImp,
		Observaciones = rcObs,
        ImpOriginal = rcImOr,
        ImpCopia = rcImCop,
        Eliminado = rcElim,
        Facturado = rcFac,
		Proveedores_idProveedores = rcIdProv,
        Usuarios_idUsuarios = rcIdUs
	WHERE 
		idRemitosCompra = rcID;
END