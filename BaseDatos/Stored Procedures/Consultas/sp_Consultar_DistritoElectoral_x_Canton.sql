-- EXEC sp_Consultar_DistritoElectoral_x_Canton '3', '04'
CREATE OR ALTER PROC sp_Consultar_DistritoElectoral_x_Canton
(
@CodigoProvincia varchar(1),
@CodigoCanton varchar(2)
)
AS
BEGIN
	SELECT a.Codele as 'Código Electoral', b.Descripcion as Provincia, c.Descripcion as 'Cantón', d.Descripcion as 'Distrito'
	FROM DistritosElectorales a
	JOIN Provincias b on a.CodigoProvincia = b.CodigoProvincia
	JOIN Cantones c on a.CodigoProvincia = c.CodigoProvincia and a.CodigoCanton = c.CodigoCanton
	JOIN Distritos d on a.CodigoProvincia = d.CodigoProvincia and a.CodigoCanton = d.CodigoCanton and a.CodigoDistrito = d.CodigoDistrito
	WHERE a.CodigoProvincia = @CodigoProvincia and a.CodigoCanton = @CodigoCanton
	ORDER BY a.CodigoProvincia ASC, a.CodigoCanton  ASC, a.CodigoDistrito ASC
END