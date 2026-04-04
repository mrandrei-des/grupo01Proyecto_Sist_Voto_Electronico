-- PROCEDIMIENTO ALMACENADO QUE CONSULTA VOTANTES POR PROVINCIA EN EL PADRÓN NACIONAL
-- EXEC sp_Consulta_PadronNacional_x_Provincia ''
CREATE PROC sp_Consulta_PadronNacional_x_Provincia
(
@CodProvincia varchar(1)
)
AS
BEGIN
	SELECT TOP 50 Cedula as 'CÉDULA', PrimerApellido AS 'PRIMER APELLIDO', SegundoApellido AS 'SEGUNDO APELLIDO', 
	Nombre as NOMBRE, FORMAT(FechaVencimientoCedula, 'dd-MM-yyyy') AS 'FECHA VENCIMIENTO CÉDULA' 
	FROM PadronNacional 
	WHERE LEFT(CODELE, 1) = @CodProvincia
	ORDER BY PrimerApellido ASC, SegundoApellido ASC, Nombre ASC, Cedula ASC 
END