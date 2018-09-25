use master
IF EXISTS(select * from sys.databases where name='Autoværksted')
DROP DATABASE Autoværksted
CREATE DATABASE Autoværksted
go
use Autoværksted
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
mærke nvarchar(35),
model nvarchar(35),
årgang int,
km int,
brændstoftype nvarchar(35),
vægt int,

)
go
create table værkstedsbesøg(
id int foreign key references bil(regnr),
CheckIn nvarchar(25),
CheckUd nvarchar(25),
)
go
create table værkstedsophold(
id int foreign key references bil(regnr),
DatoforCheckIn varchar(50),
DatoforCheckUd varchar(50)
)

--insert into bil values ('BMW','Sport','2019','100','Nitro','420)
insert into bil values (2, 'lort', 'mig', 2008, 200000, 'tis',100)
--insert into kunder values ('Morten', 'Pawgård', 2800)
select * from bil
--truncate table kunder
