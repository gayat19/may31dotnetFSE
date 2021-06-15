--Strored procedure creation
create procedure proc_First
as
begin
   select 'Hello World'
end

--Executing the stored procedure
exec proc_First

--Create procedure proc_First() begin select �hello world� as ' '; end

create proc proc_Add2Numbers(@num1 int,@num2 int)
as
begin
  declare 
   @sum int
   set @sum = @num1+@num2
   select @sum 'The sum'
end

exec proc_Add2Numbers 12,13
exec proc_Add2Numbers 45,67


create proc proc_Add2NumbersNAndGiveOut(@num1 int,@num2 int,@sum int out)
as
begin
   set @sum = @num1+@num2
end

begin
declare 
   @sum int
exec proc_Add2NumbersNAndGiveOut 12, 45, @sum out
select @sum
end

select * from titles

sp_help tid

create procedure proc_CalculatePrice(@tid varchar(6),@netPrice float out)
as
begin
  declare
  @price float,@royalty float,@grossPrice float
  set @price = (select price from titles where title_id =@tid)
  set @royalty = (select royalty from titles where title_id =@tid)
  set @grossPrice = @price-(@price*@royalty/100)
  set @netPrice = (@grossPrice*12.3/100)+@grossPrice
end

begin
declare 
   @net float
exec proc_CalculatePrice 'BU2075', @net out
select @net
end

create proc proc_PrintAllBills(@tid varchar(6))
as
begin
   select title Book_Name, price Book_Price, qty Quantity, price Unit_price, qty*price amount
   from titles join sales on titles.title_id = sales.title_id
   where titles.title_id = @tid
end

exec proc_PrintAllBills 'BU1032'

sp_helptext proc_PrintAllBills
--Create a procedure that will take the publisherid and print books the 
--publisher has pulished along with the author name
create proc proc_PrintBooks(@pid varchar(6))
  select * from publishers
  exec proc_PrintBooks '1389'

  --Create a procedure that will take the titleId and print the titlename,unit price and 
  --the total sale amount
  create proc proc_totalsaleamt(@tid varchar(6))
--Create a procedure that will take the author first name and 
--print the title, author fullname and the publisher name of all his/her books
create proc proc_FindAllAuthorBooks (@aid varchar(6))

exec proc_FindAllAuthorBooks 'Cheryl'

select title,concat(au_fname,' ',au_lname) AuthorName,pub_name

  create proc proc_GetAllAuthors
  as
    select * from authors

