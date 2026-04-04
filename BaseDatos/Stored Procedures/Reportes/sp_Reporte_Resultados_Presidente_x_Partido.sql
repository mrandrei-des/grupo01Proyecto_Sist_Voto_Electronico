-- PROCEDIMIENTO ALMACENADO QUE CONSULTA Y CONSTRUYE LA CANTIDAD DE VOTOS POR PROVINCIA QUE HA TENIDO EL PARTIDO POLÍTICO INDICADO, ESTO PARA LAS VOTACIONES PARA PRESIDENTE
-- EXEC sp_Reporte_Presidente_x_Provincia 'PUSC'
CREATE PROC sp_Reporte_Resultados_Presidente_x_Partido
(
@CodPartido varchar(6)
)
AS
BEGIN
	SELECT c.CodigoProvincia, c.Descripcion as Provincia, COUNT(*) AS CantVotos
	FROM VotosEmitidos a, DistritosElectorales b, Provincias c 
	WHERE a.Codele = b.Codele and b.CodigoProvincia = c.CodigoProvincia and
	a.IdTipoEleccion = 1 and a.CodigoPartido = @CodPartido	
	GROUP BY c.CodigoProvincia, c.Descripcion
	ORDER BY c.CodigoProvincia ASC
END