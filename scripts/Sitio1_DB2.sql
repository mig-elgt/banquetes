CREATE TABLE Salon_1
(
	Id_Salon INTEGER,
	Nombre_Salon VARCHAR(50),
	Cupo_Max INTEGER
);

INSERT INTO Salon_1 VALUES(0,'Parafernalia',500)
INSERT INTO Salon_1 VALUES(1,'Cruz de Celia',200)
INSERT INTO Salon_1 VALUES(2,'Candiles',300)
INSERT INTO Salon_1 VALUES(3,'Escenario',600)
INSERT INTO Salon_1 VALUES(4,'Frances',400)
INSERT INTO Salon_1 VALUES(5,'Villa Danieli',800)
INSERT INTO Salon_1 VALUES(6,'Champac',500)

CREATE TABLE Tipo_Cliente_1
(
	Id_Cliente INTEGER,
	Nombre_Cliente VARCHAR(50)
);

INSERT INTO Tipo_Cliente_1 VALUES(0,'Empresa')
INSERT INTO Tipo_Cliente_1 VALUES(1,'Instituto')
INSERT INTO Tipo_Cliente_1 VALUES(2,'Civil')

CREATE TABLE Categoria_1
(
	Id_Categoria INTEGER NOT NULL,
	Nombre_Categoria VARCHAR(50) NOT NULL
);

INSERT INTO Categoria_1 VALUES(0,'Bautizo')
INSERT INTO Categoria_1 VALUES(1,'Mis XV')
INSERT INTO Categoria_1 VALUES(2,'Boda')
INSERT INTO Categoria_1 VALUES(3,'Graduacion')
INSERT INTO Categoria_1 VALUES(4,'Posada')
INSERT INTO Categoria_1 VALUES(5,'Otro')

CREATE TABLE Tipo_Evento_1
(
	Id_Tipo_Evento INTEGER NOT NULL,
	Nombre_Tipo_Evento VARCHAR(20) NOT NULL
);

INSERT INTO Tipo_Evento_1 VALUES(0,'Desayuno')
INSERT INTO Tipo_Evento_1 VALUES(1,'Comida')
INSERT INTO Tipo_Evento_1 VALUES(2,'Cena')


CREATE TABLE Cliente_1
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
)

CREATE TABLE Empleado_1
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
	Fecha_Ingreso DATE NULL DEFAULT CURRENT_DATE,
);

CREATE TABLE Evento_1
(
	Id_Evento INTEGER NOT NULL,
	Id_Cliente INTEGER NOT NULL,
	Id_Salon INTEGER NOT NULL,
	Id_Banquete INTEGER NOT NULL,
	Id_Tipo_Evento INTEGER NOT NULL,
	Id_Categoria INTEGER NOT NULL,
	Fecha TIMESTAMP NOT NULL,
	Costo_Total DECIMAL(10,2) NOT NULL,
)

CREATE TABLE Musico_1
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
	Disponible INTEGER NOT NULL,
	Eliminado INTEGER NOT NULL
)











