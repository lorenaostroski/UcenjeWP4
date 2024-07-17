use master;
go
drop database if exists narucivanjepacijenata;
go
create database narucivanjepacijenata;
go

use narucivanjepacijenata;

if object_id('pregledi', 'U') is not null drop table pregledi;
if object_id('ustanove', 'U') is not null drop table ustanove;
if object_id('usluge', 'U') is not null drop table usluge;
if object_id('zdravstvenidjelatnici', 'U') is not null drop table zdravstvenidjelatnici;
if object_id('pacijenti', 'U') is not null drop table pacijenti;

create table pregledi( 
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(30) not null,
datum date not null,
mbo char(9) not null,
dijagnoza varchar (30) not null,
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

select* from ustanove;

insert into ustanove(naziv, adresa)
values('KBC Osijek','Ulica Josipa Huttlera 4');

select * from zdravstvenidjelatnici;

insert into zdravstvenidjelatnici(ime,prezime, evidencijskibroj)
values('Hrvoje','Horvat',12345);

select * from usluge;

insert into usluge(naziv,datumvrijeme,priprema,zdravstvenidjelatnik)
values('Prvi pregled u ambulanti za Stražnji segment oka','2024-09-25 14:10:00' ,'Povest pratnju zbog moguæeg  mutnog vida','Hrvoje Horvat');

select * from pregledi;

insert into pregledi(ime,prezime,datum,mbo,dijagnoza,ustanova)
values('Ivan','Horvat','1969-08-15','123456789','Senilna katarakta',1);


select * from pacijenti;

insert into pacijenti(ustanova,usluga)
values (1,1);