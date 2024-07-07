CREATE SCHEMA `sistema_automoviles` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE sistema_automoviles;

CREATE TABLE Autos
(
	ID_auto INT PRIMARY KEY,
    Marca VARCHAR(50) NOT NULL,
    Modelo VARCHAR(50) NOT NULL,
    Año SMALLINT NOT NULL,
    Existencia INT NOT NULL,
    Costo FLOAT NOT NULL,
    Precio FLOAT NOT NULL
);

CREATE TABLE Clientes
(
	ID_cliente INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    APaterno VARCHAR(100) NOT NULL,
    AMaterno VARCHAR(100) NOT NULL,
    Correo VARCHAR(200) NOT NULL,
    Telefono BIGINT NOT NULL,
    RFC VARCHAR(20) NOT NULL,
    CP INT NOT NULL
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
	ID_venta INT AUTO_INCREMENT,
    ID_auto INT NOT NULL,
    ID_cliente INT NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
    Fecha DATETIME NOT NULL,
    Numero_autos SMALLINT NOT NULL,
    Precio FLOAT NOT NULL,
    Total FLOAT NOT  NULL,
    PRIMARY KEY (ID_venta, Fecha),
    CONSTRAINT fk_auto FOREIGN KEY(ID_auto) REFERENCES Autos(ID_auto),
    CONSTRAINT fk_cliente FOREIGN KEY(ID_cliente) REFERENCES Clientes(ID_cliente)
);

INSERT INTO Autos (ID_auto, Marca, Modelo, Año, Existencia, Costo, Precio) VALUES
(1, 'Toyota', 'Corolla', 2024, 10, 210000.00, 250000.00),
(2, 'Toyota', 'Camry', 2023, 8, 252000.00, 300000.00),
(3, 'Honda', 'Civic', 2024, 15, 226800.00, 270000.00),
(4, 'Honda', 'Accord', 2023, 12, 268800.00, 320000.00),
(5, 'Nissan', 'Sentra', 2024, 20, 193200.00, 230000.00),
(6, 'Nissan', 'Altima', 2023, 18, 235200.0, 280000.00),
(7, 'Ford', 'Mustang', 2024, 5, 420000.00, 500000.00),
(8, 'Ford', 'Explorer', 2023, 7, 336000.00, 400000.00),
(9, 'Chevrolet', 'Malibu', 2024, 10, 218400.00, 260000.00),
(10, 'Chevrolet', 'Impala', 2023, 8, 260400.00, 310000.00),
(11, 'Volkswagen', 'Jetta', 2024, 15, 201600.00, 240000.00),
(12, 'Volkswagen', 'Passat', 2023, 12, 243600.00, 290000.00),
(13, 'Hyundai', 'Elantra', 2024, 20, 184800.00, 220000.00),
(14, 'Hyundai', 'Sonata', 2023, 18, 226800.00, 270000.00),
(15, 'Kia', 'Forte', 2024, 10, 193200.00, 230000.00),
(16, 'Kia', 'Optima', 2023, 8, 235200.00, 280000.00),
(17, 'Mazda', 'CX-9', 2024, 15, 210000.00, 250000.00),
(18, 'Mazda', 'CX-3', 2023, 12, 252000.00, 300000.00),
(19, 'Subaru', 'Impreza', 2024, 10, 218400.00, 260000.00),
(20, 'Subaru', 'Legacy', 2023, 8, 260400.00, 310000.00);
#21, 'Nissan', 'Tsuru', 1984, 10, 50000.00, 56000.00


INSERT INTO Proveedores (ID_proveedor, ID_auto, Nombre, Telefono, Correo, Direccion) VALUES
(1, 1, 'Autos Súper', 5512345678, 'contacto@autosuper.com', 'Av. Insurgentes Sur 123, Ciudad de México'),
(2, 1, 'Vehículos Veloz', 5523456789, 'info@vehiculosveloz.com', 'Paseo de la Reforma 456, Ciudad de México'),
(3, 2, 'Carros Cometa', 5534567890, 'soporte@carroscometa.com', 'Eje Central 789, Ciudad de México'),
(4, 2, 'Movilidad Meteoro', 5545678901, 'ventas@movilidadmeteoro.com', 'Calzada de Tlalpan 012, Ciudad de México'),
(5, 3, 'Automóviles Astro', 5556789012, 'atencion@automovilesastro.com', 'Anillo Periférico 345, Ciudad de México'),
(6, 3, 'Rápidos Rayo', 5567890123, 'clientes@rapidosrayo.com', 'Viaducto Miguel Alemán 678, Ciudad de México'),
(7, 4, 'Turbo Transportes', 5578901234, 'proveedores@turbotransportes.com', 'Circuito Interior 901, Ciudad de México'),
(8, 4, 'Veloce Vehículos', 5589012345, 'compras@velocevehiculos.com', 'Av. Universidad 234, Ciudad de México'),
(9, 5, 'Automóviles Andromeda', 5590123456, 'servicio@automovilesandromeda.com', 'Av. Revolución 567, Ciudad de México'),
(10, 5, 'Carros Cósmicos', 5501234567, 'ayuda@carroscosmicos.com', 'Av. Patriotismo 890, Ciudad de México'),
(11, 6,'Vehículos Vía Láctea', 5512345670, 'contacto@vehiculosvialactea.com', 'Av. Popocatépetl 123, Ciudad de México'),
(12, 6, 'Automóviles Aurora', 5523456701, 'info@automovilesaurora.com', 'Eje 3 Oriente 456, Ciudad de México'),
(13, 7, 'Carros Cúspide', 5534567012, 'soporte@carroscuspide.com', 'Eje 4 Sur 789, Ciudad de México'),
(14, 7, 'Movilidad Mercurio', 5545670123, 'ventas@movilidadmercurio.com', 'Eje 5 Norte 012, Ciudad de México'),
(15, 8, 'Autos Alfa', 5556701234, 'atencion@autosalfa.com', 'Eje 6 Poniente 345, Ciudad de México'),
(16, 8, 'Rápidos Rigel', 5567012345, 'clientes@rapidosrigel.com', 'Eje 7 Sur 678, Ciudad de México'),
(17, 9, 'Turbo Tauro', 5570123456, 'proveedores@turbotaurus.com', 'Eje 8 Norte 901, Ciudad de México'),
(18, 9, 'Veloce Vega', 5581234567, 'compras@velocevega.com', 'Eje 9 Poniente 234, Ciudad de México'),
(19, 10, 'Automóviles Antares', 5592345678, 'servicio@automovilesantares.com', 'Eje 10 Sur 567, Ciudad de México'),
(20, 10, 'Carros Casiopea', 5503456789, 'ayuda@carroscasiopea.com', 'Eje 11 Norte 890, Ciudad de México');

INSERT INTO Clientes (ID_cliente, Nombre, APaterno, AMaterno, Correo, Telefono, RFC, CP) VALUES
(1, 'Juan', 'Pérez', 'López', 'juan.perez@gmail.com', 5512345678, 'RDL0904102F4', 01000),
(2, 'María', 'González', 'Ramírez', 'maria.gonzalez@gmail.com', 5523456789, 'EJM060727H43', 01030),
(3, 'Pedro', 'Martínez', 'García', 'pedro.martinez@gmail.com', 5534567890, 'CDL120313MR4', 01070),
(4, 'Ana', 'Rodríguez', 'Hernández', 'ana.rodriguez@gmail.com', 5545678901, 'RDL0904102F4', 01090),
(5, 'José', 'López', 'Morales', 'jose.lopez@gmail.com', 5556789012, 'QRS9876543B1', 01200),
(6, 'Patricia', 'Gómez', 'Gutiérrez', 'patricia.gomez@gmail.com', 5567890123, 'XYZ5678901C2', 01210),
(7, 'Francisco', 'Ruiz', 'Romero', 'francisco.ruiz@gmail.com', 5578901234, 'TUV1029384D3', 01220),
(8, 'Laura', 'Díaz', 'Guerrero', 'laura.diaz@gmail.com', 5589012345, 'ABC5647382E4', 01280),
(9, 'Roberto', 'Moreno', 'Torres', 'roberto.moreno@gmail.com', 5590123456, 'DEF8473625F5', 01290),
(10, 'Carmen', 'Mendoza', 'Peña', 'carmen.mendoza@gmail.com', 5501234567, 'GHI2938471G6', 01408),
(11, 'Ricardo', 'Rojas', 'Alvarez', 'ricardo.rojas@gmail.com', 5512345670, 'JKL6758493H7', 01410),
(12, 'Isabel', 'Vargas', 'Herrera', 'isabel.vargas@gmail.com', 5523456701, 'MNO4839205I8', 01548),
(13, 'Alejandro', 'Castillo', 'Reyes', 'alejandro.castillo@gmail.com', 5534567012, 'PQR8293746J9', 01549),
(14, 'Sofía', 'Cortés', 'Jiménez', 'sofia.cortes@gmail.com', 5545670123, 'UVW3746521A4', 01650),
(15, 'Carlos', 'Santos', 'Silva', 'carlos.santos@gmail.com', 5556701234, 'NOP5847263B5', 01645),
(16, 'Gabriela', 'Aguilar', 'Delgado', 'gabriela.aguilar@gmail.com', 5567012345, 'HIJ9473826C7', 01790),
(17, 'Miguel', 'Romero', 'Paredes', 'miguel.romero@gmail.com', 5570123456, 'LMN7381925D2', 01810),
(18, 'Teresa', 'Guerra', 'Méndez', 'teresa.guerra@gmail.com', 5581234567, 'CDE5617384E3', 08700),
(19, 'Javier', 'Campos', 'Ruíz', 'javier.campos@gmail.com', 5592345678, 'QRS4928375F6', 02160),
(20, 'Susana', 'Vázquez', 'Maldonado', 'susana.vazquez@gmail.com', 5503456789, 'TUV6273849G8', 02200);

INSERT INTO Ventas (ID_auto, ID_cliente, Descripcion, Fecha, Numero_autos, Precio, Total) VALUES
(6, 4, 'Venta a Ana Rodríguez Hernández - Método de pago: Tarjeta de crédito', '2024-01-05 10:30:00', 1, 250000.00, 290000.00),
(2, 1, 'Venta a Juan Pérez López - Método de pago: Transferencia bancaria', '2024-01-15 11:00:00', 1, 300000.00, 348000.00),
(3, 2, 'Venta a María González Ramírez - Método de pago: Efectivo', '2024-01-20 15:45:00', 1, 270000.00, 313200.00),
(4, 3, 'Venta a Pedro Martínez García - Método de pago: Tarjeta de crédito', '2024-01-25 16:30:00', 1, 320000.00, 371200.00),
(5, 5, 'Venta a José López Morales - Método de pago: Transferencia bancaria', '2024-02-05 10:00:00', 1, 230000.00, 266800.00),
(1, 6, 'Venta a Patricia Gómez Gutiérrez - Método de pago: Efectivo', '2024-02-10 14:15:00', 1, 280000.00, 324800.00),
(7, 7, 'Venta a Francisco Ruiz Romero - Método de pago: Tarjeta de crédito', '2024-02-15 13:30:00', 1, 500000.00, 580000.00),
(8, 8, 'Venta a Laura Díaz Guerrero - Método de pago: Transferencia bancaria', '2024-02-20 12:45:00', 1, 400000.00, 464000.00),
(9, 9, 'Venta a Roberto Moreno Torres - Método de pago: Efectivo', '2024-03-05 11:00:00', 1, 260000.00, 301600.00),
(10, 10, 'Venta a Carmen Mendoza Peña - Método de pago: Tarjeta de crédito', '2024-03-10 15:15:00', 1, 310000.00, 359600.00),
(11, 11, 'Venta a Ricardo Rojas Alvarez - Método de pago: Transferencia bancaria', '2024-03-15 14:30:00', 1, 240000.00, 278400.00),
(12, 12, 'Venta a Isabel Vargas Herrera - Método de pago: Efectivo', '2024-03-20 13:45:00', 1, 290000.00, 336400.00),
(13, 13, 'Venta a Alejandro Castillo Reyes - Método de pago: Tarjeta de crédito', '2024-04-05 12:00:00', 1, 220000.00, 255200.00),
(14, 14, 'Venta a Sofía Cortés Jiménez- Método de pago: Transferencia bancaria', '2024-04-10 16:15:00', 1, 270000.00, 313200.00),
(15, 15, 'Venta a Carlos Santos Silva - Método de pago: Efectivo', '2024-04-15 15:30:00', 1, 230000.00, 266800.00),
(16, 16, 'Venta a Gabriela Aguilar Delgado - Método de pago: Tarjeta de crédito', '2024-04-20 14:45:00', 1, 280000.00, 324800.00),
(17, 17, 'Venta a Miguel Romero Paredes - Método de pago: Transferencia bancaria', '2024-05-05 13:00:00', 1, 250000.00, 290000.00),
(18, 18, 'Venta a Teresa Guerra Méndez - Método de pago: Efectivo', '2024-05-10 17:15:00', 1, 300000.00, 348000.00),
(19, 19, 'Venta a Javier Campos Ruíz - Método de pago: Tarjeta de crédito', '2024-05-15 16:30:00', 1, 260000.00, 301600.00),
(20, 20, 'Venta a Susana Vázquez Maldonado - Método de pago: Transferencia bancaria', '2024-05-20 15:45:00', 1, 310000.00, 359600.00);

/*INSERT INTO Ventas (ID_auto, ID_cliente, Descripcion, Fecha, Numero_autos, Precio, Total) VALUES
(6, 4, '', '2024-01-05 10:30:00', 1, 250000.00, 290000.00),
(2, 1, '', '2024-01-15 11:00:00', 1, 300000.00, 348000.00),
(3, 2, '', '2024-01-20 15:45:00', 1, 270000.00, 313200.00),
(4, 3, '', '2024-01-25 16:30:00', 1, 320000.00, 371200.00),
(5, 5, '', '2024-02-05 10:00:00', 1, 230000.00, 266800.00),
(1, 6, '', '2024-02-10 14:15:00', 1, 280000.00, 324800.00),
(7, 7, '', '2024-02-15 13:30:00', 1, 500000.00, 580000.00),
(8, 8, '', '2024-02-20 12:45:00', 1, 400000.00, 464000.00),
(9, 9, '', '2024-03-05 11:00:00', 1, 260000.00, 301600.00),
(10, 10, '', '2024-03-10 15:15:00', 1, 310000.00, 359600.00),
(11, 11, '', '2024-03-15 14:30:00', 1, 240000.00, 278400.00),
(12, 12, '', '2024-03-20 13:45:00', 1, 290000.00, 336400.00),
(13, 13, '', '2024-04-05 12:00:00', 1, 220000.00, 255200.00),
(14, 14, '', '2024-04-10 16:15:00', 1, 270000.00, 313200.00),
(15, 15, '', '2024-04-15 15:30:00', 1, 230000.00, 266800.00),
(16, 16, '', '2024-04-20 14:45:00', 1, 280000.00, 324800.00),
(17, 17, '', '2024-05-05 13:00:00', 1, 250000.00, 290000.00),
(18, 18, '', '2024-05-10 17:15:00', 1, 300000.00, 348000.00),
(19, 19, '', '2024-05-15 16:30:00', 1, 260000.00, 301600.00),
(20, 20, '', '2024-05-20 15:45:00', 1, 310000.00, 359600.00);*/