CREATE DATABASE IF NOT EXISTS mosaicos;
USE mosaicos;

# ---------------------------------------------------
# -- CREACIÓN DE TABLAS

CREATE TABLE palet (
    id INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(100) NOT NULL UNIQUE,
    ancho INT NOT NULL CHECK (ancho > 0),
    largo INT NOT NULL CHECK (largo > 0)
);

CREATE TABLE producto (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL UNIQUE,
    ancho INT NOT NULL CHECK (ancho > 0),
    largo INT NOT NULL CHECK (largo > 0),
    alto INT NOT NULL CHECK (alto > 0)
);

# ---------------------------------------------------
# -- INSERCIÓN DE DATOS

INSERT INTO palet (tipo, ancho, largo) VALUES
    ('Europeo', 1200, 800),
    ('Americano', 1200, 1000);
