CREATE TABLE Cliente_3
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

	CONSTRAINT PK_CLIENTE PRIMARY KEY Id_Cliente
);

CREATE TABLE Tipo_Empleado_3
(
	Id_Tipo_Empleado INTEGER NOT NULL,
	Puesto	VARCHAR(20),
	Sueldo	DOUBLE,

	CONSTRAINT PK_TIPO PRIMARY KEY Id_Tipo_Empleado
);

INSERT INTO Tipo_Empleado_3("Mesero",350);
INSERT INTO Tipo_Empleado_3("Cocinero",450);
INSERT INTO Tipo_Empleado_3("Coordinador",500);
INSERT INTO Tipo_Empleado_3("Garrotero",250);
INSERT INTO Tipo_Empleado_3("Barman",300);
INSERT INTO Tipo_Empleado_3("Portero",250);

CREATE TABLE Empleado_3
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

CREATE TABLE Evento_3
(
	Id_Evento INTEGER NOT NULL,
	Id_Cliente INTEGER NOT NULL,
	Id_Salon INTEGER NOT NULL,
	Id_Banquete INTEGER NOT NULL,
	Id_Tipo_Evento INTEGER NOT NULL,
	Id_Categoria INTEGER NOT NULL,
	Fecha_Inicial DATETIME,
	Total FLOAT NOT NULL,
	
	CONSTRAINT PK_EVENTO PRIMARY KEY Id_Evento
);

CREATE TABLE Eventos_X_Empleado_3
(
	Codigo INTEGER NOT NULL,
	Id_Evento INTEGER NOT NULL,
	Id_Empleado INTEGER NOT NULL,

	CONSTRAINT PK_EXP PRIMARY KEY Codigo
);

CREATE TABLE Platillo_3
(
	Id_Platillo INTEGER NOT NULL,
	Ingredientes VARCHAR(100),
	Preparacion VARCHAR(200),
	
	CONSTRAINT PK_PLATILLO PRIMARY KEY Id_Platillo
);

CREATE TABLE Banquetes_3
(
	Id_Banquete INTEGER NOT NULL,
	Num_Personas INTEGER,
	Fecha DATE
	Total FLOAT,

	CONSTRAINT PK_BANQUETE PRIMARY KEY Id_Banquete
);

CREATE TABLE Detalle_Banquete_3
(
	Id_Banquete INTEGER NOT NULL,
	Id_Platillo INTEGER NOT NULL,
	Cantidad DOUBLE,
	SubTotal DOUBLE,
	
	CONSTRAINT PK_BANQUETE PRIMARY KEY Id_Banquete
);

CREATE TABLE Musico_3
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

CREATE TABLE Eventos_X_Musico
(
	Id_Evento INTEGER NOT NULL,
	Id_Musico INTEGER NOT NULL,
	Hora_Inicial TIME NOT NULL,
	Hora_Final TIME NOT NULL,

	CONSTRAINT PK_EVE PRIMARY KEY(Id_Evento,Id_Musico)
);