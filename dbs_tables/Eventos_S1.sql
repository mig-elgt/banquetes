
CREATE TABLE Cliente_1
(
	Id_Cliente INTEGER NOT NULL,
	Id_Tipo_Cliente INTEGER NOT NULL,
	Nombre	VARCHAR(30),
	Apellido_Paterno VARCHAR(30)
	Apellido_Materno VARCHAR(30)
	Direccion VARCHAR(50),
	Telefono VARCHAR(10),
	Ciudad VARCHAR(50),
	Email VARCHAR(50),

	CONSTRAINT PK_CLIENTE PRIMARY KEY Id_Cliente,
);

CREATE TABLE Tipo_Cliente_1
(
	Id_Tipo INTEGER NOT NULL,
	Tipo	VARCHAR(20),

	CONSTRAINT PK_TIPO PRIMARY KEY Id_Tipo
);

INSERT INTO Tipo_Cliente_1 VALUES("Empresa");
INSERT INTO Tipo_Cliente_1 VALUES("Instituto");
INSERT INTO Tipo_Cliente_1 VALUES("Civil");

CREATE TABLE Empleado_1
(
	Id_Empleado INTEGER NOT NULL,
	Id_Tipo_Empleado INTEGER NOT NULL,
	Nombre	VARCHAR(30),
	Apellido_Paterno VARCHAR(30),
	Apellido_Materno VARCHAR(30),
	Fecha_Nacimiento	Date,
	Direccion VARCHAR(50),
	Telefono VARCHAR(10),
	Email VARCHAR(50),

	CONSTRAINT PK_EMPLEADO PRIMARY KEY Id_Empleado,
);

CREATE TABLE Salon_1
(
	Id_Salon INTEGER NOT NULL,
	Nombre	VARCHAR(20) NOT NULL,
	Cupo_Max	INTEGER NOT NULL,

	CONSTRAINT PK_SALON PRIMARY KEY Id_Salon
);

INSERT INTO Salon_1("Casa Real",350);
INSERT INTO Salon_1("La mansion",1100);
INSERT INTO Salon_1("Jardin",450);

CREATE TABLE Tipo_Evento_1
(
	Id_Tipo_Evento INTEGER NOT NULL,
	Nombre	VARCHAR(20) NOT NULL,
	
	CONSTRAINT PK_TIPO_EVENTO PRIMARY KEY Id_Tipo_Evento
);

INSERT INTO Tipo_Evento_1 VALUES("Desayuno");
INSERT INTO Tipo_Evento_1 VALUES("Comida");
INSERT INTO Tipo_Evento_1 VALUES("Cena");

CREATE TABLE Categoria_1
(
	Id_Categoria INTEGER NOT NULL,
	Nombre	VARCHAR(20),
	
	CONSTRAINT PK_CAT PRIMARY KEY Id_Categoria
);

INSERT INTO Categoria_1 VALUES("Bautizo");
INSERT INTO Categoria_1 VALUES("XV años");
INSERT INTO Categoria_1 VALUES("Boda");
INSERT INTO Categoria_1 VALUES("Graduacion");
INSERT INTO Categoria_1 VALUES("Posada");
INSERT INTO Categoria_1 VALUES("Cumpleaños");
INSERT INTO Categoria_1 VALUES("Otros");


CREATE TABLE Evento_1
(
	Id_Evento INTEGER NOT NULL,
	Id_Cliente INTEGER NOT NULL,
	Id_Salon INTEGER NOT NULL,
	Id_Banquete INTEGER NOT NULL,
	Id_Tipo_Evento INTEGER NOT NULL,
	Id_Categoria INTEGER NOT NULL,
	Fecha_Inicial DATETIME NOT NULL,
	Fecha_Final DATETIME NOT NULL,
	Total FLOAT NOT NULL,
	
	CONSTRAINT PK_EVENTO PRIMARY KEY Id_Evento
);

CREATE TABLE Musico_1
(
	id_Musico INTEGER NOT NULL,
	id_Tipo_Musica INTEGER NOT NULL,
	Director VARCHAR(50) NOT NULL,
	Direccion VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Logo_Img VARCHAR(100) NOT NULL,
	Costo_Hora FLOAT NOT NULL,
	Disponible BOOLEAN NOT NULL,

	CONSTRAINT PK_MUSICO PRIMARY KEY id_Musico
);
