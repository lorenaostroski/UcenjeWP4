﻿use master;
go
drop database if exists narucivanjepacijenata;
go
create database narucivanjepacijenata collate Croatian_CI_AS;
go

use narucivanjepacijenata;


create table pregledi( 
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(30) not null,
datum date not null,
mbo char(9) not null,
dijagnoza varchar (40) not null,
ustanova int not null
);


create table ustanove(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
adresa varchar (35) not null
);


create table usluge(
sifra int not null primary key identity(1,1),
naziv varchar (100) not null,
datumvrijeme datetime not null,
priprema varchar(200) not null,
zdravstvenidjelatnik int not null
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
alter table usluge add foreign key (zdravstveni djelatnik) references zdravstvenidjelatnici(sifra);
alter table pacijenti add foreign key (usluga) references usluge (sifra);
alter table pacijenti add foreign key (ustanova) references ustanove (sifra);


select* from ustanove;

insert into ustanove(naziv, adresa) values
('KBC Osijek','Ulica Josipa Huttlera 4'),
('OŽB Našice','Ulica bana Jelačića 10'),
('OŽB Požega','Osječka 107');

select * from zdravstvenidjelatnici;

insert into zdravstvenidjelatnici(ime,prezime, evidencijskibroj) values
('Hrvoje','Horvat','12345'),
('Ivan','Ivić','54321'),
('Romina','Kralj','56789');

select * from usluge;

insert into usluge(naziv,datumvrijeme,priprema,zdravstvenidjelatnik) values
('Prvi pregled u ambulanti za Stražnji segment oka','2024-09-25 14:10:00' ,'Povest pratnju zbog moguæeg  mutnog vida',1),
('Gastroskopija','2024-11-11 09:10:00','Ako se pretraga obavlja u jutarnjim satima biti natašte, ako se obavlja poslijepodne ne jesti 6h prije pretrage.',2),
('Kontrolni pregled ortopeda','2024-10-25 11:45:00','Ponjeti povijest bolesti i popis lijekova koji su u stalnoj terpiji.',3);

select * from pregledi;

insert into pregledi(ime,prezime,datum,mbo,dijagnoza,ustanova) values
('Ivan','Horvat','1969-08-15','123456789','Senilna katarakta',1),
('Marko','Marković','1996-03-25','987654321','Gastroezofagealni refluks',2),
('Slavko','Makaj','1975-04-30','345678901','Dislokacija koljena',3);


select * from pacijenti;

insert into pacijenti(ustanova,usluga)values
(1,1),
(2,2),
(3,3);