create database DemoVendor

create table Person(
	Pname varchar(20),
	Phone varchar(10)
)
create table VendorMachine(
	MID varchar(10),
	MLocation varchar(20),
	SoldAmount int
)
create table Ticket(
	TID varchar(10),
	Destination varchar(20),
	UseDate date,
)
create table DetailPurchase(
	PName varchar(20),
	TID varchar(10),
	MID varchar(10),
	IssuedDate date,
)
drop table DetailPurchase

insert into Person values(N'Passenger 1','1234567891')
insert into Person values(N'Passenger 2','1234567892')
insert into Person values(N'Passenger 3','1234567893')

insert into VendorMachine values('M01','TDTU',200)
insert into VendorMachine values('M02','Lotte',300)
insert into VendorMachine values('M03','Cresent Mall',100)

insert into Ticket values('T001','TDTU','2023/3/10')
insert into Ticket values('T002','Lotte','2023/3/18')
insert into Ticket values('T003','TDTU','2023/3/11')

insert into DetailPurchase values(N'Passenger 1','T001','M03','2023/3/10')
insert into DetailPurchase values(N'Passenger 2','T002','M02','2023/3/10')
insert into DetailPurchase values(N'Passenger 3','T003','M01','2023/3/10')
select * from DetailPurchase
