CREATE Table Punto (
codigo varchar(20) PRIMARY KEY,
tipo VARCHAR(10) NOT NULL,
capacidad INT NOT NULL,
vidautil VARCHAR(12) NOT NULL

);

CREATE Table Region (
codigo VARCHAR(20) PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
);


CREATE Table Estacion (
codigo varchar(20) PRIMARY KEY,
direccion VARCHAR(50) NOT NULL,
ciudad VARCHAR(20) NOT NULL,
capacidad INT NOT NULL,
region VARCHAR(20) NOT NULL,

CONSTRAINT fk_estacion_region FOREIGN KEY(region) 
REFERENCES Region(codigo)
);