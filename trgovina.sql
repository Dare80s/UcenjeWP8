----create database trgovina;
--use master;
--go
--drop database if exists trgovina;
--go
--create database trgovina;
--go
--use trgovina;

--create table racuni(
--sifra int,
--broj varchar(10),
--kupac varchar(100)
--);

--create table proizvodi(
--sifra int,
--naziv varchar(50),
--cijena decimal(18,2)
--);

create table stavke(
racun int,
proizvod int,
kolicina decimal(5,3)
);



