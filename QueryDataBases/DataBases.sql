CREATE DATABASE Vacaciones
GO

USE Vacaciones
GO

CREATE TABLE Empleados(
NumEmpleado INT PRIMARY KEY IDENTITY(2000,1),
PNombre NCHAR(50) NOT NULL,
SNombre NCHAR(50) DEFAULT 'XXX',
PApellido NCHAR(50)NOT NULL,
SApellido NCHAR(50)DEFAULT 'XXX',
TipoIdentificacion VARCHAR(50) NOT NULL,
NIdentificacion VARCHAR(20)NOT NULL UNIQUE,
FechaIngreso DATE NOT NULL,
Salario MONEY NOT NULL,
Direccion TEXT NOT NULL
)
GO

INSERT INTO Empleados(PNombre,PApellido,TipoIdentificacion,NIdentificacion,FechaIngreso,Salario,Direccion) VALUES('Admin','Admin','CEDULA','000-000000-00000',GETDATE(),0,'.')
GO

CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY(1,1),
Usuario VARCHAR(50) NOT NULL,
Pwd varbinary(8000) NOT NULL,
FK_Empleado INT UNIQUE,
FOREIGN KEY (FK_Empleado) REFERENCES Empleados(NumEmpleado)
)
GO

INSERT INTO Users VALUES('Admin',dbo.Encriptar('Admin12345'),2000)
GO

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



/*PRECEDIMIENTOS*/
/*lOGIN*/
CREATE PROCEDURE UsersLogin(
@User VARCHAR(50),
@Pass VARCHAR(50)
)
AS
	BEGIN
		SELECT U.Id,UPPER(E.PNombre),UPPER(E.SNombre),UPPER(E.PApellido),UPPER(E.SApellido) FROM Users AS U
		INNER JOIN Empleados AS E ON E.NumEmpleado = U.FK_Empleado
		WHERE U.Usuario = @User and dbo.Desencriptar(U.Pwd) = @Pass
	END
GO
/*ENDLOGIN*/

