create database urarsilvijaispravak2;

use master;
go
drop database if exists urarsilvija;
go
create database urarsilvija;
go
use urarsilvija;


create table korisnik(
korisnik int primary key,
ime varchar(50)not null,
prezime varchar(50) not null,
kontakt varchar(100)
);

create table sat(
sat_id int primary key,
klijent int not null,
marka varchar (50),
model varchar(50),
serijski_broj varchar(100)
);

create table popravak(
popravak int primary key,
sat_id int not null,
datum_popravka date not null,
opis_popravka varchar(255)
);


create table segrti(
segrt_id int primary key,
ime varchar(50)not null,
prezime varchar(50)not null
);

