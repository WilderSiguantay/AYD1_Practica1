Create database Practica1;

USE Practica1;

Create table Persona(
id_persona int identity(1,1) primary key,
Nombre varchar(50),
Apellido varchar(50),
Sexo Bit,
Edad int,
Ingresos numeric(5,2)
)

Drop table Persona;