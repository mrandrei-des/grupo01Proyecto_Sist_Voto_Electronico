-- PROCEDIMIENTO ALMACENADO QUE CONSULTA Y CONSTRUYE LA CANTIDAD DE VOTOS OBTENIDOS EN LA PROVINCIA INDICADA, ESTO PARA LAS VOTACIONES PRESIDENCIALES
-- EXEC sp_Reporte_Resultados_Presidente_x_Provincia '3'
CREATE OR ALTER PROC sp_Reporte_Resultados_Presidente_x_Provincia
(
@CodProvincia varchar(1)
)
AS
BEGIN
	--SELECT a.PartidoVotado as CodigoPartido, d.Descripcion as 'NombrePartido', COUNT(*) as CantVotos
	--FROM VotosRecibidos_Presidente a, DistritosElectorales b, Provincias c, PartidosPoliticos d
	--WHERE a.Codelec = b.Codele and b.CodigoProvincia = c.CodigoProvincia and a.PartidoVotado = d.CodigoPartido 
	--and c.CodigoProvincia = @CodProvincia
	--GROUP BY a.PartidoVotado, d.Descripcion
	--ORDER BY COUNT(*) DESC, d.Descripcion ASC

	SELECT p.CodigoPartido, p.Descripcion as 'NombrePartido', COALESCE(c.Cantidad, 0) as CantVotos
	FROM PartidosPoliticos p
	LEFT JOIN (
		SELECT a.PartidoVotado as CodigoPartido, COUNT(*) as Cantidad
		FROM VotosRecibidos_Presidente a
		WHERE LEFT(a.Codelec, 1) = @CodProvincia
		GROUP BY a.PartidoVotado
	) c on p.CodigoPartido = c.CodigoPartido
	ORDER BY COALESCE(c.Cantidad, 0) DESC, p.Descripcion ASC
END