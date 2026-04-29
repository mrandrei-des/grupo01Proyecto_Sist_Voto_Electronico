
-- EXEC sp_Estadisticas_Resultados_Presidente_x_Candidato 'BLANCO'
CREATE OR ALTER PROC sp_Estadisticas_Resultados_Presidente_x_Candidato
(
@CodigoPartidoSeleccionado varchar(6)
)
AS
BEGIN
	DECLARE @CantVotosPartidoSeleccionado INT
	DECLARE @CantVotosPartidos INT

	SET @CantVotosPartidoSeleccionado = (
		SELECT COUNT(*) AS VotosPartidoSeleccionado
		FROM VotosRecibidos_Presidente
		WHERE PartidoVotado = @CodigoPartidoSeleccionado
	)

	SET @CantVotosPartidos = (
		SELECT COUNT(*) AS VotosPartidosNoSeleccionado
		FROM VotosRecibidos_Presidente
		WHERE PartidoVotado <> @CodigoPartidoSeleccionado
	);

	with cte_Resultados AS (
		SELECT 
		UPPER(@CodigoPartidoSeleccionado) AS CodPartido,
		@CantVotosPartidoSeleccionado AS CantVotosPartido

		UNION

		SELECT 
		'OTR' AS CodPartido,
		@CantVotosPartidos AS CantVotosPartido
	)

	SELECT COALESCE(b.Descripcion, 'Otros Partidos') as NombrePartido, a.* 
	FROM cte_Resultados a
	LEFT JOIN PartidosPoliticos b on a.CodPartido = b.CodigoPartido
END