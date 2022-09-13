CREATE DATABASE Vacaciones
GO

USE Vacaciones
GO

CREATE TABLE Empleados(
NumEmpleado INT PRIMARY KEY IDENTITY(2000,1),
PNombre VARCHAR(50) NOT NULL,
SNombre VARCHAR(50) DEFAULT 'XXX',
PApellido VARCHAR(50)NOT NULL,
SApellido VARCHAR(50)DEFAULT 'XXX',
TipoIdentificacion VARCHAR(50) NOT NULL,
NIdentificacion VARCHAR(20)NOT NULL UNIQUE,
FechaIngreso DATE NOT NULL,
Salario MONEY NOT NULL,
Direccion TEXT NOT NULL
)
GO

CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY(1,1),
Usuario VARCHAR(50) NOT NULL,
Pwd varbinary(8000) NOT NULL,
FK_Empleado INT UNIQUE,
FOREIGN KEY (FK_Empleado) REFERENCES Empleados(NumEmpleado)
)
GO

CREATE TABLE Vacacion(
N INT PRIMARY KEY IDENTITY(1,1),
FechaR SMALLDATETIME,
Motivo VARCHAR(20),
Descripcion TEXT NOT NULL,
FechaInicio DATE NOT NULL,
FechaFin DATE NOT NULL,
fk_Empleado INT FOREIGN KEY REFERENCES Empleados(NumEmpleado)
)
GO

CREATE TABLE Historial(
Numero INT PRIMARY KEY IDENTITY(10,1),
Descripcion VARCHAR(MAX),
Fecha SMALLDATETIME
)
GO

INSERT INTO Empleados(PNombre,PApellido,TipoIdentificacion,NIdentificacion,FechaIngreso,Salario,Direccion) VALUES('Admin','Admin','CEDULA','000-000000-00000',GETDATE(),0,'.')
GO
INSERT INTO Users VALUES('Admin',dbo.Encriptar('Admin12345'),2000)
GO


/*Funciones*/
/*Encriptado*/
CREATE FUNCTION Encriptar(@Valor NVARCHAR(MAX))
RETURNS VARBINARY(8000)
AS 
	BEGIN
		DECLARE @Resul VARBINARY(8000)
		SET @Resul = ENCRYPTBYPASSPHRASE('Key',@Valor)
		RETURN (@Resul)
	END
GO

CREATE FUNCTION Desencriptar(@Valor VARBINARY(8000))
RETURNS NVARCHAR(MAX)
AS 
	BEGIN
		DECLARE @Resul NVARCHAR(max)
		SET @Resul = DECRYPTBYPASSPHRASE('Key',@Valor)
		RETURN (@Resul)
	END
GO
/*END*/
/*Formato NIO*/
CREATE FUNCTION FormatNIO(@Valor MONEY)
RETURNS VARCHAR(15)
AS 
	BEGIN
		DECLARE @Resul VARCHAR(15)
		SET @Resul = REPLACE(FORMAT(@Valor,'C','En-Us'),'$','C$') 
		RETURN (@Resul)
	END
GO
/*END*/

/*PRECEDIMIENTOS*/
/*lOGIN*/
CREATE PROCEDURE UsersLogin(
@User VARCHAR(50),
@Pass VARCHAR(50)
)
AS
	BEGIN
		SELECT U.Id,E.PNombre,E.SNombre,E.PApellido,E.SApellido FROM Users AS U
		INNER JOIN Empleados AS E ON E.NumEmpleado = U.FK_Empleado
		WHERE U.Usuario = @User and dbo.Desencriptar(U.Pwd) = @Pass

		DECLARE @Nombre VARCHAR(20)
		DECLARE @Apellido VARCHAR(20)
		SELECT @Nombre = E.PNombre, @Apellido = E.PApellido FROM Empleados AS E
		INNER JOIN Users AS U ON  E.NumEmpleado = U.FK_Empleado WHERE U.Usuario = @User and dbo.Desencriptar(U.Pwd) = @Pass

		INSERT INTO Historial VALUES (CONCAT('Inicio de sesion de ',@Nombre,' ',@Apellido),GETDATE())
	END
GO
/*ENDLOGIN*/
/*SELECCIONAR TODO DE EMPLEADO*/
CREATE PROCEDURE SelectAll
AS
BEGIN
	SELECT NumEmpleado AS Numero,CONCAT(PNombre,' ',SNombre,' ',PApellido,' ',SApellido) AS Nombre 
	,TipoIdentificacion AS Tipo, NIdentificacion AS Identificacion ,
	FechaIngreso AS Ingreso,dbo.FormatNIO(Salario)AS Salario,Direccion FROM Empleados
END
GO
/*Seleccionar informacion del emplado*/
CREATE PROCEDURE SelectEmpl(
@Id INT
)
AS
BEGIN
	SELECT * FROM Empleados WHERE NumEmpleado = @Id
END
GO
/*FIN*/

/*ALMACENAR EMPLEADO*/

CREATE PROCEDURE InsertEmpleado(
@NMod VARCHAR(20),
@Id INT,
@NA VARCHAR(50),
@NB VARCHAR(50),
@AA VARCHAR(50),
@AB VARCHAR(50),
@TIdenti VARCHAR(50),
@NIdenti VARCHAR(50),
@Fe DATE,
@Sa MONEY,
@Dir TEXT
)AS
BEGIN
	IF(EXISTS(SELECT * FROM Empleados WHERE NumEmpleado = @Id))
	BEGIN
		UPDATE Empleados SET PNombre = @NA, SNombre = @NB,PApellido = @AA,SApellido = @AB,TipoIdentificacion = @TIdenti
		,NIdentificacion = @NIdenti,FechaIngreso = @Fe,Salario = @Sa,Direccion = @Dir WHERE NumEmpleado = @Id

		INSERT INTO Historial VALUES (CONCAT(@NMod,' modifico la información de ',@NA,' ',@AA),GETDATE()) 
	END
	ELSE
	BEGIN
		INSERT INTO Empleados 
		VALUES(@NA,@NB,@AA,@AB,@TIdenti,@NIdenti,@Fe,@Sa,@Dir)
		INSERT INTO Historial VALUES (CONCAT(@NMod,' agrego a ',@NA,' ',@AA),GETDATE()) 
	END
END
GO
/*END*/

/*PROCEDIMIENTO PARA ELIMINAR EMPLEADO*/
CREATE PROCEDURE DeleteEmpleado(
@Id INT,
@NMod VARCHAR(20)
)
AS
	DECLARE @Nombre VARCHAR(20)
	DECLARE @Apellido VARCHAR(20)
	SELECT @Nombre = PNombre,@Apellido = PApellido FROM Empleados WHERE NumEmpleado = @Id
	DELETE FROM Empleados WHERE NumEmpleado = @Id
	INSERT INTO Historial VALUES (CONCAT(@NMod,' elimino al empleado ',@Nombre,' ',@Apellido),GETDATE()) 
GO
/*FIN*/
/*Historial*/
CREATE PROCEDURE sp_Historial
AS
SELECT TOP 100 Numero,Descripcion,Fecha AS [Fecha / Hora] FROM Historial
order by Numero desc
GO

/*Procedimientos almacenados para eliminar, insertar y leer usuario*/
CREATE PROCEDURE SelectAllUsers
AS
	SELECT U.Id AS [Id Usuario],CONCAT(E.PNombre,' ',E.PApellido) AS Empleado,U.Usuario FROM Users AS U
	INNER JOIN Empleados AS E ON E.NumEmpleado = U.FK_Empleado
GO

CREATE PROCEDURE DeleteUsers(
@NMod VARCHAR(50),
@Id INT
)AS
	BEGIN
		DECLARE @Nombre VARCHAR(20)
		DECLARE @Apellido VARCHAR(20)
		SELECT @Nombre = E.PNombre,@Apellido = E.PApellido FROM Users AS U
		INNER JOIN Empleados AS E ON E.NumEmpleado = U.FK_Empleado
		WHERE U.Id = @Id

		DELETE FROM Users WHERE Id = @Id

		INSERT INTO Historial VALUES (CONCAT(@NMod,' Elimino el usuario de ',@Nombre,' ',@Apellido),GETDATE())
	END
GO

CREATE PROCEDURE InsertUsers(
@NMod VARCHAR(50),
@User VARCHAR(20),
@Contrasena VARCHAR(50),
@IdEmpleado INT
)AS
	BEGIN
		INSERT INTO Users VALUES(@User,dbo.Encriptar(@Contrasena),@IdEmpleado)
		DECLARE @Nombre VARCHAR(20)
		DECLARE @Apellido VARCHAR(20)
		SELECT @Nombre = PNombre,@Apellido = PApellido FROM Empleados WHERE NumEmpleado = @IdEmpleado
		INSERT INTO Historial VALUES (CONCAT(@NMod,' agrego un nuevo usuario de nombre ',@User,' perteneciente al empleado ',@Nombre,' ',@Apellido),GETDATE())
	END
GO
