create database IacsdDb;
use IacsdDb;
create table IacsdTable(CourseId int primary key,
			CourseName varchar(25) not null,
			CourseBldg varchar(25));
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
insert into StudentsTable values(4,"Prathamesh","DAC","Parali");
insert into StudentsTable values(5,"Swanand","DITTIS","Pune");
insert into StudentsTable values(6,"Prakash","DITTIS","Nashik");
insert into StudentsTable values(7,"Neeraj","DITTIS","Jaipur");
insert into StudentsTable values(8,"Pradeep","DBDA","Nagpur");
insert into StudentsTable values(9,"Bhavesh","DBDA","Pune");
insert into StudentsTable values(10,"Mayank","DBDA","Amravati");