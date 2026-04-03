-- PROCEDIMIENTO ALMACENADO PARA LA CREACIÓN DE USUARIOS VOTANTES EN LA PANTALLA DE REGISTRO
CREATE PROC sp_Ingresar_Usuario_Votante
(
@Cedula varchar(9),
@Contrasenna varchar(max),
@CorreoElectronico varchar(30)
)
AS
BEGIN
	INSERT INTO Usuarios(Cedula, Contrasenna, CorreoElectronico, VotoPresidenteEmitido, VotoDiputadoEmitido, IdEstado, IdPerfil)
	VALUES (@Cedula, @Contrasenna, @CorreoElectronico, 0, 0, 2, 2)
END
