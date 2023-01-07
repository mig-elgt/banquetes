
drop database EsquemaLoc;
create database EsquemaLoc;
use EsquemaLoc;

CREATE TABLE TipoFragmento(
	id_Tipo_Frag INTEGER AUTO_INCREMENT NOT NULL PRIMARY KEY,
	Nombre_Frag VARCHAR(20)
);

INSERT INTO TipoFragmento(Nombre_Frag) VALUES('Horizontal');
INSERT INTO TipoFragmento(Nombre_Frag) VALUES('Vertical');
INSERT INTO TipoFragmento(Nombre_Frag) VALUES('Replicada');
INSERT INTO TipoFragmento(Nombre_Frag) VALUES('None');

CREATE TABLE Fragmentos(
	Id_Fragmento 	INTEGER AUTO_INCREMENT NOT NULL PRIMARY KEY,
	Nombre 	VARCHAR(50) NOT NULL,
	Tabla	VARCHAR(50) NOT NULL,
	Id_Tipo_Frag	INTEGER	NOT NULL,
	Sitio	INTEGER NOT NULL,
	Condicion VARCHAR(50),

	CONSTRAINT FK_TIPO_FRAG FOREIGN KEY (Id_Tipo_Frag) REFERENCES TipoFragmento(id_Tipo_Frag)
);

INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Cliente_1','Cliente',1,1,'Empresa');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Cliente_2','Cliente',1,2,'Instituto');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Cliente_3','Cliente',1,3,'Civil');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Tipo_Cliente_1','Tipo_Cliente',4,1,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Empleado_1','Empleado',1,1,'Mesero');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Empleado_2','Empleado',1,2,'Cocinero');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Empleado_3','Empleado',1,3,'Coordinador');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Tipo_Emp_3','Tipo_Empleado',4,3,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Salon_1','Salon',4,1,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Tipo_Evento_1','Tipo_Evento',4,1,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Categoria_1','Categoria',4,1,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Evento_1','Evento',1,1,'Desayuno');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Evento_2','Evento',1,2,'Comida');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Evento_3','Evento',1,3,'Cena');
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Tipo_Platillo_2','Tipo_Platillo',4,2,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Paltillo_2','Platillo',2,2,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Paltillo_3','Platillo',2,3,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Banquete_2','Banquete',3,2,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Det_Banquete_2','Detalle_Banquete',3,2,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Empleados_X_Evento_3','Empleado_X_Evento',4,3,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Banquete_3','Banquete',3,3," ");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Det_Banquete_3','Detalle_Banquete',3,3,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Tipo_Musica_1','Tipo_Musica',4,1,"");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Musico_1','Musico',1,1,"Marichi");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Musico_1','Musico',1,1,"Banda");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Musico_2','Musico',1,2,"Sonido");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Musico_3','Musico',1,3,"Grupo");
INSERT INTO Fragmentos(Nombre,Tabla,Id_Tipo_Frag,Sitio,Condicion) VALUES('Musicos_X_Evento_1','Musicos_X_Evento',4,1,"");

CREATE TABLE Atributos(
	Id_Atributo	INTEGER	AUTO_INCREMENT NOT NULL,
	Id_Fragmento INTEGER NOT NULL,
	Nombre VARCHAR(30) NOT NULL,

	CONSTRAINT PK_ATRI PRIMARY KEY (Id_Atributo),
	CONSTRAINT FK_FRAG FOREIGN KEY (Id_Fragmento) REFERENCES Fragmentos(Id_Fragmento)
);

#Tabla para el control de la secuencia en las Entidades de la base de datos
CREATE TABLE Secuencia_X_Entidad
(
	Entidad VARCHAR(20) NOT NULL,
	Secuencia INTEGER NULL DEFAULT 1
);

INSERT INTO Secuencia_X_Entidad(Entidad) VALUES('Cliente');
INSERT INTO Secuencia_X_Entidad(Entidad) VALUES('Empleado');
INSERT INTO Secuencia_X_Entidad(Entidad) VALUES('Musico');
INSERT INTO Secuencia_X_Entidad(Entidad) VALUES('Platillo');
INSERT INTO Secuencia_X_Entidad(Entidad) VALUES('Banquete');
INSERT INTO Secuencia_X_Entidad(Entidad) VALUES('Evento');
INSERT INTO Secuencia_X_Entidad(Entidad) VALUES('Musicos_X_Evento');

update secuencia_x_entidad set secuencia = 1

SET SQL_SAFE_UPDATES=0;

###############	PROCEDIMIENTOS ALMACENADOS ####################

#Controla la secuencia de las entidades
DELIMITER $
CREATE PROCEDURE incrementaSecuencia(IN nameEntidad varchar(20), OUT id INTEGER)
BEGIN
    SET id = (SELECT Secuencia FROM Secuencia_X_Entidad WHERE Entidad = nameEntidad);
    UPDATE Secuencia_X_Entidad SET Secuencia = Secuencia + 1
    WHERE  Entidad = nameEntidad;
END$
call incrementaSecuencia('Platillo',@id);
select @id

#Obtener un fragmento horizontal
DELIMITER $
CREATE PROCEDURE obtenerFragmento(IN entidad varchar(20), IN valueCond varchar(20))
BEGIN
     SELECT Id_Fragmento,Nombre,Sitio FROM fragmentos 
     WHERE tabla = entidad
     AND Id_Tipo_Frag = 1
     AND Condicion = valueCond; 
END$

call obtenerFragmento('Musico','Sonido');


#################################################################

INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(16,'Id_Platillo');
INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(16,'Id_Tipo_Platillo');
INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(16,'Nombre');
INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(16,'Imagen');
INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(16,'Precio');
INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(17,'Id_Platillo');
INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(17,'Ingredientes');
INSERT INTO Atributos(Id_Fragmento,Nombre) VALUES(17,'Preparacion');

##TABLAS PARA REPORTES##
CREATE TABLE Reporte_Emp_X_Evento
(
	Id_Empleado INTEGER NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Apellido_Paterno VARCHAR(50) NOT NULL,
	Sueldo DECIMAL(5,2) NOT NULL,
	Id_Evento INTEGER NOT NULL,
	Fecha VARCHAR(50) NOT NULL,
	Nombre_Salon VARCHAR(50) NOT NULL,
	Categoria VARCHAR(50) NOT NULL,
	Tipo_Evento VARCHAR(50) NOT NULL
);

CREATE TABLE Reporte_Banquetes_X_Evento
(
	Tipo_Evento VARCHAR(20) NOT NULL,
	Categoria VARCHAR(20) NOT NULL,
	Salon VARCHAR(20) NOT NULL,
	Id_Evento INTEGER NOT NULL,
	Id_Banquete INTEGER NOT NULL,
	Fecha VARCHAR(100) NOT NULL,
	Num_Invitados INTEGER NOT NULL,
	Id_Platillo INTEGER NOT NULL,
	Cantidad INTEGER NOT NULL,
	Id_Tipo_Platillo INTEGER NOT NULL,
	Nombre VARCHAR(50) NOT NULL
	Tipo_Platillo VARCHAR(50) NOT NULL
);

CREATE TABLE Reporte_Eventos_Empresas
(
	Id_Evento INTEGER NOT NULL,
	Id_Cliente INTEGER NOT NULL,
	Fecha DATE NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Direccion VARCHAR(100) NOT NULL,
	Telefono VARCHAR(10) NOT NULL,
	Email VARCHAR(100) NOT NULL
);
