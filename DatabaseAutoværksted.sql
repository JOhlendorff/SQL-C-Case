use master
IF EXISTS(select * from sys.databases where name='Autoværksted')
DROP DATABASE Autoværksted
CREATE DATABASE Autoværksted
go
use Autoværksted
go
create table kunder (
kundeid int primary key identity (1,1),
fornavn nvarchar(35),
efternavn nvarchar(35),
postnr int,
)


go
create table bil(
id int foreign key references kunder(kundeid),
mærke nvarchar(35),
model nvarchar(35),
årgang int,
km int,
brændstoftype nvarchar(35),
vægt int,
olie nvarchar(5)
)
go
create table værkstedsbesøg(
id int foreign key references kunder(kundeid),
CheckIn nvarchar(25),
CheckUd nvarchar(25),
)
go
create table værkstedsophold(
id int foreign key references kunder(kundeid),
DatoforCheckIn varchar(50),
DatoforCheckUd varchar(50)
)



insert into kunder values ('Morten', 'Pawgård', 2800)
select * from bil
truncate table kunder