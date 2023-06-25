create database DMS
use DMS
---------------------------------------------------------------
--1 USER TABLE
---------------------------------------------------------------

create table users
(
 id int Identity (1,1) NOT NULL,
 fullName varchar (30) NOT NULL,
 userName varchar (30) NOT NULL,
 userPassword varchar (30) NOT NULL
);
insert into users values('Ali','admin', 'admin')
delete from users
select * from users

---------------------------------------------------------------
--2 Register Donor
---------------------------------------------------------------

create table registerDonor
(
 donorID int primary key Identity (1,1) NOT NULL,
 donorName varchar (30) NOT NULL,
 donorPhone varchar (30) NOT NULL,
 donorEmail varchar (30) NOT NULL,
 donorAddress varchar (30) NOT NULL,
 donorStatus varchar (30) NOT NULL,
);
insert into registerDonor values('Ali','admin', 'admin')
delete from registerDonor
select * from registerDonor
drop table registerDonor
---------------------------------------------------------------
--3 Register Reciepient
---------------------------------------------------------------

create table registerRecipient
(
 recipID int primary key Identity (1,1) NOT NULL,
 recipName varchar (30) NOT NULL,
 recipFather varchar (30) NOT NULL,
 recipPhone varchar (30) NOT NULL,
 recipAddress varchar (30) NOT NULL,
 recipStatus varchar (30) NOT NULL
);
insert into registerRecipient values('Ali','admin', 'admin')
select * from registerRecipient
drop table registerRecipient
---------------------------------------------------------------
--4 Donate
---------------------------------------------------------------

create table donate
(
 donateID int primary key Identity (1,1) NOT NULL,
 donorName varchar (30) NOT NULL,
 donorPhone varchar (30) NOT NULL,
 donateItem varchar (30) NOT NULL,
 donateQuantity varchar (30) NOT NULL,
 donateDescription varchar (30) NOT NULL,
 donateDate varchar (30) NOT NULL
);
insert into donate values('Ali','admin', 'admin')
select * from donate
drop table donate
---------------------------------------------------------------
--5 Receive
---------------------------------------------------------------

create table receiveDonation
(
 receiverID int primary key Identity (1,1) NOT NULL,
 receiverName varchar (30) NOT NULL,
 receiverPhone varchar (30) NOT NULL,
 receiverItem varchar (30) NOT NULL,
 receiverQuantity varchar (30) NOT NULL,
 receiverDescription varchar (30) NOT NULL,
 receiverDate varchar (30) NOT NULL
);
insert into receiveDonation values('Ali','admin', 'admin')
select * from receiveDonation
drop table receiveDonation
-------------------------------------------
-----TABLE Employee
-------------------------------------------

create table employee
(
empID int not null identity primary key,
empName varchar (250) not null,
empPhone varchar (20) not null,
empEmail varchar (250) not null,
empAddress varchar (300) not null,
empPosition varchar (30) not null
)

drop table employee
select * from employee
alter table employee add  roomAllocated varchar(30)

