-- PROCEDIMIENTO ALMACENADO QUE CONSULTA Y CONSTRUYE LA CANTIDAD DE VOTOS POR PROVINCIA QUE HA TENIDO EL PARTIDO POLÍTICO INDICADO, ESTO PARA LAS VOTACIONES PARA PRESIDENTE
-- EXEC sp_Reporte_Resultados_Presidente_x_Partido 'blanco'
CREATE OR ALTER PROC sp_Reporte_Resultados_Presidente_x_Partido
(
@CodPartido varchar(6)
)
AS
BEGIN
	--SELECT c.CodigoProvincia, c.Descripcion as Provincia, COUNT(*) AS CantVotos
	--FROM VotosRecibidos_Presidente a, DistritosElectorales b, Provincias c 
	--WHERE a.Codelec = b.Codele and b.CodigoProvincia = c.CodigoProvincia 
	--and a.PartidoVotado = @CodPartido	
	--GROUP BY c.CodigoProvincia, c.Descripcion
	--ORDER BY c.CodigoProvincia ASC
	SELECT p.CodigoProvincia, p.Descripcion, COALESCE(v.CantidadVotos, 0) AS CantVotos 
	FROM Provincias p
	LEFT JOIN (
		SELECT a.PartidoVotado, LEFT(a.Codelec, 1) AS CodProvincia, COUNT(*) AS CantidadVotos
		FROM VotosRecibidos_Presidente a
		WHERE a.PartidoVotado = @CodPartido
		GROUP BY a.PartidoVotado, LEFT(a.Codelec, 1)
	) v on p.CodigoProvincia = v.CodProvincia
	ORDER BY COALESCE(v.CantidadVotos, 0) DESC, p.CodigoProvincia ASC
END