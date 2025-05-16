create database osnovna skola;

create table dijete(
dijete int primary key,
ime varchar(50) not null,
prezime varchar(50)not null,
datum rodenja date
);

create table uciteljca(
uciteljica int primary key,
ime varchar(50) not null,
prezime varchar(50) not null,
predmet varchar(50)
);

--create table radionica(
--radionica int primary key,
--naziv varchar(100) not null,
--opis text,
--učiteljica int,
--foreign key(uciteljica) references uciteljica(uciteljica)
--);