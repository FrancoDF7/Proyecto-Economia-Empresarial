CREATE TABLE Clientes(
[IDCliente] INT IDENTITY(1,1) PRIMARY KEY,
[DNI] CHAR(8) UNIQUE NOT NULL,
[Nombre] NVARCHAR(50) NOT NULL,
[Apellido] NVARCHAR(50) NOT NULL,
[Domicilio] NVARCHAR(80) NOT NULL,
[Telefono] NVARCHAR(15) NOT NULL,
[Email] NVARCHAR(150) NOT NULL,
[CodIVA] TINYINT NOT NULL
FOREIGN KEY(CodIva) REFERENCES IVA(CodIVA)
);

CREATE TABLE IVA(
[CodIVA] TINYINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[CondicionIVA] NVARCHAR(21) NOT NULL
);


INSERT INTO IVA VALUES('Consumidor Final');
INSERT INTO IVA VALUES('Monotributista');
INSERT INTO IVA VALUES('Responsable Inscripto');

INSERT INTO Clientes VALUES('40112233', 'Anacleto', 'Rodriguez', 'Guernica', '01133445566', 'anacleto@yahoo.com',1);
INSERT INTO Clientes VALUES('38101010', 'Pepe', 'Pig', 'Adrogue', '0113334322', 'pepe@hotmail.com',3);

SELECT * FROM IVA
SELECT * FROM Clientes

SELECT c.DNI, c.Nombre, c.Apellido, c.Domicilio, c.Telefono, c.Email, i.CondicionIVA AS 'Condición IVA' 
FROM Clientes c INNER JOIN IVA i
ON c.CodIVA = i.CodIVA;

CREATE PROCEDURE PA_CrearCliente
 @DNI CHAR(8),
 @Nombre NVARCHAR(50),
 @Apellido NVARCHAR(50),
 @Domicilio NVARCHAR(80),
 @Telefono NVARCHAR(15),
 @Email NVARCHAR(150),
 @CodIVA TINYINT
AS
 INSERT INTO Clientes VALUES(@DNI, @Nombre, @Apellido, @Domicilio, @Telefono, @Email, @CodIVA);

CREATE PROCEDURE PA_ActualizarCliente
 @DNI CHAR(8),
 @Nombre NVARCHAR(50),
 @Apellido NVARCHAR(50),
 @Domicilio NVARCHAR(80),
 @Telefono NVARCHAR(15),
 @Email NVARCHAR(150),
 @CodIVA TINYINT
AS
 UPDATE Clientes SET Nombre=@Nombre, Apellido=@Apellido, Domicilio=@Domicilio, Telefono=@Telefono, Email=@Email, CodIVA=@CodIVA WHERE DNI=@DNI;


CREATE PROCEDURE PA_BorrarCliente