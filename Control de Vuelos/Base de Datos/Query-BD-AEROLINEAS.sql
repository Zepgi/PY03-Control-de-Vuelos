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
	nacionalidad		VARCHAR(150)	NOT NULL,
	idAerolinea		INT			NOT NULL,
	estado			BIT			NOT NULL,
	FOREIGN KEY (idAerolinea) REFERENCES Aerolineas(idAerolinea),
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
	cedulaPiloto		VARCHAR(150)    	NOT NULL,
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
	asiento			INT					NOT NULL,
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


---------------FLIGTH PROCEDURES-------------------
CREATE PROC Get_Flights
	(@idAerolinea INT)
AS
BEGIN
	SELECT  V.idVuelo Vuelo, A.matricula 'Avión' , P.cedulaPiloto Piloto, fechaHoraPartida 'Salida', fechaHoraLlegada 'Llegada', CONCAT(C.codigoCiudad, ' | ', C.ciudad) 'Ciudad de Partida', CONCAT(C2.codigoCiudad, ' | ' ,C2.ciudad) 'Ciudad de Destino' , V.estado Estado
	FROM Vuelos V
	INNER JOIN Pilotos P ON
	V.cedulaPiloto =  P.cedulaPiloto
	INNER JOIN Ciudades C ON
	C.codigoCiudad = V.codigoCiudadDestino
	INNER JOIN Ciudades C2 ON
	C2.codigoCiudad = V.codigoCiudadPartida
	INNER JOIN Aviones A ON
	A.idAvion = V.idAvion
	WHERE @idAerolinea = V.idAerolinea AND V.fechaHoraPartida > GETDATE()
	GROUP BY V.idVuelo, A.matricula, P.cedulaPiloto, fechaHoraPartida, fechaHoraLlegada,  CONCAT(C.codigoCiudad, ' | ', C.ciudad), CONCAT(C2.codigoCiudad, ' | ' ,C2.ciudad), V.estado;
END;
GO

CREATE PROC Get_Passengers
AS
BEGIN
	SELECT cedulaPasajero 'Cédula', CONCAT(apellidoPat, ' ', apellidoMat, ' ', nombre) 'Nombre Completo', C.ciudad 'Ciudad de Residencia'
	FROM Pasajeros P
	INNER JOIN Ciudades C ON
	P.codigoCiudad = C.codigoCiudad
	GROUP BY cedulaPasajero, CONCAT(apellidoPat, ' ', apellidoMat, ' ', nombre), C.ciudad
END;
GO

CREATE PROC Get_Cities
AS
BEGIN
	SELECT idCiudad, codigoCiudad, pais, canton, distrito, ciudad
	FROM Ciudades
END;
GO

CREATE PROC Get_Planes
(@idAerolinea INT)
AS
BEGIN
	SELECT 	id, matricula, idAerolinea
	FROM AvionesAerolinea 
	WHERE idAerolinea = @idAerolinea
END;
GO

CREATE PROC Get_Pilots
(@idAerolinea INT)
AS
BEGIN
	SELECT idPiloto, cedulaPiloto, apellidoPat, apellidoMat, nombre, estado
	FROM Pilotos P
	WHERE P.idAerolinea = @idAerolinea
END;
GO

CREATE PROC Add_Flight
(
    @idAerolinea        INT,
    @matricula          VARCHAR(150),
    @cedulaPiloto       INT,
    @fechaHoraPartida   DATETIME,
    @fechaHoraLlegada   DATETIME,
    @codigoCiudadPartida VARCHAR(150),
    @codigoCiudadDestino VARCHAR(150)
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Vuelos (idAerolinea, idAvion, cedulaPiloto, fechaHoraPartida, fechaHoraLlegada, codigoCiudadPartida, codigoCiudadDestino, estado)
        VALUES (
            @idAerolinea, 
            (SELECT idAvion FROM Aviones WHERE matricula = @matricula), 
            @cedulaPiloto, 
            @fechaHoraPartida, 
            @fechaHoraLlegada, 
            @codigoCiudadPartida,
            @codigoCiudadDestino, 
            1
        );
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
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

CREATE FUNCTION isExistingFlight
(
	@idVuelo			INT,
    @idAerolinea        INT,
    @idAvion			INT,
    @cedulaPiloto       VARCHAR(150),
    @fechaHoraPartida   DATETIME,
    @fechaHoraLlegada   DATETIME,
    @codigoCiudadPartida VARCHAR(150),
    @codigoCiudadDestino VARCHAR(150)
)
RETURNS BIT
AS
BEGIN
    DECLARE @exists BIT;
    IF EXISTS (
        SELECT 1
        FROM Vuelos
        WHERE 
			  idVuelo = @idVuelo AND
			  idAerolinea = @idAerolinea AND 
              idAvion = @idAvion AND 
              cedulaPiloto = @cedulaPiloto AND
              fechaHoraPartida = @fechaHoraPartida AND
              fechaHoraLlegada = @fechaHoraLlegada AND
              codigoCiudadPartida = @codigoCiudadPartida AND
              codigoCiudadDestino = @codigoCiudadDestino
    )
    BEGIN
        SET @exists = 1;
    END
    ELSE
    BEGIN
        SET @exists = 0;
    END

    RETURN @exists;
END;
GO

CREATE PROC Update_Flight
(
	@idVuelo			INT,
    @idAerolinea        INT,
    @matricula          VARCHAR(150),
    @cedulaPiloto       VARCHAR(150),
    @fechaHoraPartida   DATETIME,
    @fechaHoraLlegada   DATETIME,
    @codigoCiudadPartida VARCHAR(150),
    @codigoCiudadDestino VARCHAR(150)
)
AS
BEGIN
    DECLARE @idAvion INT;
    DECLARE @flightExists BIT;

    SET @idAvion = (SELECT idAvion FROM Aviones WHERE matricula = @matricula);

    SET @flightExists = dbo.isExistingFlight(@idVuelo, @idAerolinea, @idAvion, @cedulaPiloto, @fechaHoraPartida, @fechaHoraLlegada, @codigoCiudadPartida, @codigoCiudadDestino);

    IF @flightExists = 0
    BEGIN
        UPDATE Vuelos
        SET idAvion = @idAvion,
            cedulaPiloto = @cedulaPiloto,
            fechaHoraPartida = @fechaHoraPartida,
            fechaHoraLlegada = @fechaHoraLlegada,
            codigoCiudadPartida = @codigoCiudadPartida,
            codigoCiudadDestino = @codigoCiudadDestino
        WHERE idVuelo = @idVuelo AND
			  idAerolinea = @idAerolinea
    END
    ELSE
    BEGIN
        RAISERROR ('Debe modificar al menos un dato.', 16, 1);
    END
END;
GO


CREATE FUNCTION dbo.isExistingPassenger
(
    @cedulaPasajero VARCHAR(150),
    @nombre         VARCHAR(150),
    @apellidoPat    VARCHAR(150),
    @apellidoMat    VARCHAR(150),
    @codigoCiudad   VARCHAR(150)
)
RETURNS BIT
AS
BEGIN
    DECLARE @exists BIT;
    
    IF EXISTS (
        SELECT 1 
        FROM Pasajeros 
        WHERE cedulaPasajero = @cedulaPasajero 
          AND nombre = @nombre 
          AND apellidoMat = @apellidoMat 
          AND apellidoPat = @apellidoPat 
          AND codigoCiudad = @codigoCiudad
    )
    BEGIN
        SET @exists = 1;
    END
    ELSE
    BEGIN
        SET @exists = 0;
    END
    
    RETURN @exists;
END;
GO


CREATE PROC Update_Passenger
(
    @cedulaPasajero VARCHAR(150),
    @nombre         VARCHAR(150),
    @apellidoPat    VARCHAR(150),
    @apellidoMat    VARCHAR(150),
    @pais           VARCHAR(150),
    @canton         VARCHAR(150),
    @distrito       VARCHAR(150),
    @ciudad         VARCHAR(150)
)
AS
BEGIN
    DECLARE @codigoCiudad VARCHAR(150);
    DECLARE @passengerExists BIT;

    SET @codigoCiudad = (SELECT codigoCiudad 
                         FROM Ciudades 
                         WHERE pais = @pais 
                           AND canton = @canton 
                           AND distrito = @distrito 
                           AND ciudad = @ciudad);

    SET @passengerExists = dbo.isExistingPassenger(@cedulaPasajero, @nombre, @apellidoPat, @apellidoMat, @codigoCiudad);

    IF @passengerExists = 0
    BEGIN
        UPDATE Pasajeros
        SET nombre = @nombre,
            apellidoMat = @apellidoMat,
            apellidoPat = @apellidoPat,
            codigoCiudad = @codigoCiudad
        WHERE cedulaPasajero = @cedulaPasajero;
    END
    ELSE
    BEGIN
        RAISERROR ('Debe modificar al menos un dato.', 16, 1);
    END
END;
GO


CREATE PROC Search_Active_Flights
(
    @idVuelo INT
)
AS
BEGIN
    SELECT
        idAerolinea,
        idAvion,
        cedulaPiloto,
        fechaHoraPartida,
        fechaHoraLlegada,
        codigoCiudadPartida,
        codigoCiudadDestino,
        estado
    FROM Vuelos
    WHERE idVuelo = @idVuelo AND estado = 1;
END;
GO


CREATE PROC Search_Active_Planes
(
    @idAvion INT
)
AS
BEGIN
    SELECT
        marca,
        matricula,
        capacidadPasajeros,
        estado
    FROM Aviones
    WHERE idAvion = @idAvion AND estado = 1;
END;
GO

CREATE PROC Search_City
(
    @pais VARCHAR(150),
    @canton VARCHAR(150),
    @distrito VARCHAR(150),
    @ciudad VARCHAR(150)
)
AS
BEGIN
	SELECT codigoCiudad
	FROM Ciudades
	WHERE @pais = pais AND @canton = canton AND @distrito = distrito AND @ciudad = ciudad
END;
GO

CREATE PROC Search_Passenger
(
	@cedulaPasajero INT
)
AS
BEGIN
	SELECT 	idPasajero, cedulaPasajero, CONCAT(nombre, ' ', apellidoPat, ' ', apellidoMat) nombreCompleto, C.pais, C.canton, C.distrito, C.ciudad
	FROM Pasajeros P
	INNER JOIN Ciudades C ON
	P.codigoCiudad = C.codigoCiudad
	WHERE @cedulaPasajero = cedulaPasajero
	GROUP BY idPasajero, cedulaPasajero, CONCAT( nombre, ' ', apellidoPat, ' ', apellidoMat), C.pais, C.canton, C.distrito, C.ciudad
END;
GO

CREATE PROC Generate_City_Code
(
    @ciudad VARCHAR(150),
    @codigoCiudad VARCHAR(150) OUTPUT
)
AS
BEGIN
    DECLARE @randomNumber INT;
    DECLARE @cityCode VARCHAR(150);

    SET @cityCode = LEFT(@ciudad, 3);
    SET @randomNumber = CAST(FLOOR(RAND() * 10000) AS INT);
    SET @cityCode = @cityCode + RIGHT('0000' + CAST(@randomNumber AS VARCHAR(4)), 4);
    SET @codigoCiudad = @cityCode;
END;
GO



CREATE PROC Add_City
(
    @pais VARCHAR(150),
    @canton VARCHAR(150),
    @distrito VARCHAR(150),
    @ciudad VARCHAR(150)
)
AS
BEGIN
    DECLARE @codigoCiudad VARCHAR(150);

    EXEC Generate_City_Code @ciudad, @codigoCiudad OUTPUT;

    IF EXISTS (SELECT 1 FROM Ciudades WHERE pais = @pais AND canton = @canton AND distrito = @distrito AND ciudad = @ciudad)
        RETURN;
    ELSE
        INSERT INTO Ciudades (codigoCiudad, pais, canton, distrito, ciudad)
        VALUES (@codigoCiudad, @pais, @canton, @distrito, @ciudad);
END;
GO


CREATE PROC Add_Passenger
(
    @cedulaPasajero VARCHAR(150),
    @nombre         VARCHAR(150),
    @apellidoMat    VARCHAR(150),
    @apellidoPat    VARCHAR(150),
    @codigoCiudad   VARCHAR(150)
)
AS
BEGIN
    INSERT INTO Pasajeros (cedulaPasajero, nombre, apellidoPat, apellidoMat, codigoCiudad)
    VALUES (@cedulaPasajero, @nombre, @apellidoPat, @apellidoMat, @codigoCiudad);
END;
GO

CREATE PROC Add_Passenger_To_List
(
	@cedulaPasajero	VARCHAR(150),
	@idVuelo		INT,
	@asiento		INT
)
AS
BEGIN
	INSERT INTO ListaPasajeros (idVuelo, cedulaPasajero, asiento, confirmado)
	VALUES (@idVuelo, @cedulaPasajero, @asiento, 0)
END;
GO


CREATE PROC Search_Between_Dates
(
	@fechaHoraPartida	DATETIME,
	@fechaHoraLlegada	DATETIME
)
AS
BEGIN
	SELECT cedulaPiloto, (SELECT matricula FROM Aviones A WHERE A.idAvion = V.idAvion) matricula, idVuelo
	FROM Vuelos V
	WHERE (fechaHoraLlegada BETWEEN @fechaHoraPartida AND @fechaHoraLlegada) OR
			(fechaHoraPartida BETWEEN @fechaHoraPartida AND fechaHoraLlegada)
			
END;
GO

CREATE PROC Get_Occupied_Seats
(
	@idVuelo	INT
)
AS
BEGIN
	SELECT asiento
	FROM ListaPasajeros
	WHERE @idVuelo = idVuelo
END;
GO

CREATE PROC Confirm_Passenger
(
	@asiento	INT,
	@idVuelo	INT
)
AS
BEGIN
	UPDATE ListaPasajeros
	SET confirmado = 1
	WHERE
		asiento = @asiento AND
		idVuelo = @idVuelo
END;
GO

CREATE FUNCTION isFlightConfirmed
(
	@idVuelo INT
)
RETURNS BIT
AS
BEGIN
	DECLARE @result BIT;
	
	IF EXISTS (
		SELECT 1
		FROM ListaPasajeros
		WHERE idVuelo = @idVuelo AND confirmado = 1
	)
	BEGIN
		SET @result = 1;
	END
	ELSE
	BEGIN
		SET @result = 0;
	END
	
	RETURN @result;
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
---------- ObtenerAerolineasId-------------
CREATE PROCEDURE GetAirlineByName
    @Name VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        SELECT 
            idAerolinea,
            nombre,
            lema,
            estado
        FROM 
            Aerolineas
        WHERE 
            nombre LIKE '%' + @Name + '%';
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


------------ STORED PROCEDURES PARA AVIONES ------------
CREATE PROC Crear_Aviones
(
    @marca VARCHAR(100),
    @matricula VARCHAR(50),
    @cantidadPasajeros INT,
    @estado INT = 1  -- Valor predeterminado para el estado
)
AS
BEGIN
    BEGIN TRY
        -- Verifica si la matricula del Avion ya existe
        IF EXISTS(SELECT 1 FROM Aviones WHERE matricula = @matricula)
        BEGIN
            RAISERROR('La matricula del avion ya existe. Por favor, elija otro numero de matricula', 16, 1);
            RETURN;
        END

        -- Verifica si la marca del avion ya existe
        IF EXISTS(SELECT 1 FROM Aviones WHERE marca = @marca)
        BEGIN
            RAISERROR('La marca del avion ya existe. Por favor, elija otra marca', 16, 1);
            RETURN;
        END

        -- Verifica que la cantidad de pasajeros sea mayor o igual a 35
        IF @cantidadPasajeros < 35
        BEGIN
            RAISERROR('La capacidad de pasajeros debe ser mayor o igual a 35.', 16, 1);
            RETURN;
        END

        -- Inserta un nuevo avion a la tabla aviones
        INSERT INTO Aviones (matricula, marca, capacidadPasajeros, estado)
        VALUES (@matricula, @marca, @cantidadPasajeros, @estado);

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

CREATE PROC Actualizar_Aviones
    (@matricula VARCHAR(50), 
    @marca VARCHAR(100), 
    @cantidadPasajeros INT)
AS
BEGIN
    BEGIN TRY
        -- Verifica si la marca ya existe para otro avion
        IF EXISTS (SELECT 1 FROM Aviones WHERE marca = @marca AND matricula <> @matricula)
        BEGIN
            RAISERROR('La marca del avion ya existe. Por favor, elija otra marca', 16, 1);
            RETURN;
        END

        -- Verifica que la cantidad de pasajeros sea mayor o igual a 35
        IF @cantidadPasajeros < 35
        BEGIN
            RAISERROR('La capacidad de pasajeros debe ser mayor o igual a 35.', 16, 1);
            RETURN;
        END

        -- Actualiza los datos del avion excepto la matricula
        UPDATE Aviones
        SET marca = @marca,
            capacidadPasajeros = @cantidadPasajeros
        WHERE matricula = @matricula;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
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


CREATE PROCEDURE ObtenerAviones
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        av.matricula,
        av.marca,
        av.capacidadPasajeros,
        av.estado
    FROM 
        Aviones av
    WHERE 
        NOT EXISTS (
            SELECT 1
            FROM AvionesAerolinea aa
            WHERE aa.matricula = av.matricula
        );
END
GO


-- Cambia el estado de la aviones a desactivado = (0)
CREATE PROC Desactivar_Aviones
(
    @matricula VARCHAR(50)
)
AS
BEGIN
    BEGIN TRY
        -- Actualiza el estado del avion a 0 para desactivarlo
        UPDATE Aviones
        SET estado = 0
        WHERE matricula = @matricula;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
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


------------ STORED FIN PROCEDURES PARA AVIONES ------------








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

--Busca a un ´piloto segun su nombre, apellidos, cedula o nombre de aerolinea a la que pertenece
CREATE PROC Search_Pilot @searchValue VARCHAR(150)
AS
BEGIN 
	BEGIN TRY
		SELECT p.idPiloto, p.cedulaPiloto, CONCAT(p.nombre, ' ', p.apellidoPat, ' ', p.apellidoMat) AS nombreCompleto, p.nacionalidad, a.nombre, p.estado
		FROM Pilotos AS p
		INNER JOIN Aerolineas AS a ON p.idAerolinea = a.idAerolinea
		WHERE p.nombre LIKE @searchValue OR  p.apellidoPat LIKE @searchValue OR p.apellidoMat LIKE @searchValue
			OR p.cedulaPiloto LIKE @searchValue + '%' OR a.nombre LIKE @searchValue + '%' OR p.nombre @searchValue + '%' OR p.apellidoPat + '%' OR p.apellidoMat + '%';
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

-------------STORED PROCEDURES PARA PILOTOS --------------------------}
--Info pilotos
CREATE PROC Get_Pilots_Data
AS
BEGIN 
	BEGIN TRY
		SELECT p.idPiloto, p.cedulaPiloto, CONCAT(p.nombre, ' ', p.apellidoPat, ' ', p.apellidoMat) AS nombreCompleto, p.nacionalidad, a.nombre, p.estado
		FROM Pilotos AS p
		INNER JOIN Aerolineas AS a ON p.idAerolinea = a.idAerolinea
		ORDER BY 
			CASE
				WHEN p.estado = 0
				THEN 1
				ELSE 0
			END,
			idPiloto ASC;
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

--Existencia cedula
CREATE PROC Identity_Exist 
	(@identity VARCHAR(150), @idPilot INT)
AS
BEGIN 
	BEGIN TRY
		SELECT 1
		FROM Pilotos
		WHERE cedulaPiloto = @identity AND idPiloto != @idPilot;
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

--Añadir Piloto
CREATE PROC Insert_Pilot 
	(@identity VARCHAR(150), 
	@lastName1 VARCHAR(150),
	@lastname2 VARCHAR(150),
	@name VARCHAR(150),
	@country VARCHAR(150),
	@airline INT)
AS
BEGIN 
	BEGIN TRY
		INSERT INTO Pilotos
		VALUES(@identity,
			@lastName1,
			@lastname2,
			@name,
			@country,
			@airline,
			1);
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

--Modifica el Piloto
CREATE PROC Update_Pilot 
	(@id INT,
	@identity VARCHAR(150), 
	@lastName1 VARCHAR(150),
	@lastname2 VARCHAR(150),
	@name VARCHAR(150),
	@country VARCHAR(150),
	@airline INT)
AS
BEGIN 
	BEGIN TRY
		UPDATE Pilotos
		SET cedulaPiloto = @identity,
			apellidoPat = @lastName1,
			apellidoMat = @lastname2,
			nombre = @name,
			nacionalidad = @country,
			idAerolinea = @airline
		WHERE idPiloto = @id;
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

--Cambia el estdo del Piloto
CREATE PROC Delete_Pilot @id INT
AS
BEGIN 
	BEGIN TRY
		UPDATE Pilotos
		SET estado = 0
		WHERE idPiloto = @id;
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

--IdAerolinea del piloto actual
CREATE PROC Get_IdAirline @idPilot INT
AS
BEGIN 
	BEGIN TRY
		SELECT idAerolinea
		FROM Pilotos
		WHERE idPiloto = @idPilot;
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

--------------------FIN STORED PROCEDURES PILOTOS----------------------------------

--------------------Inicio STORED PROCEDURES Documentos----------------------------------

DROP PROC Airplanes_Airlines

CREATE PROCEDURE Airplanes_Airlines
AS
BEGIN
    -- Selects airline name and airplane data
    SELECT 
        a.nombre AS AirlineName,
        av.marca AS AirplaneBrand,
        av.matricula AS AirplaneRegistration,
        av.capacidadPasajeros AS PassengerCapacity,
        av.estado AS AirplaneStatus
    FROM 
        Aerolineas a
    INNER JOIN 
        AvionesAerolinea aa ON a.idAerolinea = aa.idAerolinea
    INNER JOIN 
        Aviones  av ON aa.matricula = av.matricula
    ORDER BY 
        a.nombre, av.matricula;
END;
GO



CREATE PROCEDURE GetAirlineFlightsByNames
    @Name VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        SELECT 
            a.idAerolinea AS AirlineId,
            a.nombre AS AirlineName,
            v.idVuelo AS FlightId,
            c1.ciudad AS OriginCity,
            c2.ciudad AS DestinationCity,
            v.fechaHoraPartida AS DepartureTime,
            v.fechaHoraLlegada AS ArrivalTime
        FROM 
            Aerolineas a
            JOIN Vuelos v ON a.idAerolinea = v.idAerolinea
            JOIN Ciudades c1 ON v.codigoCiudadPartida = c1.codigoCiudad
            JOIN Ciudades c2 ON v.codigoCiudadDestino = c2.codigoCiudad
        WHERE 
            a.nombre LIKE '%' + @Name + '%';
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

CREATE PROCEDURE GetAirplanesByAirlineName
    @AirlineName VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        SELECT 
            a.nombre AS AirlineName,
            av.marca AS AirplaneBrand,
            av.matricula AS AirplaneRegistration,
            av.capacidadPasajeros AS PassengerCapacity,
            av.estado AS AirplaneStatus
        FROM 
            Aerolineas a
        INNER JOIN 
            AvionesAerolinea aa ON a.idAerolinea = aa.idAerolinea
        INNER JOIN 
            Aviones av ON aa.matricula = av.matricula
        WHERE 
            a.nombre LIKE '%' + @AirlineName + '%'
        ORDER BY 
            a.nombre, av.matricula;
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


CREATE PROCEDURE GetFlightDetails
AS
BEGIN
    BEGIN TRY
        SELECT 
            a.nombre AS AirlineName,
            v.idVuelo AS FlightId,
            c1.ciudad AS OriginCity,
            c2.ciudad AS DestinationCity,
            v.fechaHoraPartida AS DepartureTime,
            v.fechaHoraLlegada AS ArrivalTime
        FROM 
            Vuelos v
        INNER JOIN 
            Aerolineas a ON v.idAerolinea = a.idAerolinea
        INNER JOIN 
            Ciudades c1 ON v.codigoCiudadPartida = c1.codigoCiudad
        INNER JOIN 
            Ciudades c2 ON v.codigoCiudadDestino = c2.codigoCiudad;
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


INSERT INTO Aviones (marca, matricula, capacidadPasajeros, estado)
VALUES
('Boeing', 'N12345', 90, 1),
('Airbus', 'A67890', 70, 1),
('Embraer', 'E23456', 65, 1),
('Bombardier', 'B78901', 80, 1),
('Cessna', 'C34567', 50, 1);
GO


INSERT INTO AvionesAerolinea (matricula, idAerolinea)
VALUES
('N12345', 1),
('A67890', 1),
('E23456', 2),
('B78901', 2),
('C34567', 1);
GO


INSERT INTO Pilotos (cedulaPiloto, nacionalidad,apellidoPat, apellidoMat, nombre, estado, idAerolinea)
VALUES
('123456','Costa Rica' ,'Perez', 'Lopez', 'Juan', 1, 1),
('234567', 'Costa Rica' ,'Garcia', 'Martinez', 'Carlos', 1, 1),
('345678', 'Costa Rica' ,'Rodriguez', 'Hernandez', 'Luis', 1, 2),
('456789','Costa Rica' , 'Fernandez', 'Gomez', 'Jorge', 1, 2),
('567890','Costa Rica' , 'Gonzalez', 'Diaz', 'Ana', 1,2 );
GO


INSERT INTO Ciudades (codigoCiudad, pais, canton, distrito, ciudad)
VALUES
('SJO', 'Costa Rica', 'San Jose', 'Carmen', 'San Jose'),
('LAX', 'USA', 'California', 'Los Angeles', 'Los Angeles'),
('NYC', 'USA', 'New York', 'Manhattan', 'New York'),
('MAD', 'Spain', 'Madrid', 'Centro', 'Madrid'),
('CDG', 'France', 'Ile-de-France', 'Paris', 'Paris');
GO


INSERT INTO Vuelos (idAerolinea, idAvion, cedulaPiloto, fechaHoraPartida, fechaHoraLlegada, codigoCiudadPartida, codigoCiudadDestino, estado)
VALUES
( 1, 1, '123456', '2024-06-06 08:00:00', '2024-06-06 12:00:00', 'SJO', 'LAX', 1),
( 1, 2, '234567', '2024-06-07 09:00:00', '2024-06-07 13:00:00', 'SJO', 'NYC', 1),
( 2, 3, '345678', '2024-06-08 10:00:00', '2024-06-08 14:00:00', 'LAX', 'MAD', 1),
( 2, 4, '456789', '2024-06-09 11:00:00', '2024-06-09 15:00:00', 'NYC', 'CDG', 1),
( 1, 5, '567890', '2024-06-10 12:00:00', '2024-06-10 16:00:00', 'MAD', 'SJO', 1);
GO



