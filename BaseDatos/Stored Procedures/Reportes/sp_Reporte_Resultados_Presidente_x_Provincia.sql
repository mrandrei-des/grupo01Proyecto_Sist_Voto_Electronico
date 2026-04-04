-- PROCEDIMIENTO ALMACENADO QUE CONSULTA Y CONSTRUYE LA CANTIDAD DE VOTOS OBTENIDOS EN LA PROVINCIA INDICADA, ESTO PARA LAS VOTACIONES PRESIDENCIALES
-- EXEC sp_Reporte_Resultados_Presidente_x_Provincia '1'
CREATE PROC sp_Reporte_Resultados_Presidente_x_Provincia
(
@CodProvincia varchar(1)
)
AS
BEGIN
	SELECT a.CodigoPartido, d.Descripcion as 'Nombre Partido', COUNT(*) as CantVotos
	FROM VotosEmitidos a, DistritosElectorales b, Provincias c, PartidosPoliticos d
	WHERE a.Codele = b.Codele and b.CodigoProvincia = c.CodigoProvincia and a.CodigoPartido = d.CodigoPartido 
	and a.IdTipoEleccion = 1 and c.CodigoProvincia = @CodProvincia
	GROUP BY a.CodigoPartido, d.Descripcion
	ORDER BY d.Descripcion ASC
END