use pubs

--Select all rows
select * from authors

--select specific columns
select au_id,au_lname,au_fname from authors

--provide alias name for columns 
select au_id author_id,au_lname author_lastname ,au_fname author_firstname from authors

--where will restrict the rows
select * from authors where city = 'Gary'
select * from authors where au_lname = 'Ringer' and au_fname ='Anne'
select phone,address from authors  where city = 'Gary'
select au_fname author_name, phone,address from authors  where city = 'Gary'
-- more than one city
select * from authors where city = 'Gary' or city = 'Berkeley'
select * from authors where city in('Gary','Berkeley')

--sorting
select * from authors order by state
select au_fname author_name, phone,address from authors order by state
--sort descending
select * from authors order by state desc

--aggregate functions - most frequent - sum,count,min,max,avg
select count(au_id) from authors 
select count(au_id) from authors where state = 'CA'
select avg(price) average_of_price from titles
select sum(price) sum_of_price,AVG(price) average_of_price,min(price) minimum_price,max(price) maximum_price from titles

--group by
select * from titles

select pub_id,avg(price) average_of_price from titles
group by pub_id

--print the number of authors from every state
select state,COUNT(au_id) number_of_authors from authorsgroup by state
----print the number of authors from every state where there are more than 1 author
select state,count(au_id) Number_of_authors from authors 
group by state 
having count(au_id)>1

select state,count(au_id) from authors 
where au_fname like '%e%'
group by state 
having count(au_id)>1
order by state desc

select * from publishers

select * from titles
--print the titles published by teh publisher 'Ramona Publishers'
--sub queries
select pub_id from publishers where pub_name = 'Binnet & Hardley'
select title from titles where pub_id = '0877'


select title from titles where pub_id = 
(select pub_id from publishers where pub_name = 'Binnet & Hardley')
select * from pub_info
--cross join
select * from discounts cross join pub_info

--inner join
select title from titles
select pub_name from publishers

select title,pub_id from titles
select pub_name,pub_id from publishers

select titles.pub_id,title,pub_name from titles inner join publishers 
on titles.pub_id = publishers.pub_id
select titles.pub_id,title,pub_name from titles join publishers 
on titles.pub_id = publishers.pub_id


--get the publisher who have never published
select pub_id from titles
select distinct pub_id from titles
select * from publishers where pub_id not in (select distinct pub_id from titles)

--outer join
select titles.pub_id,title,pub_name from titles right outer join publishers 
on titles.pub_id = publishers.pub_id

--joining many tables
select pub_name,title,concat(au_fname,' ',au_lname) author_name 
from publishers p
join titles t on p.pub_id = t.pub_id
join titleauthor ta on t.title_id = ta.title_id
join authors a on a.au_id = ta.au_id
where a.state= 'CA'
order by pub_name


select p.pub_name,AVG(advance) from titles t join publishers pon p.pub_id = t.pub_idgroup by p.pub_name



