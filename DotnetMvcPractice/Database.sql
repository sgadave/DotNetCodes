create database iacsdcdac;
use iacsdcdac;
create table IacsdTable(Id int primary key,
			Dept varchar(25) not null,
			Bldg varchar(25));
create table StudentsTable(Id int primary key,
			Name varchar(25) not null,
			Course varchar(25) not null,
			Address varchar(25) not null);
insert into IacsdTable values(1,"DAC","B");
insert into IacsdTable values(2,"DBDA","B");
insert into IacsdTable values(3,"DITTIS","A");

insert into StudentsTable values(1,"Swapnil","DAC","Pune");
insert into StudentsTable values(2,"Pranav","DAC","Kolhapur");
insert into StudentsTable values(3,"Abhishek","DAC","Manglore");

