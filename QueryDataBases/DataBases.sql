CREATE DATABASE Vacaciones
GO

USE Vacaciones
GO

CREATE TABLE Empleados(
NumEmpleado INT PRIMARY KEY IDENTITY(2000,1),
PNombre NCHAR(50) NOT NULL,
SNombre NCHAR(50),
PApellido NCHAR(50)NOT NULL,
SApellido NCHAR(50),
TipoIdentificacion VARCHAR(50) NOT NULL,
NIdentificacion VARCHAR(20)NOT NULL UNIQUE,
FechaIngreso DATE NOT NULL,
Salario MONEY NOT NULL,
Direccion TEXT NOT NULL
)
GO

INSERT INTO Empleados(PNombre,PApellido,TipoIdentificacion,NIdentificacion,FechaIngreso,Salario,Direccion) VALUES('Admin','Admin','CEDULA','000-000000-00000',GETDATE(),0,'.')
GO
