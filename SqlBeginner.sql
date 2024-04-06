/*
SQL (Structured Query Language): Veri Sorgulama Dili
SQL YAZILIMLAR: MSSQL(Microsoft SQL Server)- C# Windows
				MySQL - PHP Linux
				PLSQL - Oracle
				SQLite - Python
				PostgreSQL

T-SQL(Transact SQL) : Bir yaz�l�m diliyle yap�labilecek bir �ok i�lemi SQL taraf�nda yap�labilmesini sa�lar.

		*** k���k B�Y�K harf duyarl�l��� YOKTUR ***
*/

-- DATABASE OLU�TURMA
Create database SinifDB

-- TABLO OLU�TURMA
create table Ogretmen(
Id int not null,
Name varchar(20) not null,
Address varchar(100) not null
)

-- TABLOYA VER� EKLEME
insert into Ogretmen (Id,Address,Name) values (1,'Beykoz','Esra')
insert into Ogretmen (Id,Address,Name) values (2,'Pendik','Buse')
insert into Ogretmen (Id,Address,Name) values (3,'Beyo�lu','Sercihan')
insert into Ogretmen (Id,Address,Name) values (4,'Bayrampa�a','U�ur')
insert into Ogretmen (Id,Address,Name) values (5,'Tuzla','Ahmet')

-- TABLODA VER� G�NCELLEME
update Ogretmen set Address='Pendik' where Name='Esra'
update Ogretmen set Address='Beykoz' where Id=2

-- TABLODAN VER� S�LME
Delete from Ogretmen where Name='buse'


-- TABLODAN VER� OKUMA
seLECt Name,Address,Id From Ogretmen
seLECt Name,Id From Ogretmen

seLECt Id,Name,Address From Ogretmen
Select * from Ogretmen

Select * from Ogretmen where Id>3
Select * from Ogretmen where Address='Beykoz'

select * from Ogretmen where Address like 'B%'
select * from Ogretmen where Address like '%oz'
select * from Ogretmen where Address like '%e%'


