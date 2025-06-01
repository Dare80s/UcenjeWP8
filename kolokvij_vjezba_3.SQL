﻿create database kolokvij_vjezba_3;

use master;
go
drop database if exists kolokvij_vjezba_3;
go
create database  kolokvij_vjezba_3 collate Croatian_CI_AS;
go
use  kolokvij_vjezba_3;

create table cura (
sifra int primary key,
dukserica varchar(49) not null,
maraka decimal(13,7),
drugiputa datetime,
majica varchar(49),
novcica decimal(15,6),
ogrlica int not null
);

create table svekar (
sifra int primary key,
narukvica int not null,
suknja varchar(36),
bojakose varchar(36),
prsten INT,
novcica decimal(16,8) not null,
cura INT not null,
foreign key (cura) references cura(sifra)
);

create table prijatelj (
sifra int primary key,
kuna decimal(16,10),
haljina varchar(37) not null,
lipa decimal(13,10),
dukserica varchar(31),
indiferentno bit
);

create table ostavljena (
sifra int primary key,
kuna decimal(17,5),
lipa decimal(13,9),
majica varchar(36),
modelnaocala varchar(37) not null,
prijatelj int,
foreign key (prijatelj) references prijatelj(sifra)
);

create table snasa (
sifra int primary key,
introvertno bit,
kuna decimal(15,9) not null,
eura decimal(12,9) not null,
treciputa datetime,
ostavljena int,
foreign key (ostavljena) references ostavljena(sifra)
);

create table brat (
sifra int primary key,
jmbag char(11),
ogrlica int not null,
ekstroventno bit not null
);

create table prijatelj_brat (
sifra int primary key,
prijatelj int not null,
brat int not null,
foreign key (prijatelj) references prijatelj(sifra),
foreign key (brat) references brat(sifra)
);

create table punica (
sifra int primary key,
asocijalno bit not null,
kratkamajica varchar(44),
kuna decimal(13,8) NOT NULL,
vesta varchar(32) NOT NULL,
snasa int,
foreign key (snasa) references snasa(sifra)
);

