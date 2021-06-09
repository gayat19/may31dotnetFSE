--select the database you created
use dbCompany

--insert records to area table
insert into Areas values('AAA','12345')
--Will rainse a error coz of duplicate primary key
insert into Areas values('AAA','12345')
--Will raise an erree coz of null for primary key
insert into Areas values(null,'12345')

select * from Areas

--insert records in skill table
insert into Skills(Skill_description,skill_name) values('PLT','C')
insert into skills values('C++','OOPS')
insert into Skills values('Java','Web'),('SQL','RDBMS')

--to view all teh records
select * from Skills

--inserto to employee table
insert into Employees(name,date_of_birth,area,phone) values('ABC','06-14-2000','AAA','9876543210')
insert into Employees(name,date_of_birth,area,phone) values('XYZ','02-23-1999','AAA','9876543210')
--Failed inserts - violation of foriegn key constraint
insert into Employees(name,date_of_birth,area,phone) values('XYZ','02-23-1999','BBB','9876543210')

select * from Employees

--Employee skills Insert
insert into EmployeeSkill values(1,'C',7)
insert into EmployeeSkill values(1,'C++',7)

select * from EmployeeSkill

--update 
update EmployeeSkill set skill_level=8 where skill_name='C++' and employee_id=1

--delete row
delete from EmployeeSkill where skill_name='C++' and employee_id=1
--Delete all rows
delete from EmployeeSkill