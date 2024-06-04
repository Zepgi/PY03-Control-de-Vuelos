------- BD -------
CREATE DATABASE AEROLINEAS;
GO

USE AEROLINEAS;
GO

CREATE TABLE Aerolineas
	(idAerolinea	INT	IDENTITY(1,1)	NOT NULL,
	nombre			VARCHAR(100)		NOT NULL,
	lema			VARCHAR(MAX)		NOT NULL,
	estado			BIT					NOT NULL,
	PRIMARY KEY (idAerolinea));
GO

CREATE TABLE Aviones
	(idAvion			INT	IDENTITY(1,1)	NOT NULL,
	marca				VARCHAR(100)		NOT NULL,
	matricula			VARCHAR(50)	UNIQUE	NOT NULL,
	capacidadPasajeros	INT					NOT NULL,
	estado			BIT						NOT NULL,
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
	estado			BIT					NOT NULL,
	PRIMARY KEY(idPiloto));
GO

CREATE TABLE Usuarios 
	(idUsuario INT IDENTITY(1,1) NOT NULL,
	cedulaUsuario VARCHAR(150) UNIQUE NOT NULL,
	nombre VARCHAR(150) NOT NULL,
	apellidoPat VARCHAR(150) NOT NULL,
	apellidoMat VARCHAR(150) NOT NULL,
	fechaNacim DATE NOT NULL,
	numTel VARCHAR(50) NOT NULL,
	genero VARCHAR(4) NOT NULL,
	estado BIT NOT NULL,
	PRIMARY KEY(idUsuario));
GO

CREATE TABLE Permisos
	(idPermiso	INT	IDENTITY(1,1) NOT NULL,
	detalle		VARCHAR(200),
	PRIMARY KEY (idPermiso));
GO

CREATE TABLE ListaPermisos
	(idLisPer	INT	IDENTITY(1,1) NOT NULL,
	idAerolinea INT NULL,
	idPermiso	INT NOT NULL,
	idUsuario	INT	NOT NULL,
	FOREIGN KEY (idPermiso)		REFERENCES Permisos(idPermiso),
	FOREIGN KEY (idUsuario)		REFERENCES Usuarios(idUsuario),
	FOREIGN KEY (idAerolinea) REFERENCES Aerolineas(idAerolinea));
GO


CREATE TABLE CuentaUsuario
	(idCuenta INT IDENTITY(1,1) NOT NULL,
	idUsuario INT NOT NULL,
	email VARCHAR(300) NOT NULL,
	contrasenia VARCHAR(100) NOT NULL,
	PRIMARY KEY(idCuenta),
	FOREIGN KEY(idUsuario) REFERENCES Usuarios(idUsuario));
GO

CREATE TABLE Ciudades
	(idCiudad INT IDENTITY(1,1) NOT NULL,
	codigoCiudad VARCHAR(150) UNIQUE NOT NULL,
	pais VARCHAR(150) NOT NULL,
	canton VARCHAR(150) NOT NULL,
	distrito VARCHAR(150) NOT NULL,
	ciudad	VARCHAR(150) NOT NULL,
	PRIMARY KEY(idCiudad));
GO

CREATE TABLE Vuelos(
	PRIMARY KEY(idVuelo),
	idVuelo				INT IDENTITY(1,1)	NOT NULL,
	idAerolinea			INT NOT NULL,
	idAvion				INT	NOT NULL,
	cedulaPiloto		VARCHAR(150) UNIQUE	NOT NULL,
	fechaHoraPartida	DATETIME			NOT NULL,
	fechaHoraLlegada	DATETIME			NOT NULL,
	codigoCiudadPartida	VARCHAR(150)		NOT NULL,
	codigoCiudadDestino	VARCHAR(150)		NOT NULL,
	estado			BIT						NOT NULL,
	FOREIGN KEY (idAerolinea)			REFERENCES Aerolineas(idAerolinea),
	FOREIGN KEY	(cedulaPiloto)			REFERENCES Pilotos(cedulaPiloto),
	FOREIGN KEY	(idAvion)				REFERENCES Aviones(idAvion),
	FOREIGN KEY	(codigoCiudadPartida)	REFERENCES Ciudades(codigoCiudad),
	FOREIGN KEY	(codigoCiudadDestino)	REFERENCES Ciudades(codigoCiudad));
GO

CREATE TABLE Pasajeros(
	PRIMARY KEY(idPasajero),
	idPasajero		INT IDENTITY(1,1)	NOT NULL,
	cedulaPasajero	VARCHAR(150) UNIQUE	NOT NULL,
	nombre			VARCHAR(150)		NOT NULL,
	apellidoMat		VARCHAR(150)		NOT NULL,
	apellidoPat		VARCHAR(150)		NOT NULL,
	codigoCiudad	VARCHAR(150)		NOT NULL,
	FOREIGN KEY	(codigoCiudad) REFERENCES Ciudades(codigoCiudad));
GO

CREATE TABLE ListaPasajeros(
	PRIMARY KEY(id),
	id				INT IDENTITY(1,1)	NOT NULL,
	idVuelo			INT					NOT NULL,
	cedulaPasajero	VARCHAR(150) UNIQUE	NOT NULL,
	confirmado		BIT					NOT NULL,
	FOREIGN KEY	(idVuelo)		 REFERENCES Vuelos(idVuelo),
	FOREIGN KEY (cedulaPasajero) REFERENCES Pasajeros(cedulaPasajero));
GO
------------------------------------------

CREATE PROC Permisos_Admin_General
	(@idUsuario INT)
AS
BEGIN
	INSERT INTO ListaPermisos
		(idAerolinea, idUsuario, idPermiso)
	VALUES
		(NULL, @idUsuario, 1),
		(NULL, @idUsuario, 2),
		(NULL, @idUsuario, 3),
		(NULL, @idUsuario, 4);
END;
GO

CREATE PROC Permisos_Admin_Aerolinea
	(@idUsuario INT,
	@idAerolinea INT)
AS
BEGIN
	INSERT INTO ListaPermisos
		(idAerolinea, idUsuario, idPermiso)
	VALUES
		(@idAerolinea, @idUsuario, 2),
		(@idAerolinea, @idUsuario, 3),
		(@idAerolinea, @idUsuario, 4);
END;
GO

CREATE PROC Permisos_Reserva_Aerolinea
	(@idUsuario INT,
	@idAerolinea INT)
AS
BEGIN
	INSERT INTO ListaPermisos
		(idAerolinea, idUsuario, idPermiso)
	VALUES
		(@idAerolinea, @idUsuario, 2);
END;
GO


---------- INSERCIONES DE DATOS ----------

INSERT INTO Aerolineas
	(nombre, lema, estado)
VALUES
	('PASE', 'decídete a PASAR.', 1),
	('PepeAirlines', 'Si', 1);
GO

-- Usuarios para pruebas
INSERT INTO Usuarios
	(cedulaUsuario, nombre, apellidoPat, apellidoMat, fechaNacim, numTel, genero, estado)
VALUES
	(1, 'Eyden', 'Su', 'Díaz', '2004-09-17', '88888888', 'M', 1),
	(2, 'Juana', 'Montes', 'Sanchez', '1995-12-2', '88888888', 'F', 1),
	(3, 'Pedro', 'Soto', 'Soto', '1990-12-03', '88888888', 'M', 1),
	(4, 'Alex', 'Rodriguez', 'Gomez', '1997-03-03', '88888888', 'M', 1),
	(5, 'Pepe', 'Arrieta', 'Lopez', '1997-03-03', '88888888', 'M', 1);
GO

INSERT INTO CuentaUsuario
	(idUsuario, email, contrasenia)
VALUES
	(1, '1', '1'),
	(2, '2', '2'),
	(3, '3', '3'),
	(4, '4', '4'),
	(5, '5', '5');
GO

INSERT INTO Permisos
	(detalle)
VALUES
	('Modulo aerolineas'),
	('Modulo vuelos'),
	('Modulo Mantenimiento'),
	('Modulo Reportes');
GO

--------- Admin general

EXEC Permisos_Admin_General 1;
GO

---------- Admin aerolinea

EXEC Permisos_Admin_Aerolinea 2, 1;
GO
EXEC Permisos_Admin_Aerolinea 4, 2;
GO

--------- Reservas aerolinea

EXEC Permisos_Reserva_Aerolinea 3, 1;
GO
EXEC Permisos_Reserva_Aerolinea 5, 2;
GO

------------ STORED PROCEDURES ------------

CREATE PROC Verificar_Credenciales 
    (@email VARCHAR(300), @contrasenia VARCHAR(100))
AS
BEGIN
    BEGIN TRY
        SELECT U.cedulaUsuario
        FROM Usuarios U
        INNER JOIN CuentaUsuario CU ON CU.idUsuario = U.idUsuario
        WHERE CU.email = @email AND CU.contrasenia = @contrasenia
        GROUP BY U.cedulaUsuario;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage VARCHAR(MAX);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

CREATE PROC Get_Permisos
	(@idUsuario INT)
AS
BEGIN
	BEGIN TRY
        SELECT idPermiso, idAerolinea
		FROM ListaPermisos
		WHERE idUsuario = @idUsuario;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage VARCHAR(MAX);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

CREATE PROC Get_Flights
	(@idAerolinea INT)
AS
BEGIN
	SELECT idVuelo, idAvion, CONCAT ( P.apellidoPat, ' ', P.apellidoMat, ' ', P.nombre), fechaHoraPartida, fechaHoraLlegada, C.ciudad, C2.ciudad, V.estado
	FROM Vuelos V
	INNER JOIN Pilotos P ON
	V.cedulaPiloto =  P.cedulaPiloto
	INNER JOIN Ciudades C ON
	C.codigoCiudad = V.codigoCiudadDestino
	INNER JOIN Ciudades C2 ON
	C2.codigoCiudad = V.codigoCiudadPartida
	WHERE @idAerolinea = idAerolinea
	GROUP BY idVuelo, idAvion, CONCAT ( P.apellidoPat, ' ', P.apellidoMat, ' ', P.nombre), fechaHoraPartida, fechaHoraLlegada, C.ciudad, C2.ciudad, V.estado;
END;
GO

CREATE PROC Get_Passengers
AS
BEGIN
	SELECT cedulaPasajero, CONCAT(apellidoMat, ' ', apellidoMat, ' ', nombre), C.ciudad
	FROM Pasajeros P
	INNER JOIN Ciudades C ON
	P.codigoCiudad = C.codigoCiudad
	GROUP BY cedulaPasajero, CONCAT(apellidoMat, ' ', apellidoMat, ' ', nombre), C.ciudad
END;
GO



------------ INICIO STORED PROCEDURES AEROLINEAS ------------
CREATE PROC Crear_Aerolinea
    (@nombre VARCHAR(100), @lema VARCHAR(MAX))
AS
BEGIN
	BEGIN TRY
    -- Verificar si el nombre de la aerolínea ya existe
    IF EXISTS (SELECT 1 FROM Aerolineas WHERE nombre = @nombre)
    BEGIN
        RAISERROR ('El nombre de la aerolínea ya existe. Por favor, elija otro nombre.', 16, 1);
        RETURN;
    END

    -- Insertar un nuevo registro en la tabla Aerolineas
    INSERT INTO Aerolineas (nombre, lema, estado) VALUES(@nombre, @lema, 1); -- 1 activo
	END TRY
	BEGIN CATCH
	DECLARE @ErrorMessage NVARCHAR(4000)
	DECLARE @ErrorSeverity INT;
	DECLARE @ErrorState INT;

	SELECT 
            @ErrorMessage  = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

	RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

---------- ObtenerAerolineas-------------
CREATE PROCEDURE ObtenerAerolineas
AS
BEGIN

    SET NOCOUNT ON;

    SELECT idAerolinea, nombre, lema, estado 
    FROM Aerolineas;
END;
GO

CREATE PROCEDURE Actualizar_Aerolinea
    @idAerolinea INT,
    @nombre VARCHAR(100),
    @lema VARCHAR(MAX)
AS
BEGIN
	BEGIN TRY
    -- Verificar si el nuevo nombre de la aerolínea ya existe para otra aerolínea
    IF EXISTS (SELECT 1 FROM Aerolineas WHERE nombre = @nombre AND idAerolinea <> @idAerolinea)
    BEGIN
        RAISERROR ('El nombre de la aerolínea ya existe. Por favor, elija otro nombre.', 16, 1);
        RETURN;
    END

    -- Actualiza la aerolínea con el ID especificado
    UPDATE Aerolineas
    SET nombre = @nombre,
        lema = @lema
    WHERE idAerolinea = @idAerolinea;
	END TRY
	BEGIN CATCH
	DECLARE @ErrorMessage NVARCHAR(4000);
	DECLARE @ErrorSeverity INT;
	DECLARE @ErrorState INT;

	SELECT
		@ErrorMessage = ERROR_MESSAGE(),
		@ErrorSeverity = ERROR_SEVERITY(),
		@ErrorState = ERROR_STATE();
		
	RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END;
GO
-- Cambia el estado de la aerolínea a desactivado = (0)
CREATE PROCEDURE Desactivar_Aerolinea
    @idAerolinea INT
AS
BEGIN
    -- SET NOCOUNT ON evita que se muestre el número de filas afectadas
    SET NOCOUNT ON;

    -- Actualizar el estado de la aerolínea a 0 (desactivado)
    UPDATE Aerolineas
    SET estado = 0
    WHERE idAerolinea = @idAerolinea;
END;
GO



------------ FIN STORED PROCEDURES AEROLINEAS ------------

------------ STORED PROCEDURES PARA BUSQUEDAS ------------

CREATE PROC Buscar_Usuario
	(@idUsuario INT)
AS
BEGIN
    BEGIN TRY
        SELECT idUsuario, cedulaUsuario, CONCAT(nombre, ' ', apellidoPat, ' ', apellidoMat) nombreCompleto, fechaNacim, numTel, genero, estado
		FROM Usuarios
		WHERE idUsuario = @idUsuario
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage VARCHAR(MAX);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

---------------------------------------------------------------------
/*

DROP PROCEDURE Obtener_Aerolineas;


DELETE Aerolineas
DELETE ListaPermisos
SELECT * FROM Aerolineas
*/