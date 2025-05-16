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

create table radionica(
radionica int primary key,
naziv varchar(100) not null,
opis text,
učiteljica int,
foreign key(uciteljica) references uciteljica(uciteljica)
);

--create table dijete radionica(
--dijete int,
--radionica int,
--primary key(dijete, radionica),
--foreign key(dijete) references dijete(dijete),
--foreign key(radionica) references radionica(radionica)
--);

