create database taxi sluzba;


create table vozilo(
id int,
registracija varchar(20),
marka varchar(50),
model varchar(50),
godina_proizvodnje int
;)

create table vozac(
id int,
ime varchar(50),
prezime varchar(50),
datum_rodenja date,
vozilo_id int
;)

create table putnik(
id int,
ime varchar(50),
prezime(varchar(50),
kontakt varchar(100)
;)


--create table voznja(
--id int,
--datum datetime,
--pocetna_lokacija varchar(100),
--krajnja_lokacija varchar (100),
--vozac_id
--;)