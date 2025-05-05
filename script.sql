-- ========================================
-- Crear base de datos si no existe
-- ========================================
IF NOT EXISTS (
    SELECT name
    FROM sys.databases
    WHERE name = N'persona_db'
)
BEGIN
    CREATE DATABASE persona_db;
END
GO

-- ========================================
-- Usar la base de datos
-- ========================================
USE persona_db;
GO

-- ========================================
-- Crear tablas
-- ========================================

-- Tabla profesion
CREATE TABLE profesion (
    id INT PRIMARY KEY,
    nom VARCHAR(90) NOT NULL,
    des TEXT
);
GO

-- Tabla persona
CREATE TABLE persona (
    cc INT PRIMARY KEY,
    nombre VARCHAR(60) NOT NULL,
    apellido VARCHAR(60) NOT NULL,
    genero CHAR(1) NOT NULL,
    edad INT
);
GO

-- Tabla telefono
CREATE TABLE telefono (
    num VARCHAR(15) PRIMARY KEY,
    oper VARCHAR(30),
    dueno INT NOT NULL,
    FOREIGN KEY (dueno) REFERENCES persona(cc)
);
GO

-- Tabla estudios
CREATE TABLE estudios (
    cc_per INT NOT NULL,
    id_prof INT NOT NULL,
    fecha DATE,
    univer VARCHAR(120),
    PRIMARY KEY (cc_per, id_prof),
    FOREIGN KEY (cc_per) REFERENCES persona(cc),
    FOREIGN KEY (id_prof) REFERENCES profesion(id)
);
GO

-- ========================================
-- Insertar datos de prueba
-- ========================================

-- Personas
INSERT INTO persona (cc, nombre, apellido, genero, edad) VALUES
(1001, 'Carlos', 'López', 'M', 23),
(1002, 'María', 'Gómez', 'F', 27);
GO

-- Profesiones
INSERT INTO profesion (id, nom, des) VALUES
(1, 'Ingeniero de Sistemas', 'Desarrolla software y administra redes'),
(2, 'Diseñador Gráfico', 'Crea diseños visuales para productos o marcas');
GO

-- Teléfonos
INSERT INTO telefono (num, oper, dueno) VALUES
('3101234567', 'Claro', 1001),
('3009876543', 'Movistar', 1002);
GO

-- Estudios
INSERT INTO estudios (cc_per, id_prof, fecha, univer) VALUES
(1001, 1, '2021-12-15', 'Universidad Nacional'),
(1002, 2, '2022-05-20', 'Universidad de los Andes');
GO
