create database urarsilvijaispravakk;

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
foreign key(klijent) references(klijent)
);

create table popravak(
popravak int primary key,
sat_id int not null,
datum_popravka date not null,
opis_popravka varchar(255)
foreign key(sat_id) references(sat_id)
);


create table segrti(
segrt_id int primary key,
ime varchar(50)not null,
prezime varchar(50)not null
);


create table popravci(
satid int,
datum_prijema date,
opis_zavrsetka varchar(255),
segrtid int
);

create table sudjelovanje(
popravak int not null,
segrt int not null,
primary key(popravak,segrt),
foreign key(popravak) references(popravak),
foreign key(segrt) references(segrt)
);
