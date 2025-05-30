 create database kolokvij_vjezba_1

use master;
go
drop database if exists kolokvij_vjezba_1;
go
create database  kolokvij_vjezba_1;
go
use  kolokvij_vjezba_1;

create table sestra (
sifra int not null,
introvertno bit null,
haljina varchar(31) not null,
narukvica int null,
maraka decimal(16, 6) not null,
hlace varchar(48) not null,
primary key (sifra)
);

create table zena (
sifra int not null,
treciputa datetime null,
hlace varchar(40) not null,
kratkaamajica varchar(31) not null,
jmbag char(11) not null,
bojaociju varchar(39) not null,
haljina varchar(44) not null,
sestra INT not null,
primary key (sifra),
foreign key (sestra) references sestra(sifra)
);

create table punac (
sifra int not null,
ogrlica int null,
gustoca decimal(14,9) null,
hlace varchar(41) not null,
primary key (sifra)
);


create table cura (
sifra int not null,
novcica decimal(16, 5) null,
gustoca decimal(14, 10) not null,
lipa decimal(13, 10) null,
ogrlica int null,
bojakose varchar(38) null,
suknja varchar(38) null,
punac int null,
primary key (sifra),
foreign key (punac) references punac(sifra)
);

create table svekar (
sifra int not null,
bojaociju varchar(43) not null,
prstena int null,
dukserica varchar(47) null,
lipa decimal(13, 8) null,
eura decimal(12, 7) null,
majica varchar(35) null,
primary key (sifra)
);

create table sestra_svekar (
sifra int not null,
sestra int not null,
svekar int not null,
primary key (sifra),
foreign key (sestra) references sestra(sifra),
foreign key (svekar) references svekar(sifra)
);



create table muskarac (
sifra int not null,
bojaociju varchar(50) not null,
hlace varchar(30) null,
modelnaocala varchar(43) not null,
maraka decimal(14, 5) null,
zena int not null,
primary key (sifra),
foreign key (zena) references zena(sifra)
);

create table mladic (
sifra int not null,
suknja varchar(50) not null,
kuna decimal(16, 8) not null,
drugiputa datetime null,
asocijalno bit null,
ekstrovertno bit not null,
dukserica varchar(48) not null,
muskarac int null,
primary key (sifra),
foreign key (muskarac) references muskarac(sifra)
);