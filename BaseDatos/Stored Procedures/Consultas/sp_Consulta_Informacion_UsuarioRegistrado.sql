CREATE OR ALTER PROC sp_Consulta_Informacion_UsuarioRegistrado
(
@Cedula varchar(9),
@Contrasenna varchar(max)
)
AS
BEGIN
	SELECT a.*, b.FechaVencimientoCedula
	FROM Usuarios a
	JOIN PadronNacional b on a.Cedula = b.Cedula
	WHERE a.Cedula = @Cedula and a.Contrasenna = @Contrasenna
END