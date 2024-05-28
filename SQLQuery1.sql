use master;
go
drop database if exists narucivanjepacijenata;
go
create database narucivanjepacijenata;
go

use narucivanjepacijenata;

create table pregledi( 
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(30) not null,
datum datetime not null,
mbo char(9) not null,
dijagnoza varchar (30) not null,
naziv varchar(40) not null,
ustanova varchar(50)
);


create table ustanove(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
mjesto varchar (35) not null
);


create table usluge(
sifra int not null primary key identity(1,1),
naziv varchar (40) not null,
zdravstvenidjelatnik varchar (30) not null
);


create table zdravstvenidjelatnici(
sifra int not null primary key identity(1,1),
ime varchar (30) not null,
prezime varchar(30) not null,
evidencijskibroj char(5)
);


create table pacijenti(
usluga int not null,
ustanova int not null
);


alter table pregledi add foreign key (ustanova) references ustanove (sifra);
alter table pacijenti add foreign key (usluga) references usluge (sifra);
alter table pacijenti add foreign key (ustanova) references ustanove (sifra);


