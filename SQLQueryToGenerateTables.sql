CREATE TABLE Appointments(
	date datetime,
	dentist json,
	patient json,
	reasonForAppointment nvarchar(50),
	priorityLevel int
);

CREATE TABLE Users(
	firstName varchar(50),
	lastName varchar(50),
	id varchar(50) NOT NULL,
	password varchar(50),
	email varchar(50),
	phoneNumber bigint
);