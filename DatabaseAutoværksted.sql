use master
go
create database Autov�rksted
go
use Autov�rksted
go
create table kunder (
kundeid int primary key,
fornavn nvarchar(35),
efternavn nvarchar(35),
postnr int,
)


go
create table bil(
id int foreign key references kunder(kundeid),
m�rke nvarchar(35),
model nvarchar(35),
�rgang int,
km int,
br�ndstoftype nvarchar(35),
v�gt int,
olie nvarchar(5)
)
go
create table v�rkstedsbes�g(
id int foreign key references kunder(id),
CheckIn nvarchar(25),
CheckUd nvarchar(25),
)
go
create table v�rkstedsophold(
id int foreign key references kunder(kundeid),
DatoforCheckIn varchar(50),
DatoforCheckUd varchar(50)
)




select * from kunder
truncate table kunder