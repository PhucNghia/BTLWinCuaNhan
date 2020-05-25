create database QLAirport
use QLAirport
drop database QLAirport

create table Countries
(
	CountryID nchar(20) primary key not null,
	CountryName nchar(20)
)

create table Aircrafts
(
	AircraftID char(10) primary key not null,
	AircraftName nchar(20),
	MakeModel nchar(20),
	TotalSeats char(10),
	EconomySeats char(10),
	BussinesSeats char(10)
)

create table Airports
(
	AirportID char(10) primary key not null,
	CountryID nchar(20) not null,
	IATAcode char(20),
	AirportName nchar(20),
	foreign key(CountryID) references Countries(CountryID)
)

create table Routes
(
	RouteID char(10) primary key not null,
	DepartureAirportID char(10) not null,
	ArrivalAirportID char(10) not null,
	Distance float,
	FlightTime datetime,
	foreign key(DepartureAirportID) references Airports(AirportID),
	foreign key(ArrivalAirportID) references Airports(AirportID)
)

create table Schedules
(
	SchedulesID char(10) primary key not null,
	DateFlight date,
	TimeFlight time,
	AircraftID char(10),
	RouteID char(10),
	FlightNumber nchar(20),
	EconomyPrice money,
	Confirmed int,
	foreign key(AircraftID) references Aircrafts(AircraftID),
	foreign key(RouteID) references Routes(RouteID)
)

create table Offices
(
	OfficesID char(10) not null primary key,
	CountryID nchar(20) not null,
	Title nchar(20),
	Phone char(20),
	Contant nchar(20),
	foreign key(CountryID) references Countries(CountryID)
)

create table Roles
(
	RoleID char(10) primary key not null,
	RoleTilte nchar(20)
)

create table Users
(
	UserID char(10) primary key not null,
	RoleID char(10) not null,
	OfficeID char(10) not null,
	Email nchar(30),
	PasswordUser nchar(20),
	FirstName nchar(20),
	LastName nchar(20),
	BirthDay date,
	Active int,
	foreign key(RoleID) references Roles(RoleID),
	foreign key(OfficeID) references Offices(OfficesID)
)

/* chen du lieu cho bang Roles*/

insert into Roles values ('R01 ','admin ')
insert into Roles values ('R02 ','user ')

/* chen du lieu cho bang Countries*/

insert into  Countries  values ('C01','Viet Nam ')
insert into  Countries  values ('C02','Han Quoc  ')
insert into  Countries  values ('C03','Singapore ')
insert into  Countries  values ('C04','Thai Lan ')
insert into  Countries  values ('C05','Campuchia ')

/* chen du lieu cho bang Aircrafts*/

insert into  Aircrafts  values ('A350-900 ',' Airbus A350-900','Airbus ',' 350','320 ','30 ')
--insert into  Aircrafts  values ('787-9 ','Boeing 787-9 ','Boeing ',' 270','240 ','30 ')
--insert into  Aircrafts  values ('A320-200 ',' Airbus A320-200','Airbus ',' 180','180','0 ')
--insert into  Aircrafts  values ('787-10 ','Boeing 787-9 ','Boeing ',' 360','320 ','40 ')
insert into  Aircrafts  values ('72-200 ',' ATR 72-200','ART  ',' 100','90 ','10 ')

/* chen du lieu cho bang Offices*/

insert into  Offices   values ('O01 ','C01 ','L01 ','0123456789 ',' Ms.Hoa')
insert into  Offices   values ('O02 ','C02 ','L02 ','0241666398 ',' Mr.Bao')
insert into  Offices   values ('O03 ','C03 ','L03 ','0333876209 ',' Ms.Hien')
insert into  Offices   values ('O04 ','C04 ','L04 ','0345129907 ',' Mr.Ha')
insert into  Offices   values ('O05 ','C05 ','L05 ','0398136520 ',' Mr.Tuan Anh')

/* chen du lieu cho bang Users */

insert into  Users  values ('U01 ','R02 ','O01 ','nguyenduyen2101993@gmail.com ',' 2101993','Nguyen Thi ',' Duyen',
                            '2/10/1990 ',' 1')
insert into  Users  values ('U02 ','R01 ','O03 ','phamquynhanh1992@gmail.com ',' quynhanh1992','Pham Quynh ',' Anh',
                            '6/6/1992 ',' 1')
insert into  Users  values ('U03 ','R02 ','O04 ','maihongngoc97@gmail.com ',' ngoc2412','Mai Hong ',' Ngoc',
                            '12/24/1997 ',' 1')
insert into  Users  values ('U04 ','R02 ','O05 ','thanhduy111987@gmail.com ',' duy1987','Dang ',' Thanh Duy',
                            '1/1/1987 ',' 0')
insert into  Users  values ('U05 ','R01 ','O02 ','giabao148@gmail.com ','123456789','Nguyen  ',' Gia Bao',
                            '8/14/2017 ',' 1')


/* chen du lieu cho bang Airports*/

insert into  Airports   values ('D01','C01','HAN',' Noi Bai')
insert into  Airports   values ('D02','C05','REP',' Angkor')
--insert into  Airports   values ('D03','C02','ICN',' Incheon')
insert into  Airports   values ('D04','C04','HKT',' Phuket')
insert into  Airports   values ('D05','C03','SIN',' Changi Singapore')



/* chen du lieu cho bang Routes*/

insert into  Routes  values ('B01','D01','D05','12000','5/5/2019')
insert into  Routes  values ('B02','D02','D04','10000','2/8/2019')
--insert into  Routes  values ('B03','D03','D03','1000','1/10/2019')
--insert into  Routes  values ('B04','D04','D02','9000','5/26/2019')
--insert into  Routes  values ('B05','D05','D01','2000','10/26/2019')

--insert into  Routes  values ('B06','D02','D01','2000','10/2/2019')
--insert into  Routes  values ('B07','D02','D03','15000','12/8/2019')
--insert into  Routes  values ('B08','D03','D02','1000','1/10/2019')
--insert into  Routes  values ('B09','D04','D01','3000','6/26/2019')
--insert into  Routes  values ('B10','D05','D01','2000','12/26/2019')


/* chen du lieu cho bang Schedules*/

insert into  Schedules   values ('S01','5/5/2019 ','12:00:00 ','A350-900 ','B01','320 ','300  ',' 1')
insert into  Schedules   values ('S02','5/26/2019 ','9:45:00 ','72-200 ','B02','100 ','100  ',' 0')
--insert into  Schedules   values ('S03','2/8/2019 ','15:00:00 ','A320-200 ','B02','170 ','200  ',' 1')
--insert into  Schedules   values ('S04','10/26/2019 ','20:00:00 ','787-10 ','B05','350','400  ',' 0')
--insert into  Schedules   values ('S05','10/10/2019 ','00:00:00 ','787-9 ','B09','270 ','200  ',' 0')

--insert into  Schedules   values ('S06','5/5/2019 ','13:00:00 ','A350-900 ','B02','320 ','300  ',' 1')
--insert into  Schedules   values ('S07','5/26/2019 ','19:45:00 ','72-200 ','B07','100 ','100  ',' 0')
--insert into  Schedules   values ('S08','2/8/2019 ','14:00:00 ','A320-200 ','B08','170 ','200  ',' 1')
--insert into  Schedules   values ('S09','10/26/2019 ','20:00:00 ','787-10 ','B02','350','400  ',' 0')
--insert into  Schedules   values ('S10','1/10/2019 ','01:00:00 ','787-9 ','B09','270','200 ',' 1')

select * from Roles
select * from Countries
select * from Aircrafts
select * from Offices
select * from Users
select * from Airports
select * from Routes
select * from Schedules 

select * from Schedules
select * from Routes
select * from Aircrafts
select * from Airports

/*
drop table Schedules 
drop table Routes
drop table Airports
drop table Users
drop table Offices
drop table Aircrafts
drop table Countries
drop table Roles
*/


select DateFlight as 'Date', TimeFlight, fromAirport.IATAcode, toAirport.IATAcode, Aircrafts.AircraftID, EconomyPrice as 'Economy Price',
(EconomyPrice*35/100)+EconomyPrice as 'Bussiness Price', ((EconomyPrice*35/100)+EconomyPrice)*30/100+(EconomyPrice*35/100+EconomyPrice) as 'First class Price'  from Schedules 
join Routes on Schedules.RouteID=Routes.RouteID
join Airports as fromAirport on Routes.ArrivalAirportID=fromAirport.AirportID
join Airports as toAirport on Routes.DepartureAirportID=toAirport.AirportID
join Aircrafts on Schedules.AircraftID=Aircrafts.AircraftID