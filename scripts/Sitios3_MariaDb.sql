
CREATE TABLE Platillo_3
(
	Id_Platillo INTEGER NOT NULL,
	Ingredientes VARCHAR(300),
	Preparacion VARCHAR(400)
);

insert into platillo_3(Ingredientes,Preparacion) values('Crema','Pasos de la receta');
truncate platillo_3

CREATE TABLE Cliente_3
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

CREATE TABLE Tipo_Empleado_3
(
	Id_Tipo_Empleado INTEGER NOT NULL,
	Puesto VARCHAR(20) NOT NULL,
	Sueldo DECIMAL NOT NULL
);

INSERT INTO Tipo_Empleado_3 values(0,'Mesero',350);
INSERT INTO Tipo_Empleado_3 values(1,'Cocinero',550);
INSERT INTO Tipo_Empleado_3 values(2,'Coordinador',650);

CREATE TABLE Empleado_3
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
	Fecha_Ingreso DATE NOT NULL
);

CREATE TABLE Musico_3
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

CREATE TABLE Banquete_3
(
	Id_Banquete INTEGER NOT NULL,
	Num_Invitados INTEGER NOT NULL,
	Fecha_Creacion DATE NOT NULL,
	Costo DECIMAL(10,2) NOT NULL
);

CREATE TABLE Detalle_Banquete_3
(
	Id_Banquete INTEGER NOT NULL,
	Id_Platillo INTEGER NOT NULL,
	Cantidad INTEGER NOT NULL,
	SubTotal DECIMAL(10,2) NOT NULL	
);

CREATE TABLE Evento_3
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

CREATE TABLE Empleados_X_Evento_3
(
	Id_Evento INTEGER NOT NULL,
	Id_Empleado INTEGER NOT NULL,

	CONSTRAINT PK_EMP PRIMARY KEY(Id_Evento, Id_Empleado)
);