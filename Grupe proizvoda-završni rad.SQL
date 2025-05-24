--create database grupe_proizvoda;

use master;
go
drop database if exists grupe_proizvoda;
go
create database grupe_proizvoda;
go
use grupe_proizvoda;

create table grupe_proizvoda(
sifra_grupe int primary key,
naziv_grupe varchar(50) not null
);

create table proizvodi(
sifra_proizvoda int primary key,
naziv_proizvoda varchar(100) not null,
grupa int,
nabavna_cijena decimal(10,2) not null,
prodajna_cijena decimal(10,2) not null,
foreign key (grupa) references grupe_proizvoda(sifra_grupe) 
);

create table prodaja(
sifra_prodaje int primary key,
sifra_proizvoda int,
datum_prodaje date not null,
kolicina int not null,
cijena_po_jednici decimal(10,2) not null,
foreign key (sifra_proizvoda) references proizvodi(sifra_proizvoda)
);


