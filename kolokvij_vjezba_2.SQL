create database kolokvij_vjezba_2;

use master;
go
drop database if exists kolokvij_vjezba_2;
go
create database  kolokvij_vjezba_2 collate Croatian_CI_AS;
go
use  kolokvij_vjezba_2;

create table zarucnica (
sifra int primary key,
narukvica int not null,
bojakose varchar(31) not null,
novcica decimal(15,9) null,
lipa decimal(15,8) not null,
indiferentno bit not null
);

create table decko (
sifra int primary key,
indiferentno bit null,
vesta varchar(30) null,
asocijalno bit not null
);

create table cura (
sifra int primary key,
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar (38) not null,
narukvica int not null,
introvertno bit null,
majica varchar(40) not null,
decko int null,
foreign key (decko) references decko(sifra)
);

create table prijatelj (
sifra int primary key,
modelnaocala varchar(37) not null,
treciputa datetime not null,
ekstroventno bit null,
prviputa datetime null,
svekar int not null,
foreign key(svekar) references svekar(sifra)
);

create table svekar (
sifra int primary key,
stilfrizura varchar(48) null,
ogrlica int not null,
asocijalno bit not null
);

create table decko_zarucnica (
sifra int primary key,
decko int not null,
zarucnica int not null,
foreign key(decko) references decko(sifra),
foreign key(zarucnica) references zarucnica(sifra)
);

create table neprijatelj (
sifra int primary key,
majica varchar(32) not null,
haljina varchar(43) not null,
lipa decimal(16,8) null,
modelnaocala varchar(49) not null,
kuna decimal(12,6) not null,
jmbag char(11) null,
cura int null,
foreign key(cura) references cura(sifra)
);

create table brat (
sifra int primary key,
suknja varchar(47) null,
ogrlica int not null,
asocijalno bit not null,
neprijatelj int null,
foreign key(neprijatelj) references neprijatelj(sifra)
);


