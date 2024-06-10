CREATE DATABASE DBNegocio;
GO
USE DBNegocio;

CREATE TABLE Usuario(
[IDUsuario] INT IDENTITY (1,1) PRIMARY KEY,
[DNI] INT UNIQUE,
[NombreUsuario] NVARCHAR(100) UNIQUE NOT NULL,
[Contrasena] NVARCHAR(100) NOT NULL,
[Nombre] NVARCHAR(100) NOT NULL,
[Apellido] NVARCHAR(100) NOT NULL,
[TipoUsuario] NVARCHAR(20) NOT NULL,
[Email] NVARCHAR(150) UNIQUE NOT NULL,
[EstadoUsuario] NVARCHAR(9) DEFAULT 'Activo' NOT NULL
);

--CONTRAINTS
ALTER TABLE Usuario ADD CONSTRAINT TipoUsuarioCorrecto 
	CHECK (TipoUsuario='Administrador' OR TipoUsuario='Vendedor');

ALTER TABLE Usuario ADD CONSTRAINT EstadoUsuarioCorrecto
	CHECK (EstadoUsuario='Activo' OR EstadoUsuario='Inactivo');


SELECT * FROM Usuario; --Ver Tabla

SELECT * FROM Usuario WHERE NombreUsuario='frankadmin' COLLATE Modern_Spanish_CI_AS; --No distiguen entre mayusculas y minusculas

SELECT * FROM Usuario WHERE NombreUsuario='frankadmin' COLLATE SQL_Latin1_General_CP1_CS_AS 
AND Contrasena='2' COLLATE SQL_Latin1_General_CP1_CS_AS; --Distingue entre mayusculas y minusculas

INSERT INTO Usuario VALUES(40001111,'FrankAdmin','123','Franco','Fernandez','Administrador','f.francodaniel@yahoo.com','Activo');
INSERT INTO Usuario VALUES(40002222,'PepeVende','Juan123.','Juan','Gomez','Vendedor','juan@yahoo.com','Activo');

update Usuario set Contrasena = '123' where NombreUsuario = 'FrankAdmin';

--Procedimiento Crear Usuario
CREATE PROCEDURE PA_CrearUsuario
 @DNI INT,
 @NombreUsuario NVARCHAR(100),
 @Contrasena NVARCHAR(100),
 @Nombre NVARCHAR(100),
 @Apellido NVARCHAR(100),
 @TipoUsuario NVARCHAR(20),
 @Email NVARCHAR(150),
 @EstadoUsuario NVARCHAR(9)
AS
BEGIN TRY
	BEGIN TRAN
		INSERT INTO Usuario VALUES(@DNI,@NombreUsuario,@Contrasena,@Nombre,@Apellido,@TipoUsuario,@Email,@EstadoUsuario);
		COMMIT
END TRY
BEGIN CATCH
	ROLLBACK TRAN
END CATCH


 --Procedimiento Editar Usuario
 DROP PROCEDURE PA_EditarUsuario;
 GO
 CREATE PROCEDURE PA_EditarUsuario
 @NombreUsuario NVARCHAR(100),
 @ActualContrasena NVARCHAR(100),
 @NuevaContrasena NVARCHAR(100),
 @Nombre NVARCHAR(100),
 @Apellido NVARCHAR(100),
 @Email NVARCHAR(150)
AS
BEGIN TRY
	BEGIN TRAN
	  UPDATE Usuario set 
	  Contrasena = @NuevaContrasena, 
	  Nombre = @Nombre, 
	  Apellido = @Apellido, 
	  Email = @Email 
	  where NombreUsuario = @NombreUsuario AND Contrasena = @ActualContrasena
	COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH


DROP PROCEDURE PA_CambiarContrasena
GO
CREATE PROCEDURE PA_CambiarContrasena
 @NombreUsuario NVARCHAR(100),
 @NuevaContrasena NVARCHAR(100)
AS
BEGIN TRY
	BEGIN TRAN 
		UPDATE Usuario SET
		Contrasena = @NuevaContrasena
		WHERE NombreUsuario = @NombreUsuario
		COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH