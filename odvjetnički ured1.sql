create database odvjetnicki ured;

CREATE TABLE odvjetnik; 
id SERIAL PRIMARY KEY,
ime TEXT NOT NULL
);

CREATE TABLE klijent (
id SERIAL PRIMARY KEY,
ime TEXT NOT NULL
);

CREATE TABLE suradnik (
 id SERIAL PRIMARY KEY,
 ime TEXT NOT NULL
);

CREATE TABLE obrana (
id SERIAL PRIMARY KEY,
odvjetnik_id INT REFERENCES odvjetnik(id),
klijent_id INT REFERENCES klijent(id),
datum DATE NOT NULL
);

--CREATE TABLE obrana_suradnik (
--obrana_id INTEGER REFERENCES obrana(id),
--suradnik_id INTEGER REFERENCES suradnik(id),
--PRIMARY KEY (obrana_id, suradnik_id)
--);