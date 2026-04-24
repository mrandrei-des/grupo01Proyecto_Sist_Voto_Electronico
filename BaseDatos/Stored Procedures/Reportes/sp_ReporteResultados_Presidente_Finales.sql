-- EXEC sp_ReporteResultados_Presidente_Finales
CREATE OR ALTER PROC sp_ReporteResultados_Presidente_Finales
AS
BEGIN
	SELECT PartidoVotado, COUNT(*) AS CantVotos 
	FROM VotosRecibidos_Presidente a, PartidosPoliticos b
	WHERE a.PartidoVotado = b.CodigoPartido
	GROUP BY PartidoVotado, b.Descripcion
	ORDER BY CantVotos DESC, b.Descripcion ASC
END