create database dbTest14June

use dbTest14June

create table Customer
(id int identity(101,1) primary key,
name varchar(50) not null,
age int default 18, 
phone varchar(15),
type varchar(10) check(type in('Gold','Silver')))



insert into Customer(name,age,phone,type) values('Jim',29,'9876543210','Gold'),
('Vim',21,'4321098765','Silver'),
('Sim',35,'5432987610','Gold'),
('Jam',56,'2109876543','Silver')

select * from Customer

--Select those customer whose name starts with 'J'
select * from Customer where name like 'J%'
--Select those customers who have age greater than the average age of all the customers
select * from customer where age > (select AVG(age) from customer)
--Print the number of cusomers in every type
select type,count(id) number_of_customers
from customer
group by type