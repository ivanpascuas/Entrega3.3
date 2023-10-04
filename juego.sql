DROP DATABASE IF EXISTS db;
CREATE DATABASE db;

USE db;


CREATE TABLE PARTIDAS (ID INT NOT NULL, NUM_JUG INT, DURACION FLOAT, PRIMARY KEY (ID)) ENGINE = InnoDB;


CREATE TABLE PERSONAJES (ID INT NOT NULL, FUERZA INT, HP INT, VEL INT, MAGIA INT, PRIMARY KEY (ID)) ENGINE = InnoDB;

CREATE TABLE USUARIOS (ID INT NOT NULL, NOMBRE VARCHAR(30), CORREO VARCHAR(30), CONTRASEÑA VARCHAR(30), ID_PERS INT NOT NULL, SCORE INT, ID_PARTIDA INT NOT NULL, PRIMARY KEY (ID), FOREIGN KEY (ID_PERS) REFERENCES PERSONAJES(ID), FOREIGN KEY (ID_PARTIDA) REFERENCES PARTIDAS(ID)) ENGINE = InnoDB;

INSERT INTO PERSONAJES VALUES (1, 10, 50, 5, 0);
INSERT INTO PARTIDAS VALUES (1, 4, 300);
INSERT INTO PARTIDAS VALUES (2, 2, 100);
INSERT INTO PERSONAJES VALUES (2, 5, 100, 15, 0);
INSERT INTO USUARIOS VALUES (1, 'Ivan', 'ivanpp881@gmail.com', '123456789', 1, 0, 1);
INSERT INTO USUARIOS VALUES (2, 'Rarete', 'invertido@raro.com', 'UpsideDown', 1, 0, 2);



SELECT ID_PARTIDA FROM USUARIOS WHERE ID_PERS = 1;

