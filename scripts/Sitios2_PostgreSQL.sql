CREATE TABLE Tipo_Platillo_2
(
	Id_Tipo_Platillo INTEGER NOT NULL,
	Tipo_Platillo VARCHAR(30) NOT NULL
);

INSERT INTO Tipo_Platillo_2 VALUES (0,'Entremes');
INSERT INTO Tipo_Platillo_2 VALUES(1,'Crema');
INSERT INTO Tipo_Platillo_2 VALUES(2,'Sopa');
INSERT INTO Tipo_Platillo_2 VALUES(3,'Fuerte');
INSERT INTO Tipo_Platillo_2 VALUES(4,'Postre');
INSERT INTO Tipo_Platillo_2 VALUES(5,'Niño');

select * from Tipo_Platillo_2;

CREATE TABLE Platillo_2
(
	Id_Platillo INTEGER NOT NULL,
	Id_Tipo_Platillo INTEGER NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Imagen_Url VARCHAR(200) NOT NULL,
	Precio DECIMAL NOT NULL
);

CREATE TABLE Cliente_2
(
	Id_Cliente INTEGER NOT NULL,
	Id_Tipo_Cliente INTEGER NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Apellido_Paterno VARCHAR(50) NULL,
	Apellido_Materno VARCHAR(50) NULL,
	Direccion VARCHAR(50) NOT NULL,
	Telefono VARCHAR(10) NOT NULL,
	Ciudad VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NULL
);

CREATE TABLE Empleado_2
(
	Id_Empleado INTEGER NOT NULL,
	Id_Tipo_Empleado INTEGER NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Apellido_Paterno VARCHAR(50) NULL,
	Apellido_Materno VARCHAR(50) NULL,
	Fecha_Nacimiento DATE NOT NULL,
	Direccion VARCHAR(50) NOT NULL,
	Telefono VARCHAR(10) NOT NULL,
	Email VARCHAR(50) NULL,
	Fecha_Ingreso DATE NULL DEFAULT CURRENT_DATE
);

CREATE TABLE Tipo_Musica_2
(
	Id_Tipo_Musica INTEGER NOT NULL,
	Genero VARCHAR(30) NOT NULL
);

INSERT INTO Tipo_Musica_2 VALUES (0,'Mariachi');
INSERT INTO Tipo_Musica_2 VALUES(1,'Banda');
INSERT INTO Tipo_Musica_2 VALUES(2,'SonidoDj');
INSERT INTO Tipo_Musica_2 VALUES(3,'Grupo');


CREATE TABLE Musico_2
(
	Id_Musico INTEGER NOT NULL,
	Id_Tipo_Musica INTEGER NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Director VARCHAR(50) NOT NULL,
	Direccion VARCHAR(50) NOT NULL,
	Email VARCHAR(100) NULL,
	Telefono VARCHAR(10) NOT NULL,
	Logo VARCHAR(200) NOT NULL,
	Costo_Hora DECIMAL NOT NULL,
	Disponible INTEGER NOT NULL
);

CREATE TABLE Banquete_2
(
	Id_Banquete INTEGER NOT NULL,
	Num_Invitados INTEGER NOT NULL,
	Fecha_Creacion DATE NOT NULL,
	Costo DECIMAL(10,2) NOT NULL
);

CREATE TABLE Detalle_Banquete_2
(
	Id_Banquete INTEGER NOT NULL,
	Id_Platillo INTEGER NOT NULL,
	Cantidad INTEGER NOT NULL,
	SubTotal DECIMAL(10,2) NOT NULL	
);

CREATE TABLE Evento_2
(
	Id_Evento INTEGER NOT NULL,
	Id_Cliente INTEGER NOT NULL,
	Id_Salon INTEGER NOT NULL,
	Id_Banquete INTEGER NOT NULL,
	Id_Tipo_Evento INTEGER NOT NULL,
	Id_Categoria INTEGER NOT NULL,
	Fecha TIMESTAMP NOT NULL,
	Costo_Total DECIMAL(10,2) NOT NULL
);

CREATE TABLE Musicos_X_Evento_2
(
	Id_Evento INTEGER NOT NULL,
	Id_Musico INTEGER NOT null,
	Hora_Inicial TIMESTAMP NOT NULL,
	Hora_Final TIMESTAMP NOT NULL,
	Eliminado INTEGER NOT NULL,

	CONSTRAINT PK_MUS PRIMARY KEY (Id_Evento,Id_Musico,Hora_Inicial,Hora_Final,Eliminado)
);


