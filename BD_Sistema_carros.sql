CREATE SCHEMA `sistema_automoviles` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE sistema_automoviles;

CREATE TABLE Autos
(
	ID_auto INT PRIMARY KEY,
    Marca VARCHAR(50) NOT NULL,
    Modelo VARCHAR(50) NOT NULL,
    Año SMALLINT NOT NULL,
    Existencia INT NOT NULL,
    Precio FLOAT NOT NULL
);

CREATE TABLE Clientes
(
	ID_cliente INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    APaterno VARCHAR(100) NOT NULL,
    AMaterno VARCHAR(100) NOT NULL,
    Correo VARCHAR(200) NOT NULL,
    Telefono BIGINT NOT NULL
);

CREATE TABLE Proveedores
(
	ID_proveedor INT PRIMARY KEY,
    ID_auto INT NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Telefono BIGINT NOT NULL,
    Correo VARCHAR(200) NOT NULL,
    Direccion VARCHAR(100) NOT NULL,
    CONSTRAINT fk_autos FOREIGN KEY(ID_auto) REFERENCES Autos(ID_auto)
);

CREATE TABLE Ventas
(
	ID_venta INT PRIMARY KEY AUTO_INCREMENT,
    ID_auto INT NOT NULL,
    ID_cliente INT NOT NULL,
    Fecha DATETIME NOT NULL,
    CONSTRAINT fk_auto FOREIGN KEY(ID_auto) REFERENCES Autos(ID_auto),
    CONSTRAINT fk_cliente FOREIGN KEY(ID_cliente) REFERENCES Clientes(ID_cliente)
);