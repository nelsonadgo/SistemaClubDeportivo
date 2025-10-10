-- Creación de la base de datos
CREATE DATABASE IF NOT EXISTS comB_grupo10;
USE comB_grupo10;
    
-- Tabla Roles
CREATE TABLE Roles(
	RolUsu int,
    NomRol varchar(30),
    constraint primary key(RolUsu)
);

    
-- Tabla Usuario
CREATE TABLE Usuario(
	CodUsu int auto_increment,
    NombreUsu varchar(20) DEFAULT NULL,
    PassUsu varchar(15) DEFAULT NULL,
    RolUsu int DEFAULT NULL,
    Activo boolean default true,
    constraint pk_usuario primary key (CodUsu),
    constraint fk_usuario foreign key (RolUsu) references roles(Rolusu)
);

-- store procedure para que ingresen los usuarios del sistema
delimiter //
create procedure IngresoLogin(in Usu varchar(20), in Pass varchar(15))
	begin
		select NomRol
			from Usuario u inner join Roles r on u.RolUsu = r.RolUsu
				where NombreUsu = Usu and PassUsu = Pass
					and Activo = 1;
end
//

INSERT INTO Usuario (CodUsu, NombreUsu, PassUsu, RolUsu, Activo) VALUES
	(1, 'Administrador', 'Admin1234', 1, 1),
    (2, 'Empleado', 'Emple1234', 2, 2);
  
-- Probar el store procedure, si los adatos de los parametros dan una fila es porque existe
call IngresoLogin('Administrador', 'Admin1234');
call IngresoLogin('Empleado', 'Emple1234');

-- Tabla AFILIADO
CREATE TABLE Afiliado(
    id_afiliado INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    dni INT NOT NULL,
    fecha_nacimiento DATE,
    direccion VARCHAR(100),
    telefono INT,
    email VARCHAR(100) UNIQUE,
    fecha_registro DATETIME DEFAULT CURRENT_TIMESTAMP,
    ficha_medica BOOLEAN DEFAULT FALSE,
    apto_fisico BOOLEAN DEFAULT FALSE
);

-- Tabla NO_AFILIADO (tabla para gestionar personas no afiliadas explícitamente)
CREATE TABLE No_Afiliado(
    id_no_afiliado INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    dni INT NOT NULL,
    fecha_nacimiento DATE,
    direccion VARCHAR(100),
    telefono INT,
    email VARCHAR(100) UNIQUE,
    fecha_registro DATETIME DEFAULT CURRENT_TIMESTAMP,
    ficha_medica BOOLEAN DEFAULT FALSE,
    actividad VARCHAR(100),
    apto_fisico BOOLEAN DEFAULT FALSE
);

-- Tabla ACTIVIDAD
CREATE TABLE Actividad (
    id_actividad INT AUTO_INCREMENT PRIMARY KEY,
    nombre_actividad VARCHAR(100) NOT NULL UNIQUE
);

-- Tabla PLANTEL
CREATE TABLE PLANTEL (
    id_plantel INT AUTO_INCREMENT PRIMARY KEY,
    nombre_plantel VARCHAR(100) NOT NULL UNIQUE,
    direccion_plantel VARCHAR(255),
    capacidad INT
);

-- Tabla CUOTA
CREATE TABLE CUOTA (
    id_cuota INT AUTO_INCREMENT PRIMARY KEY,
    monto DECIMAL(10, 2) NOT NULL,
    fecha_vencimiento DATE NOT NULL,
    estado ENUM('Pagada', 'Pendiente', 'Vencida') DEFAULT 'Pendiente',
    id_afiliado INT NOT NULL,
    FOREIGN KEY (id_afiliado) REFERENCES AFILIADO(id_afiliado)
);

-- Tabla PAGO
CREATE TABLE PAGO (
    id_pago INT AUTO_INCREMENT PRIMARY KEY,
    fecha_pago DATETIME DEFAULT CURRENT_TIMESTAMP,
    monto_pagado DECIMAL(10, 2) NOT NULL,
    metodo_pago VARCHAR(50), -- Ej: Efectivo, Tarjeta, Transferencia
    id_cuota INT NOT NULL,
    FOREIGN KEY (id_cuota) REFERENCES CUOTA(id_cuota)
);

-- Tabla HORARIO (Une ACTIVIDAD y PLANTEL)
CREATE TABLE HORARIO (
    id_horario INT AUTO_INCREMENT PRIMARY KEY,
    dia_semana ENUM('Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado', 'Domingo') NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    id_actividad INT NOT NULL,
    id_plantel INT NOT NULL,
    FOREIGN KEY (id_actividad) REFERENCES ACTIVIDAD(id_actividad),
    FOREIGN KEY (id_plantel) REFERENCES PLANTEL(id_plantel),
    UNIQUE (id_actividad, id_plantel, dia_semana, hora_inicio)
);


-- Tabla de relación para AFILIADO_REALIZA_ACTIVIDAD (si un afiliado puede inscribirse a varias actividades)
CREATE TABLE AFILIADO_ACTIVIDAD (
    id_afiliado_actividad INT AUTO_INCREMENT PRIMARY KEY,
    id_afiliado INT NOT NULL,
    id_actividad INT NOT NULL,
    fecha_inscripcion DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_afiliado) REFERENCES AFILIADO(id_afiliado),
    FOREIGN KEY (id_actividad) REFERENCES ACTIVIDAD(id_actividad),
    UNIQUE (id_afiliado, id_actividad)
);

-- store procedure
DELIMITER //

CREATE PROCEDURE IngresarAfiliado(
    IN p_nombre VARCHAR(100),
    IN p_apellido VARCHAR(100),
    IN p_dni INT,
    IN p_fecha_nacimiento DATE,
    IN p_direccion VARCHAR(255),
    IN p_telefono VARCHAR(20),
    IN p_email VARCHAR(100),
    IN p_fecha_registro DATETIME,
    IN p_ficha_medica BOOLEAN,
    IN p_apto_fisico BOOLEAN
)
BEGIN
    -- Verificar si el dni ya existe para evitar duplicados
    IF EXISTS (SELECT 1 FROM AFILIADO WHERE dni = p_dni) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: El dni proporcionado ya está registrado para un afiliado.';
    ELSE
        INSERT INTO AFILIADO 
			(nombre, apellido, dni, fecha_nacimiento, direccion, telefono, email, fecha_registro, ficha_medica, apto_fisico)
        VALUES 
			(p_nombre, p_apellido, p_dni, p_fecha_nacimiento, p_direccion, p_telefono, p_email, p_fecha_registro, p_ficha_medica, p_apto_fisico);
    END IF;
END //

DELIMITER ;

-- Llamar al Store Procedure:
CALL IngresarAfiliado('Juan', 'Perez', 123456,'1990-05-15', 'Calle Falsa 123', 5551234, 'juan.perez@email.com','2025-10-10' , true, true);

CALL IngresarAfiliado('Maria', 'Gomez', 654321, '1988-11-22', 'Avenida Siempre Viva 456', 5555678, 'maria.gomez@email.com' ,'2025-10-10', true, true);

Select * FROM Afiliado;