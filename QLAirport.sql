use QLAirport

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

create table Routers
(
	RouterID char(10) primary key not null,
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
	RouterID char(10),
	FlightNumber nchar(20),
	EconomyPrice money,
	Confirmed int,
	foreign key(AircraftID) references Aircrafts(AircraftID),
	foreign key(RouterID) references Routers(RouterID)
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

