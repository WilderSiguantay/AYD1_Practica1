Create database Practica1;

USE Practica1;

Create table Persona(
id_persona int identity(1,1) primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Sexo Bit not null,
Edad int not null,
Ingresos numeric(9,2) not null
)

Drop table Persona;

INSERT INTO Persona(Nombre, Apellido, Edad, Sexo, Ingresos) VALUES(null, 'apellido prueba', 18, 1, 2000);

select * from persona;