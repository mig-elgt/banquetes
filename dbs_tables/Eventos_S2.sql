CREATE TABLE Cliente_2
(
	Id_Cliente INTEGER NOT NULL,
	Id_Tipo_Cliente INTEGER NOT NULL,
	Nombre	VARCHAR(30),
	Apellido_Paterno VARCHAR(30),
	Apellido_Materno VARCHAR(30),
	Direccion VARCHAR(50),
	Telefono VARCHAR(10),
	Ciudad VARCHAR(50),
	Email VARCHAR(50),

	CONSTRAINT PK_CLIENTE PRIMARY KEY Id_Cliente,
);

CREATE TABLE Empleado_2
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

	CONSTRAINT PK_EMPLEADO PRIMARY KEY Id_Empleado
);

CREATE TABLE Tipo_Platillo_2
(
	Id_Tipo_Platillo INTEGER NOT NULL,
	Nombre VARCHAR(20) NOT NULL,

	CONSTRAINT PK_TIPO_PLAT PRIMARY KEY Id_Tipo_Platillo
);

INSERT INTO Tipo_Platillo_2 VALUES("Entrada");
INSERT INTO Tipo_Platillo_2 VALUES("Crema");
INSERT INTO Tipo_Platillo_2 VALUES("Sopa");
INSERT INTO Tipo_Platillo_2 VALUES("Fuerte");
INSERT INTO Tipo_Platillo_2 VALUES("Postre");
INSERT INTO Tipo_Platillo_2 VALUES("Niño");

CREATE TABLE Platillo_2
(
	Id_Platillo INTEGER NOT NULL,
	Id_Tipo_Platillo INTEGER NOT NULL,
	Nombre VARCHAR(30),
	Image VARCHAR(100),
	Precio DOUBLE,

	CONSTRAINT PK_EVENTO PRIMARY KEY Id_Platillo
);

CREATE TABLE Banquetes_2
(
	Id_Banquete INTEGER NOT NULL,
	Num_Personas INTEGER NOT NULL,
	Fecha DATE NOT NULL,
	Total FLOTA NOT NULL,

	CONSTRAINT PK_BANQUETE PRIMARY KEY Id_Banquete
);

CREATE TABLE Detalle_Banquete_2
(
	Id_Banquete INTEGER NOT NULL,
	Id_Platillo INTEGER NOT NULL,
	Cantidad DOUBLE,
	SubTotal DOUBLE,
	
	CONSTRAINT PK_BANQUETE PRIMARY KEY Id_Banquete
);

CREATE TABLE Evento_2
(
	Id_Evento INTEGER NOT NULL,
	Id_Cliente INTEGER NOT NULL,
	Id_Salon INTEGER NOT NULL,
	Id_Banquete INTEGER NOT NULL,
	Id_Tipo_Evento INTEGER NOT NULL,
	Id_Categoria INTEGER NOT NULL,
	Fecha_Inicial DATETIME,
	Fecha_Final DATETIME,
	Total FLOAT NOT NULL,

	CONSTRAINT PK_EVENTO PRIMARY KEY Id_Evento
);

CREATE TABLE Tipo_Musica_2
(
	Id_Tipo_Musica INTEGER NOT NULL PRIMARY KEY,
	Genero VARCHAR(50) NOT NULL,	
);

INSERT INTO Tipo_Musica_2 VALUES("Mariachi");
INSERT INTO Tipo_Musica_2 VALUES("Banda");
INSERT INTO Tipo_Musica_2 VALUES("Sonido");
INSERT INTO Tipo_Musica_2 VALUES("Grupo");

CREATE TABLE Musico_2
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








