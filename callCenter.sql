Create Database CallCenterDB
GO

Use CallCenterDB
GO

/* CREATING THE ADMIN'S TABLE - START*/
/* THE ADMIN IS DIFFERENT FROM THE ADMINSTARTOR*/
/* 1. THE ADMIN IS THE CEO'S AND ALL THE SENIOR STAFF*/
/* 2. THE ADMINSTARTOR IS THE CALL CENTER EMPLOYEE*/
CREATE TABLE admin(
	id varchar(15) PRIMARY KEY, 
	name varchar(100) not null,
	surname varchar(100) not null,
	username varchar(150) not null,
	password varchar(150) not null
);
GO
INSERT INTO admin(id, name, surname, username, password)
VALUES('159753123789654', 'admin', 'adminSurname', 'aSurname', '1234')
GO
/* CREATING THE ADMIN'S TABLE - END*/

/*Creating the ADMINSTARTOR's table - START*/
Create Table adminstrators(
	id varchar(15) PRIMARY KEY,
	name varchar(100) not null,
	surname varchar(100) not null,
	verified int default(0),
	username varchar(150) not null,
	password varchar(150) not null
);
GO

insert into adminstrators(id, name, surname, verified, username, password) 
values('258963147987563', 'Talaat','Elesh', 1, 'tElesh', '1234')
GO
insert into adminstrators(id, name, surname, verified, username, password) 
values('321879645369785', 'Elesh','Talaat', 0, 'eTalaat', '1234')
GO
/*Creating the ADMINSTARTOR's table - END*/

/*Creating the individual client table - START*/
Create table clientIndividual(
	id varchar(15) PRIMARY KEY, 
	name varchar(100) not null,
	surname varchar(100) not null,
	role varchar(100) not null,
	verified int default(0),
	username varchar(150) not null,
	password varchar(150) not null
);
GO

insert into clientIndividual(id, name, surname, role, username, password) 
VALUES('12365478965412', 'John', 'Smith', 'Buyer', 'jSmith','1234')
GO
update clientIndividual set verified=1 where id='12365478965412'
go
insert into clientIndividual(id, name, surname, role, username, password) 
VALUES('987564231145896', 'Smith', 'John', 'Buyer', 'sJohn', 1234)
GO
update clientIndividual set verified=1 where id='987564231145896'
go
insert into clientIndividual(id, name, surname, role, username, password) 
VALUES
('15385478966698', 'Walter', 'McKay', 'Buyer', 'wMcKay','1234'),
('58963254789652', 'Danielle', 'Wallace', 'Buyer', 'dWallace','1234'),
('23589645286593', 'Norman', 'Marshall', 'Buyer', 'nMarshall','1234'),
('25635589632457', 'Travis', 'Sanders', 'Buyer', 'tSanders','1234'),
('15896325478966', 'Bobbi', 'Gibson', 'Buyer', 'bGibson','1234'),
('89562578925536', 'Rochelle', 'Roberts', 'Buyer', 'rRoberts','1234')
go
/*Creating the indivisual client table - END*/

/*Creating the BUSINESS client table - START*/
create table businessClient(
	id varchar(15) Primary Key,
	name varchar(150) not null,
	location varchar(500) not null,
	email varchar(250) not null,
	verified int default(0),
	username varchar(150) not null,
	password varchar(150) not null
);
GO

Insert into businessClient(id, name, location, email, verified, username, password)
VALUES('123456987543654', 'takealot', 'Cape Town - South Africa', 'takealot123@gmail.com', 1, 'tLot', '1234')
GO
Insert into businessClient(id, name, location, email, verified, username, password)
VALUES('369852147852369', 'eveteck', 'Johannesburg - South Africa', 'evetech123@gmail.com', 0, 'eTech', '1234')
GO
Insert into businessClient(id, name, location, email, verified, username, password)
VALUES
('123456981425789', 'takealot', 'Cape Town - South Africa', 'takealot123@gmail.com', 0, 'tLot', '1234'),
('456892356895632', 'nedbank', 'Cape Town - South Africa', 'nedbank123@gmail.com', 1, 'nBank', '1234'),
('568923568952359', 'sap', 'Johannesburg - South Africa', 'sap123@gmail.com', 0, 'sap', '1234'),
('235896325789652', 'bain&company', 'Johannesburg - South Africa', 'baincompany123@gmail.com', 1, 'brainC', '1234'),
('235896523456892', 'pwc', 'Pretoria - South Africa', 'pwc123@gmail.com', 0, 'pwc', '1234'),
('123456987256319', 'olympus recorders', 'Midrand - South Africa', 'olympus123@gmail.com', 1, 'oRec', '1234')
GO
/*Creating the BUSINESS client table - END*/

/*Creating the PHONE table - START*/
create table phoneNumber(
	id int not null IDENTITY(1,1) PRIMARY KEY,
	phoneNumber varchar(10) not null,
	clientNumber varchar(15) not null,
	clientType varchar(15)
);
GO
/*Creating the PHONE table - END*/

/*Creating the Calls table - Start*/
create table calls(
	callID varchar(15) primary key,
	callLength varchar(150) not null,
	callTime varchar(150) not null,
	callStat varchar(20) not null,
	indiID varchar(150),
	busiID varchar(150)
);
go

insert into calls(callID, callLength, callTime, callStat,indiID)
VALUES('125436987258963', '10 min', '2021-03-18 - 6:21:54', 'Answered', '12365478965412')
go
/*Creating the Calls table - END*/

/*Creating the Technician Table - START*/
Create table technician(
	id varchar(15) primary key,
	name varchar(150) not null,
	surname varchar(150) not null,
	serviceID varchar(150),
	verified int default(0),
	username varchar(150) not null,
	password varchar(150) not null
);

insert into technician(id, name, surname, serviceID, verified, username, password)
VALUES('159357452369', 'Tech', 'Nician', '12365478965412', 1, 'Technician', '1234')
go
insert into technician(id, name, surname, serviceID, verified, username, password)
VALUES('ABCG12357951264', 'Nician', 'Tech', '12365478965412', 1, 'nTech', '1234')
go

/*Creating the Technician Table - END*/

/*Creating the Messages Table - START*/
CREATE TABLE sms(
	smsID varchar(15) not null Primary Key,
	incoming varchar(8000),
	outgoing varchar(8000),
	businessID varchar(15),
	individualID varchar(15),
	adminstratorID varchar(15),
	sentTime smalldatetime /*YYYY-MM-DD hh:mm:ss*/
);
/*sender - client*/
insert into sms(smsID, incoming, outgoing, businessID, individualID, adminstratorID, sentTime)
VALUES('159357452568', 'Hello, this is a test message from user', null, null, '15385478966698', null, GETDATE())
go
/*Receiver - admin*/
insert into sms(smsID, incoming, outgoing, businessID, individualID, adminstratorID, sentTime)
VALUES('147852369987452', null, 'Hello, this is a test message from admin', null, '15385478966698', '258963147987563', GETDATE())
go
/*Creating the Messages Table - END*/

/*Creating the TechnicianRequest Table - START*/
create table techRequest(
	id varchar(15) not null Primary Key,
	request varchar(8000),/*THIS COULD BE THE ISSUE OF THE CLIENT*/
	clientType varchar(15),
	clientID varchar(25),
	callEmployeeID Varchar(25),
	completed BIT default(0),
	accepted BIT default(0),
	acceptedTechnicianID varchar(25)
);

INSERT INTO techRequest(id, request, clientType, clientID, callEmployeeID, completed, accepted, acceptedTechnicianID)
VALUES('123478654123987','Hello this is a issue test.','individual','12365478965412','258963147987563',0,0,null);
GO
/*Creating the TechnicianRequest Table - END*/



/*Select*/
Select * from admin
Select * from adminstrators
Select * from clientIndividual
Select * from businessClient
select * from technician
Select * from calls
select * from sms
select * from techRequest
select * from phoneNumber
GO


/*USEFULL QUERRIES*/
/*DROP TABLES*/
DROP table phoneNumber
go
/*DELETE ENTRY*/
delete from clientIndividual where id='@id'
/*Select WHERE*/
SELECT * FROM admin WHERE username='aSurname' AND password='1234'
/*Alter table add column*/
ALTER table calls
add requestID varchar(25) default(null)
go
/*UPDATE*/
update techRequest set completed=1 where id='766916907793714' AND acceptedTechnicianID='ABCG12357951264'
GO



