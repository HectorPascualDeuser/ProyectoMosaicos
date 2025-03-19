CREATE DATABASE mosaicos;
USE mosaicos;


# ---------------------------------------------------
# -- CREACIÓN DE TABLAS

CREATE TABLE palet(
	id INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(100) NOT NULL,
    ancho INT NOT NULL,
    largo INT NOT NULL
);

CREATE TABLE producto(
	id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    ancho INT NOT NULL,
    largo INT NOT NULL,
	alto INT NOT NULL
);


# ---------------------------------------------------
# -- INSERCIÓN DE DATOS

INSERT INTO palet(tipo, ancho, largo) VALUES
    ('Europeo', 1200, 800),
    ('Americano', 1200, 1000);

