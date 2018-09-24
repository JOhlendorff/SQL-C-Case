use master
go
create database Autoværksted
go
use Autoværksted
go
create table kunder (
id int primary key,
navn nvarchar(35),
adr nvarchar(50),
alder int)


go
create table bil(
id int foreign key references kunder(id),
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
id int foreign key references kunder(id),
CheckIn nvarchar(25),
CheckUd nvarchar(25),
)
go
create table værkstedsophold(
DatoforCheckIn varchar(50),
DatoforCheckUd varchar(50)
)




select * from kunder
truncate table kunder