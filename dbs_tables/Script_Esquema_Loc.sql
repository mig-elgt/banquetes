
CREATE TABLE TipoFragmento(
	id_Tipo_Frag INTEGER NOT NULL,
	Nombre_Frag VARCHAR(20),

	CONSTRAINT PK_TIPO_F PRIMARY KEY id_Tipo_Frag
);

INSERT INTO TipoFragmento VALUES(1,'Horizontal');
INSERT INTO TipoFragmento VALUES(2,'Vertical');
INSERT INTO TipoFragmento VALUES(3,'Replica');
INSERT INTO TipoFragmento VALUES(4,'None');

CREATE TABLE Fragmentos(
	id_Fragmento 	INTEGER NOT NULL,
	Nombre 	VARCHAR(30) NOT NULL,
	Tabla	VARCHAR(30) NOT NULL,
	id_Tipo_Frag	INTEGER	NOT NULL,
	Sitio	INTEGER NOT NULL,
	Condicion VARCHAR(50) NOT NULL,

	CONSTRAINT PK_FRAG PRIMARY KEY id_Fragmento,
	CONSTRAINT FK_TIPO_FRAG FOREIGN KEY id_Tipo_Frag REFERENCES TipoFragmento(id_Tipo_Frag)	
);

INSERT INTO Fragmentos VALUES(1,'Cliente_1','Cliente',1,1,'Empresa');
INSERT INTO Fragmentos VALUES(2,'Cliente_2','Cliente',1,2,'Instituto');
INSERT INTO Fragmentos VALUES(3,'Cliente_3','Cliente',1,3,'Civil');
INSERT INTO Fragmentos VALUES(4,'Tipo_Cliente_1','Tipo_Cliente',4,1,"");
INSERT INTO Fragmentos VALUES(5,'Empleado_1','Empleado',1,1,'Mesero');
INSERT INTO Fragmentos VALUES(6,'Empleado_2','Empleado',1,2,'Cocinero');
INSERT INTO Fragmentos VALUES(7,'Empleado_3','Empleado',1,3,'Coordinador');
INSERT INTO Fragmentos VALUES(8,'Tipo_Emp_3','Tipo_Empleado',4,3,"");
INSERT INTO Fragmentos VALUES(9,'Salon_1','Salon',4,1,"");
INSERT INTO Fragmentos VALUES(10,'Tipo_Evento_1','Tipo_Evento',4,1,"");
INSERT INTO Fragmentos VALUES(11,'Categoria_1','Categoria',4,1,"");
INSERT INTO Fragmentos VALUES(12,'Evento_1','Evento',1,1,'Desayuno');
INSERT INTO Fragmentos VALUES(13,'Evento_2','Evento',1,2,'Comida');
INSERT INTO Fragmentos VALUES(14,'Evento_3','Evento',1,3,'Cena');
INSERT INTO Fragmentos VALUES(15,'Tipo_Platillo_2','Tipo_Platillo',4,2,"");
INSERT INTO Fragmentos VALUES(16,'Paltillo_2','Platillo',2,2,"");
INSERT INTO Fragmentos VALUES(17,'Paltillo_3','Platillo',2,3,"");
INSERT INTO Fragmentos VALUES(18,'Banquete_2','Banquete',3,2,"");
INSERT INTO Fragmentos VALUES(19,'Det_Banquete_2','Detalle_Banquete',3,2,"");
INSERT INTO Fragmentos VALUES(20,'Eventos_X_Empleado_3','Eventos_X_Empleado',4,3,"");
INSERT INTO Fragmentos VALUES(21,'Banquete_3','Banquete',3,3," ");
INSERT INTO Fragmentos VALUES(22,'Det_Banquete_3','Detalle_Banquete',3,3,"");
INSERT INTO Fragmentos VALUES(23,'Tipo_Musica_1','Tipo_Musica',4,1,"");
INSERT INTO Fragmentos VALUES(24,'Musico_1','Musico',2,1,"Marichi");
INSERT INTO Fragmentos VALUES(25,'Musico_1','Musico',2,1,"Banda");
INSERT INTO Fragmentos VALUES(26,'Musico_2','Musico',2,2,"Sonido");
INSERT INTO Fragmentos VALUES(27,'Musico_3','Musico',2,3,"Grupo");
INSERT INTO Fragmentos VALUES(28,'Eventos_X_Musico_1','Eventos_X_Musico',4,1,"");

CREATE TABLE Atributos(
	id_Atributo	INTEGER	NOT NULL,
	id_Fragmento INTEGER NOT NULL,
	Nombre VARCHAR(20) NOT NULL,

	CONSTRAINT PK_ATRI PRIMARY KEY id_Atributo,
	CONSTRAINT FK_FRA FOREIGN KEY id_Fragmento REFERENCES Fragmentos(id_Fragmento)
);

INSERT INTO Atributos VALUES(1,16,'id_Platillo');
INSERT INTO Atributos VALUES(2,16,'id_Tipo_Platillo');
INSERT INTO Atributos VALUES(3,16,'Nombre');
INSERT INTO Atributos VALUES(4,16,'Imagen');
INSERT INTO Atributos VALUES(5,16,'Precio');
INSERT INTO Atributos VALUES(6,17,'id_Platillo');
INSERT INTO Atributos VALUES(7,17,'Ingredientes');
INSERT INTO Atributos VALUES(8,17,'Preparacion');