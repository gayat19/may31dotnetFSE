--selecting a database
--always select master for creating a new database
use master

--creating a new databse
create database dbCompany

--select the database you created
use dbCompany

--creating a table
create table Skills
(skill_name varchar(50) primary key,
Skill_description varchar(1000)
)

--view the table details
sp_help skills

--creating the area table
create table Areas
(area_name varchar(20) primary key,
zip_code char(6) not null)

--describing the area table
sp_help areas

--creating the employee table
--identity will do auto insert numbers (suitable for primary key)
--identity(seed,increment)-> seed is the starting value
--area_name will be the foreign key from the area table
create table Employees
(id int identity(1,1) primary key,
name varchar(20) not null,
date_of_birth date,
area varchar(20) references areas(area_name),
phone varchar(15))

--viewing the table details
sp_help employees

--creating teh employeeskill table
--composite key
create table EmployeeSkill
(employee_id int references Employees(id),
skill_name varchar(50) references skills(skill_name),
skill_level float,
primary key(employee_id,skill_name))

--viewing the EmployeeSkill table details
sp_help EmployeeSkill

--altering a table to add a column
alter table employees
add address varchar(1000)

--alter the table to alter the column
alter table employees
alter column address text

--altering a table to delete a column
alter table employees
drop column address 

--delete a table
-- table will be deleted only of there is no child table for it
--this will not work because area is the parent table for employee
drop table Areas
--- this will work coz it has no child table
drop table EmployeeSkill


