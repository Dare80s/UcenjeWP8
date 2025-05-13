--create database urar silvija;
use master;
go
drop database if exists urarsilvija;
go
create database urarsilvija;
go
use urarsilvija;


create table korisnik(
korisnikid int,
ime varchar(50),
prezime varchar(50),
kontakt varchar(100)
);

create table sat(
sat_id int,
marka varchar (50),
model varchar(50),
serijski_broj varchar(100)
korisnik_id int
);

create table segrti(
segrtid int,
ime varchar(50),
prezime varchar(50)
);

create table popravak(
satid int,
datum_popravka date,
opis_popravka varchar(255),
segrtid int
);