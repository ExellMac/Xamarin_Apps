create database PDM_Login
GO

USE PDM_Login
GO

CREATE TABLE roles (
    id_rol INT PRIMARY KEY,
    nombre_rol VARCHAR(50) NOT NULL
);

select * from roles

-- Insertando los roles y nombre dentro de la tabla
INSERT INTO roles (id_rol, nombre_rol) VALUES (1, 'Profesor');
INSERT INTO roles (id_rol, nombre_rol) VALUES (2, 'Estudiante');
INSERT INTO roles (id_rol, nombre_rol) VALUES (3, 'Chad')



-- Tabla Usuarios

--CREATE

CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY,
    nombre_usuario VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    id_rol INT NOT NULL,
    FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);


-- READ
select * from usuarios



-- INSERTS

INSERT INTO usuarios (id_usuario, nombre_usuario, password, id_rol) VALUES (1, 'JUANCITO', 'ADMIN123', 1);
INSERT INTO usuarios (id_usuario, nombre_usuario, password, id_rol) VALUES (2, 'BUTCHER', 'BUCHOYO45', 2);
INSERT INTO usuarios (id_usuario, nombre_usuario, password, id_rol) VALUES (3, 'RAUDI PEREZ', 'BUHO94', 2);
INSERT INTO usuarios (id_usuario, nombre_usuario, password, id_rol) VALUES (4, 'ELIAN ALBA', 'ELONMUSK_0', 2);
INSERT INTO usuarios (id_usuario, nombre_usuario, password, id_rol) VALUES (5, 'GIGACHAD ', 'GIGA_CHAD', 2);



-- UPDATE
UPDATE usuarios set id_rol = 3 where id_usuario = 5;
