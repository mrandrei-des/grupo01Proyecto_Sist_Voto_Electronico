-- BASE DE DATOS
CREATE DATABASE Sist_Votaciones_Electronicos

-- TABLA PARA LOS ESTADOS DE LOS PARTIDOS POLÍTICOS Y CANDIDATOS
CREATE TABLE Estados
(
IdEstado smallint NOT NULL,
Descripcion varchar(50),
PRIMARY KEY (IdEstado)
)

-- TABLA PARA LOS TIPOS DE ELECCIÓN
CREATE TABLE TiposEleccion
(
IdTipoEleccion smallint NOT NULL,
Descripcion varchar(100),
PRIMARY KEY (IdTipoEleccion)
)

-- TABLA PARA LOS PARTIDOS POLÍTICOS
CREATE TABLE PartidosPoliticos
(
CodigoPartido varchar(6) NOT NULL,
Descripcion varchar(100) NOT NULL,
NombreImagenBandera varchar(300) NOT NULL DEFAULT (''),
IdEstado smallint NOT NULL,
FechaHoraProceso datetime NOT NULL DEFAULT GETDATE(),
PRIMARY KEY (CodigoPartido),
FOREIGN KEY (IdEstado) REFERENCES Estados(IdEstado)
)

-- TABLA PARA LOS CANDIDATOS POLÍTICOS
CREATE TABLE Candidatos
(
CodigoCandidato varchar(50) NOT NULL,
Nombre varchar(30) NOT NULL,
PrimerApellido varchar(30) NOT NULL,
SegundoApellido varchar(30) NOT NULL,
NombreImagenFoto varchar(300) NOT NULL DEFAULT (''),
IdEstado smallint NOT NULL,
CodigoPartido varchar(6) NOT NULL
PRIMARY KEY (CodigoCandidato),
FOREIGN KEY (IdEstado) REFERENCES Estados(IdEstado),
FOREIGN KEY (CodigoPartido) REFERENCES PartidosPoliticos(CodigoPartido)
)

-- TABLA DE DISTRITOS_ELECTORALES CON SU CÓDIGO DE PROVINCIA, CANTÓN Y DISTRITO
CREATE TABLE DISTRITOS_ELECTORALES
(
CODELE varchar(6),
CodigoProvincia varchar(1),
Provincia varchar(10),
CodigoCanton varchar(2),
Canton varchar(25),
CodigoDistrito varchar(3),
Distrito varchar(34),
PRIMARY KEY (CODELE, CodigoProvincia, CodigoCanton, CodigoDistrito)
)

-- TABLA PARA LAS PROVINCIAS
CREATE TABLE PROVINCIAS
(
Codigo varchar(1) primary key,
Descripcion varchar(10)
)

-- TABLA PARA LOS CANTONES
CREATE TABLE CANTONES
(
CodigoProvincia varchar(1),
CodigoCanton varchar(2),
Descripcion varchar(25),
PRIMARY KEY (CodigoProvincia, CodigoCanton),
FOREIGN KEY (CodigoProvincia) References PROVINCIAS(Codigo)
)

-- TABLA PARA LOS DISTRITOS
CREATE TABLE DISTRITOS
(
CodigoProvincia varchar(1),
CodigoCanton varchar(2),
CodigoDistrito varchar(3),
Descripcion varchar(34),
PRIMARY KEY (CodigoProvincia, CodigoCanton, CodigoDistrito),
FOREIGN KEY (CodigoProvincia) References PROVINCIAS(Codigo),
FOREIGN KEY (CodigoProvincia, CodigoCanton) References CANTONES(CodigoProvincia, CodigoCanton)
)

-- TABLA PARA GUARDAR LA CANTIDAD DE DIPUTADOS QUE PUEDE OBTENER CADA PARTIDO POLÍTICO SEGÚN LA PROVINCIA
CREATE TABLE Diputados_x_Provincia
(
CodigoProvincia varchar(1) NOT NULL,
Cantidad int NOT NULL,
PRIMARY KEY (CodigoProvincia),
FOREIGN KEY (CodigoProvincia) References Provincias(CodigoProvincia)
)

-- TABLA PARA LOS DISTRITOS ELECTORALES (lugar donde se emite el voto) CON SU RESPECTIVO CODELE QUE INCLUYE CÓDIGO DE: PROVINCIA, CANTÓN Y DISTRITO.
-- SE DESCOMPONE EL CODELE EN CÓDIGO DE: PROVINCIA, CANTÓN Y DISTRITO PARA QUE AL MOMENTO DE GENERAR CONSULTAS SEA MÁS FÁCIL ENLAZAR TABLAS
CREATE TABLE DistritosElectorales
(
Codele varchar(6),
CodigoProvincia varchar(1),
CodigoCanton varchar(2),
CodigoDistrito varchar(3),
PRIMARY KEY (Codele),
FOREIGN KEY (CodigoProvincia) References Provincias(CodigoProvincia),
FOREIGN KEY (CodigoProvincia, CodigoCanton) References Cantones(CodigoProvincia, CodigoCanton),
FOREIGN KEY (CodigoProvincia, CodigoCanton, CodigoDistrito) References Distritos(CodigoProvincia, CodigoCanton, CodigoDistrito)
)

-- TABLA PARA EL PADRÓN ELECTORAL (lista de votantes)
CREATE TABLE PadronNacional
(
Cedula varchar(9) NOT NULL,
Codele varchar(6) NOT NULL,
Sexo char(1) NOT NULL,
FechaVencimientoCedula date NOT NULL,
NumeroJuntaReceptora varchar(5) NOT NULL,
Nombre varchar(30) NOT NULL,
PrimerApellido varchar(30) NOT NULL,
SegundoApellido varchar(30) NOT NULL,
PRIMARY KEY (Cedula),
FOREIGN KEY (Codele) References DistritosElectorales(Codele)
)

-- TABLA PARA LOS PERFILES DE USUARIO (Administrador, Votante)
CREATE TABLE Perfiles
(
IdPerfil smallint NOT NULL IDENTITY (1,1),
Descripcion varchar(50),
PRIMARY KEY (IdPerfil)
)

-- TABLA PARA LOS PERMISOS QUE PUEDE TENER ALGÚN PERFIL
CREATE TABLE Permisos
(
IdPermiso smallint NOT NULL IDENTITY (1,1),
Descripcion varchar(50),
PRIMARY KEY (IdPermiso)
)

-- TABLA PARA LOS PERMISOS QUE TIENE CADA PERMIL, (1 perfil tiene N permisos)
CREATE TABLE Permisos_x_Perfil
(
IdPerfil smallint NOT NULL,
IdPermiso smallint NOT NULL,
PRIMARY KEY (IdPerfil, IdPermiso),
FOREIGN KEY (IdPerfil) REFERENCES Perfiles(IdPerfil),
FOREIGN KEY (IdPermiso) REFERENCES Permisos(IdPermiso)
)

-- TABLA PARA LOS USUARIOS DEL SISTEMA
CREATE TABLE Usuarios
(
Cedula varchar(9) NOT NULL,
Contrasenna varchar(max) NOT NULL,
CorreoElectronico varchar(30) NOT NULL,
VotoPresidenteEmitido bit default 0,
VotoDiputadoEmitido bit default 0,
IdEstado smallint NOT NULL,
IdPerfil smallint NOT NULL
PRIMARY KEY (Cedula),
FOREIGN KEY (Cedula) REFERENCES PadronNacional(Cedula),
FOREIGN KEY (IdPerfil) REFERENCES Perfiles(IdPerfil),
FOREIGN KEY (IdEstado) REFERENCES Estados(IdEstado)
)

-- TABLA PARA GUARDAR LOS VOTOS EMITIDOS PARA PRESIDENTE
CREATE TABLE VotosRecibidos_Presidente
(
idVoto int NOT NULL IDENTITY(1,1),
Codelec varchar(6) NOT NULL,
PartidoVotado varchar(6) NOT NULL,
CandidatoVotado varchar(50) NOT NULL,
FechaEmisionVoto datetime NOT NULL DEFAULT(GETDATE()),
PRIMARY KEY (idVoto),
FOREIGN KEY (Codelec) REFERENCES DistritosElectorales(Codele),
FOREIGN KEY (PartidoVotado) REFERENCES PartidosPoliticos(CodigoPartido),
FOREIGN KEY (CandidatoVotado) REFERENCES Candidatos(CodigoCandidato)
)

-- TABLA PARA GUARDAR LOS VOTOS EMITIDOS PARA PRESIDENTE
CREATE TABLE BitacoraVotoEmitido_Presidente
(
idVoto int NOT NULL IDENTITY(1,1),
Cedula varchar(9) NOT NULL,
FechaEmisionVoto datetime NOT NULL DEFAULT(GETDATE()),
PRIMARY KEY (Cedula),
FOREIGN KEY (Cedula) REFERENCES PadronNacional(Cedula)
)

-- TABLA PARA GUARDAR LOS VOTOS EMITIDOS PARA DIPUTADOS
CREATE TABLE VotosRecibidos_Diputados
(
idVoto int NOT NULL IDENTITY(1,1),
Codelec varchar(6) NOT NULL,
PartidoVotado varchar(6) NOT NULL,
FechaEmisionVoto datetime NOT NULL DEFAULT(GETDATE()),
PRIMARY KEY (idVoto),
FOREIGN KEY (Codelec) REFERENCES DistritosElectorales(Codele),
FOREIGN KEY (PartidoVotado) REFERENCES PartidosPoliticos(CodigoPartido)
)

-- TABLA PARA GUARDAR LOS VOTOS EMITIDOS PARA PRESIDENTE
CREATE TABLE BitacoraVotoEmitido_Diputados
(
idVoto int NOT NULL IDENTITY(1,1),
Cedula varchar(9) NOT NULL,
FechaEmisionVoto datetime NOT NULL DEFAULT(GETDATE()),
PRIMARY KEY (Cedula),
FOREIGN KEY (Cedula) REFERENCES PadronNacional(Cedula)
)