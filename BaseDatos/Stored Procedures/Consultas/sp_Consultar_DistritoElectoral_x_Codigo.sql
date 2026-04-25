-- EXEC sp_Consultar_DistritoElectoral_x_Codigo '104028'
CREATE OR ALTER PROC sp_Consultar_DistritoElectoral_x_Codigo
(
@CodigoElectoral varchar(6)
)
AS
BEGIN
	SELECT a.Codele as 'Código Electoral', b.Descripcion as Provincia, c.Descripcion as 'Cantón', d.Descripcion as 'Distrito'
	FROM DistritosElectorales a
	JOIN Provincias b on a.CodigoProvincia = b.CodigoProvincia
	JOIN Cantones c on a.CodigoProvincia = c.CodigoProvincia and a.CodigoCanton = c.CodigoCanton
	JOIN Distritos d on a.CodigoProvincia = d.CodigoProvincia and a.CodigoCanton = d.CodigoCanton and a.CodigoDistrito = d.CodigoDistrito
	WHERE a.Codele = @CodigoElectoral
	ORDER BY a.Codele ASC
END