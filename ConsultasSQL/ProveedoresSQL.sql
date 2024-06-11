DROP TABLE Proveedores;
CREATE TABLE Proveedores(
[IDProveedor] SMALLINT IDENTITY(1,1) PRIMARY KEY,
[CUIT] NVARCHAR(13) UNIQUE,
[NombreProveedor] NVARCHAR(250),
[Domicilio] NVARCHAR(250),
[Email] NVARCHAR(150),
[Telefono] NVARCHAR(15),
[CodTipoPersona] TINYINT --Fisica o Juridica
FOREIGN KEY(CodTipoPersona) REFERENCES TipoPersona(IDTipoPersona)
)


INSERT INTO Proveedores VALUES('20445566773','Pepe Cacao','Glew','pepecacao@yahoo.com','01122334455',1);

SELECT * FROM Proveedores;

SELECT SUBSTRING(CUIT,1,2),SUBSTRING(CUIT,4,8), SUBSTRING(CUIT,13,1) FROM Proveedores;

SELECT P.CUIT, P.NombreProveedor, P.Domicilio, P.Email, P.Telefono, T.TipoPersona  
FROM Proveedores AS P INNER JOIN TipoPersona AS T 
ON P.CodTipoPersona = T.IDTipoPersona;

DROP PROCEDURE PA_CrearProveedor;
CREATE PROCEDURE PA_CrearProveedor
 @CUIT NVARCHAR(13),
 @NombreProveedor NVARCHAR(250),
 @Domicilio NVARCHAR(250),
 @Email NVARCHAR(150),
 @Telefono NVARCHAR(15),
 @CodTipoPersona TINYINT
AS
 INSERT INTO Proveedores VALUES(@CUIT,@NombreProveedor,@Domicilio,@Email,@Telefono,@CodTipoPersona);

DROP PROCEDURE PA_ActualizarProveedor
CREATE PROCEDURE PA_ActualizarProveedor
 @CUIT NVARCHAR(13),
 @NombreProveedor NVARCHAR(250),
 @Domicilio NVARCHAR(250),
 @Email NVARCHAR(150),
 @Telefono NVARCHAR(15),
 @CodTipoPersona TINYINT
AS
 UPDATE Proveedores SET 
 NombreProveedor = @NombreProveedor,
 Domicilio = @Domicilio,
 Email = @Email,
 Telefono = @Telefono,
 CodTipoPersona = @CodTipoPersona
 WHERE CUIT	= @CUIT

DROP PROCEDURE PA_BorrarProveedor
CREATE PROCEDURE PA_BorrarProveedor
  @CUIT NVARCHAR(13)
AS
 DELETE FROM Proveedores WHERE CUIT = @CUIT;

DROP TABLE TipoPersona;
CREATE TABLE TipoPersona(
[IDTipoPersona] TINYINT IDENTITY(1,1) PRIMARY KEY,
[TipoPersona] VARCHAR(8)
);
INSERT INTO TipoPersona VALUES('Física');
INSERT INTO TipoPersona VALUES('Jurídica');
SELECT * FROM TipoPersona;

DROP VIEW VW_GrillaProveedores
CREATE VIEW VW_GrillaProveedores
AS
SELECT P.CUIT, P.NombreProveedor as 'Nombre Proveedor', P.Domicilio, P.Email as 'Correo Electrónico', P.Telefono as 'Teléfono'
FROM Proveedores AS P INNER JOIN TipoPersona AS T 
ON P.CodTipoPersona = T.IDTipoPersona;



--SECCION Proveedores FIN------------------------------------------------------------------------