use master
IF EXISTS(select * from sys.databases where name='Autov�rksted')
DROP DATABASE Autov�rksted
CREATE DATABASE Autov�rksted
go
use Autov�rksted
go
create table kunder (
id int primary key identity (1,1),
fornavn nvarchar(35),
efternavn nvarchar(35),
postnr int,
)


go
create table bil(
id int foreign key references kunder(kundeid),
regnr int primary key identity(1,1),
m�rke nvarchar(35),
model nvarchar(35),
�rgang int,
km int,
br�ndstoftype nvarchar(35),
v�gt int,

)
go
create table v�rkstedsbes�g(
id int foreign key references bil(regnr),
CheckIn nvarchar(25),
CheckUd nvarchar(25),
)
go
create table v�rkstedsophold(
id int foreign key references bil(regnr),
DatoforCheckIn varchar(50),
DatoforCheckUd varchar(50)
)

--insert into bil values ('BMW','Sport','2019','100','Nitro','420)
insert into bil values (2, 'lort', 'mig', 2008, 200000, 'tis',100)
--insert into kunder values ('Morten', 'Pawg�rd', 2800)
select * from bil
--truncate table kunder
