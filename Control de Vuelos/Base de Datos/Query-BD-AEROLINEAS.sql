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


CREATE TABLE Pasajeros(
 PRIMARY KEY(idPasajero),
 idPasajero INT IDENTITY(1,1) NOT NULL,
 cedulaPasajero VARCHAR(20) UNIQUE NOT NULL,
 nombre VARCHAR(20) NOT NULL,
 apellidoMat VARCHAR(20) NOT NULL,
 apellidoPat VARCHAR(20) NOT NULL,
 ciudad VARCHAR(100) NOT NULL);

GO

CREATE TABLE ListaPasajeros(
primary key(id),
id INT IDENTITY(1,1) NOT NULL,
idVuelo INT NOT NULL,
cedulaPasajero VARCHAR(20) UNIQUE NOT NULL,
confirmado BIT NOT NULL);

GO

CREATE TABLE Vuelos(
PRIMARY KEY(idVuelo),
idVuelo INT IDENTITY(1,1) NOT NULL,
idAvion INT NOT NULL,
cedulaPiloto VARCHAR(30) UNIQUE NOT NULL,
fechaHoraPartida DATETIME NOT NULL,
fechaHoraLlegada DATETIME NOT NULL,
ciudadPartida VARCHAR(100) NOT NULL,
ciudadDestino VARCHAR(100) NOT NULL);

GO
