Create database EmpleadosDb
go
Use EmpleadosDb
go
Create table Empleados(
	EmpleadoId int primary key identity,
	Fecha date,
	Nombres varchar(60),
	Direccion varchar(50),
	Telefono varchar(15),
	Celular varchar(12),
	Cedula varchar(15),
	Sueldo decimal(18,2),
	Incentivo decimal(18,2)
);