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

CREATE TABLE Ciudades();

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

