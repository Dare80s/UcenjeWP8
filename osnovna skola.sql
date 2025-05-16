

use master;
go
drop database if exists osnovnaskola;
go
create database osnovnaskola;
go
use osnovnaskola;

create table dijete(
sifra int primary key,
ime varchar(50) not null,
prezime varchar(50)not null,
datumrodenja date
);

create table uciteljica(
sifra int primary key,
ime varchar(50) not null,
prezime varchar(50) not null,
predmet varchar(50)
);

create table radionica(
sifra int primary key,
naziv varchar(100) not null,
opis text,
uciteljica int,
foreign key(uciteljica) references uciteljica(sifra)
);

create table dijeteradionica(
dijete int,
radionica int,
primary key(dijete, radionica),
foreign key(dijete) references dijete(sifra),
foreign key(radionica) references radionica(sifra)
);

