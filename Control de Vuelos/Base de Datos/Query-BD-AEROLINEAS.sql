------- BD -------
CREATE DATABASE AEROLINEAS;
GO

USE AEROLINEAS;
GO

CREATE TABLE Aerolineas
	(idAerolinea	INT	IDENTITY(1,1)	NOT NULL,
	nombre			VARCHAR(100)		NOT NULL,
	lema			VARCHAR(MAX)		NOT NULL,
	PRIMARY KEY (idAerolinea));
GO

CREATE TABLE Aviones
	(idAvion			INT	IDENTITY(1,1)	NOT NULL,
	marca				VARCHAR(100)		NOT NULL,
	matricula			VARCHAR(50)	UNIQUE	NOT NULL,
	capacidadPasajeros	INT					NOT NULL,
	CHECK (capacidadPasajeros>=35),
	PRIMARY KEY (idAvion));
GO

CREATE TABLE AvionesAerolinea
	(id				INT	IDENTITY(1,1)	NOT NULL,
	matricula		VARCHAR(50)	UNIQUE	NOT NULL,
	idAerolinea		INT,
	PRIMARY KEY(id),
	FOREIGN KEY (matricula)		REFERENCES Aviones(matricula),
	FOREIGN KEY (idAerolinea)	REFERENCES Aerolineas(idAerolinea));
GO

CREATE TABLE Pilotos
	(idPiloto		INT	IDENTITY(1,1)	NOT NULL,
	cedulaPiloto	VARCHAR(150)		NOT NULL	UNIQUE,
	apellidoPat		VARCHAR(150)		NOT NULL,
	apellidoMat		VARCHAR(150)		NOT NULL,
	nombre			VARCHAR(150)		NOT NULL,
	PRIMARY KEY(idPiloto));
GO

CREATE TABLE Roles
	(idRol INT IDENTITY(1,1) NOT NULL,
	codigoRol INT UNIQUE NOT NULL,
	nombreRol VARCHAR(100)NOT NULL,
	PRIMARY KEY(idRol));
GO

CREATE TABLE Usuarios 
	(idUsuario INT IDENTITY(1,1) NOT NULL,
	cedulaUsuario VARCHAR(150) UNIQUE NOT NULL,
	codigoRol INT NOT NULL,
	nombre VARCHAR(150) NOT NULL,
	apellidoPat VARCHAR(150) NOT NULL,
	apellidoMat VARCHAR(150) NOT NULL,
	fechaNacim DATE NOT NULL,
	numTel VARCHAR(30) NOT NULL,
	genero VARCHAR(10) NOT NULL,
	estado BIT NOT NULL,
	PRIMARY KEY(idUsuario),
	FOREIGN KEY(codigoRol) REFERENCES Roles(codigoRol));
GO

CREATE TABLE CuentaUsuario
	(iCuenta INT IDENTITY(1,1) NOT NULL,
	idUsuario INT NOT NULL,
	email VARCHAR(300) NOT NULL,
	contrasenia VARCHAR(100) NOT NULL,
	PRIMARY KEY(idCuenta),
	FOREIGN KEY(idUsuario) REFERENCES Usuarios(idUsuario));
GO

CREATE TABLE Cuidades
	(idCuidad INT IDENTITY(1,1) NOT NULL,
	codigoCuidad VARCHAR(150) UNIQUE NOT NULL,
	pais VARCHAR(300) NOT NULL,
	canton VARCHAR(300) NOT NULL,
	distrito VARCHAR(300) NOT NULL,
	PRIMARY KEY(idCuidad));
GO

CREATE TABLE Vuelos(
	PRIMARY KEY(idVuelo),
	idVuelo				INT IDENTITY(1,1)	NOT NULL,
	idAvion				INT					NOT NULL,
	cedulaPiloto		VARCHAR(100) UNIQUE	NOT NULL,
	fechaHoraPartida	DATETIME			NOT NULL,
	fechaHoraLlegada	DATETIME			NOT NULL,
	codigoCiudadPartida	VARCHAR(100)		NOT NULL,
	codigoCiudadDestino	VARCHAR(100)		NOT NULL,
	FOREIGN KEY	(cedulaPiloto)	REFERENCES Pilotos(cedulaPiloto),
	FOREIGN KEY	(idAvion)		REFERENCES Aviones(idAvion),
	FOREIGN KEY	(ciudadPartida)	REFERENCES Ciudades(codigoCiudad),
	FOREIGN KEY	(ciudadDestino)	REFERENCES Ciudades(codigoCiudad));

GO

CREATE TABLE Pasajeros(
	PRIMARY KEY(idPasajero),
	idPasajero		INT IDENTITY(1,1)	NOT NULL,
	cedulaPasajero	VARCHAR(100) UNIQUE	NOT NULL,
	nombre			VARCHAR(20)			NOT NULL,
	apellidoMat		VARCHAR(20)			NOT NULL,
	apellidoPat		VARCHAR(20)			NOT NULL,
	codigoCiudad	VARCHAR(100)		NOT NULL,
	FOREIGN KEY	(ciudad) REFERENCES Ciudades(codigoCiudad));

GO

CREATE TABLE ListaPasajeros(
	PRIMARY KEY(id),
	id				INT IDENTITY(1,1)	NOT NULL,
	idVuelo			INT					NOT NULL,
	cedulaPasajero	VARCHAR(100) UNIQUE	NOT NULL,
	confirmado		BIT					NOT NULL,
	FOREIGN KEY	(idVuelo)		 REFERENCES Vuelos(idVuelo),
	FOREIGN KEY (cedulaPasajero) REFERENCES Pasajeros(cedulaPasajero));

GO
------------------------------------------

---------- INSERCIONES DE DATOS ----------

INSERT INTO Roles
	(codigoRol, nombreRol)
VALUES
	('ADM101', 'Administrador'),
	('RSV302', 'Encargado Reservas');
GO

-- Usuarios para pruebas
INSERT INTO Usuarios
	(cedulaUsuario, codigoRol, nombre, apellidoPat, apellidoMat, fechaNacim, numTel, genero, estado)
VALUES
	(1, 'ADM101', 'Eyden', 'Su', 'Díaz', '2004-17-09', 1, 'Masculino', 1),
	(2, 'RSV302', 'Juana', 'Montes', 'Sanchez', '1995-12-2', 1, 'Femenino', 1);
GO