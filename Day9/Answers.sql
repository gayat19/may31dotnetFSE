select concat(au_lname,' ',au_fname) Author_name, pub_name Publisher_name, title Book_name,(price*qty) Sale_amount
from authors a join
titleauthor ta on ta.au_id = a.au_id
join titles t on t.title_id = ta.title_id
join sales s on s.title_id = t.title_id
join publishers p on p.pub_id = t.pub_id

--question 10 day8
select pub_name,count(emp_id) from 
publishers p join employee e on p.pub_id = e.pub_id
group by p.pub_name
having count(emp_id)>2

--question 11 day8
select  concat(au_lname,' ',au_fname) Author_name from authors a
join titleauthor ta on ta.au_id = a.au_id
join titles t on t.title_id = ta.title_id
join publishers p on p.pub_id = t.pub_id
where pub_name = 'Algodata Infosystems'

--or
select  concat(au_lname,' ',au_fname) Author_name from authors where au_id in
(select au_id from titleauthor where title_id in 
(select title_id from titles where pub_id = 
(select pub_id from publishers where pub_name =  'Algodata Infosystems')))

--question 12 day8
select concat(fname,' ',lname) Employee_name from employee
where pub_id = (select pub_id from publishers where pub_name = 'Algodata Infosystems')

select * from Skills

use dbJune10CodeFirst

select * from employees
sp_help employees

drop database dbJune10CodeFirst