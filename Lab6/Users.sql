use [Lab6-7]

create table Roles
(
	id int not null identity(1, 1) primary key,
	title varchar(15) unique
);

create table Users
(
    id int not null identity(1, 1) primary key,
	login nvarchar(20) not null,
	password nvarchar(20) not null,
	role int not null foreign key references Roles(id)
);