CREATE DEFINER=`root`@`localhost` PROCEDURE `verArticulo_idArticulo`(
	in IdArt int(11)
)
BEGIN
	SELECT
		Articulos.idArticulos,
        Articulos.CodArticulo,
        Articulos.Detalle,
        Articulos.Unidad,
        Articulos.Costo,
        Articulos.FechaActualizacionCosto,
        Articulos.Precio,
        Articulos.FechaActualizacionPrecio,
        Articulos.AlicuotaIVA,
        Articulos.StockMinimo,
        Articulos.Observaciones,
        Articulos.Eliminado,
        Articulos.Usuarios_idUsuarios,
        Articulos.Rubro_idRubro,
        Articulos.SubRubro_idSubRubro,
        Articulos.Imagen,
        Usuarios.Nombre,
        Rubro.Abrebiatura RubroAbreviatura,
        Rubro.Descripcion RubDescripcion,
        Subrubro.Abrebiatura SubRubAbreviatura,
        Subrubro.Descripcion SubRubDescripcion
	FROM
        Articulos 
        JOIN Usuarios ON Articulos.Usuarios_idUsuarios = Usuarios.idUsuarios
        JOIN Subrubro ON Articulos.SubRubro_idSubRubro = Subrubro.idSubRubro
        JOIN Rubro ON Articulos.Rubro_idRubro = Rubro.idRubro
	WHERE
		idArticulos = IdArt;
END