-- Script para crear tablas e insertar datos en el esquema MABUP_APP
-- Conectar como: MABUP_APP / tu_contraseña_segura

-- Creación de la tabla de Usuarios
CREATE TABLE tb_Usuarios(
	id NUMBER(10, 0) NOT NULL,
	Usuario VARCHAR2(60),
	Contraseña VARCHAR2(60),
	Nombre VARCHAR2(50),
	Ap_Pat VARCHAR2(50),
	Ap_Mat VARCHAR2(50),
	Estimado_de_tiempo INTERVAL DAY(0) TO SECOND(0),
	CONSTRAINT pk_usuarios PRIMARY KEY (id)
);
/

-- Creación de la tabla de Tareas
CREATE TABLE tb_Tareas(
	id NUMBER(10, 0),
	Num_Tarea NUMBER GENERATED AS IDENTITY NOT NULL,
	Titulo VARCHAR2(80),
	Fecha_Inicio DATE,
    Hora_Inicio VARCHAR2(8),
	Fecha_Entrega DATE,
    Hora_Entrega VARCHAR2(8),
	Materia VARCHAR2(50),
	Dificultad NUMBER(2, 0),
	Tema_Tarea VARCHAR2(80),
	Completado NUMBER(1) DEFAULT 0,
	CONSTRAINT pk_tareas PRIMARY KEY (Num_Tarea),
	CONSTRAINT fk_tareas_usuarios FOREIGN KEY (id) REFERENCES tb_Usuarios(id),
  CONSTRAINT chk_completado CHECK (Completado IN (0,1))
);
/

-- Insertar datos en la tabla de Usuarios
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (1, 'Mabup', '14', '', '', '', NULL);
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (2, 'abc@hotmai.com', '123456789', 'Emily', 'Piña', 'Sanchez', INTERVAL '02:00:00' HOUR TO SECOND);
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (3, 'magpv@some.com', '123456789', 'Amelia Zarai', 'Sanchez', 'Gutierrez', INTERVAL '01:06:01' HOUR TO SECOND);
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (4, 'edv@yahoo.com', '123456789', 'Diego', 'Lopez', 'Cardenaz', INTERVAL '02:00:00' HOUR TO SECOND);
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (5, 'rock21@gmail.com', '123456789', 'maria guadalupe', 'vargas', 'najera', INTERVAL '05:10:03' HOUR TO SECOND);
/

-- Insertar datos en la tabla de Tareas
-- La columna Num_Tarea se genera automáticamente por lo que no se incluye en el INSERT
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (1, 'Resumen micro', TO_DATE('2021-02-12', 'YYYY-MM-DD'), '11:23:00', TO_DATE('2021-02-12', 'YYYY-MM-DD'), '10:12:00', 'Microeconomia', 5, 'Costos', 0);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 'Resumen de derecho', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '17:46:40', TO_DATE('2021-01-19', 'YYYY-MM-DD'), '09:11:00', 'Derecho', 5, 'rdh6t', 0);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (3, 'xdtrgxd', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '17:47:30', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '05:45:00', 'zdfgr', 3, '6ytrdh', 0);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (3, 'fjhxct', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '17:47:45', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '06:45:00', 'dxg', 4, 'dxrgxdrg', 1);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 'Ejercicios de Integrales', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '19:44:59', TO_DATE('2021-01-22', 'YYYY-MM-DD'), '13:54:00', 'Matematicas', 9, 'cfth', 0);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 'Resumen De POO', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '21:06:17', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '08:16:00', 'Poo', 6, 'siefudhrt', 0);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 'Cuadro foda', TO_DATE('2021-01-14', 'YYYY-MM-DD'), '21:12:51', TO_DATE('2021-01-20', 'YYYY-MM-DD'), '12:21:00', 'Orientacion', 3, 'cfhtcfh', 0);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (4, 'res', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '01:31:26', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '11:14:00', 'Microeconomia', 5, 'yjc', 1);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (5, 'Resumen de fisica', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '07:59:07', TO_DATE('2021-01-20', 'YYYY-MM-DD'), '10:03:00', 'Fisica', 7, 'MRU', 1);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 'dibujo', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '21:48:28', TO_DATE('2021-01-20', 'YYYY-MM-DD'), '11:11:00', 'Biologia', 3, 'dibujo industrial', 1);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (4, 'crisis economica en pandemia', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '22:40:19', TO_DATE('2021-01-28', 'YYYY-MM-DD'), '15:00:00', 'Microeconomia', 8, 'desempleo y crisis economica en la actualidad', 1);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 'Graficas de punto de equilibrio', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '02:09:43', TO_DATE('2021-01-27', 'YYYY-MM-DD'), '12:03:00', 'Microeconomia', 4, 'sdfsdf', 0);
INSERT INTO tb_Tareas (id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (5, 'thfxcfht', TO_DATE('2021-01-15', 'YYYY-MM-DD'), '02:16:58', TO_DATE('2021-01-17', 'YYYY-MM-DD'), '00:00:00', 'Derecho', 3, 'fcthhtf', 0);
/

-- Confirmar todos los cambios en la base de datos
COMMIT;
/

SELECT MAX(Num_Tarea) FROM tb_Tareas;

SELECT TABLE_NAME
FROM USER_TABLES;

SELECT * FROM TB_tareas;
drop table tb_tareas;
