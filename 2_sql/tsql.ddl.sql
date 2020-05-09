use AdventureWorks2017;
go
 
--create
create database PizzaBoxDb;  -- .mdf, .ndf, .ldf (master data file, non data file, log data file)
GO
 
create schema Pizza;
GO
 
create table Pizza.Pizza
(
    PizzaId int not null primary key identity(1,2)
    ,[Name] nvarchar(50) not null
    ,[Date] datetime2(7) check (Date >= getdate())
    ,[Active] bit default(1)
)
go
 
create view vw_Pizza with schemabinding
as
(
    select [name] from Pizza.Pizza
);
go
 
--escalar function, keep it small
create function fn_Pizza(@d datetime2, @n nvarchar)
returns nvarchar
as
begin
    return @n + ' ' + @d
end 
go
 
create function fn_Pizza2(@id int)
returns table
as
    return
    select *
    from Pizza.Pizza
    where PizzaId = @id
go
 
create procedure sp_Pizza(@name nvarchar)
as
begin
    begin transaction
        declare @checkname NVARCHAR
 
        select @checkname = name
        from Pizza.Pizza
        where name = @name
 
        if (@checkname is null)
        begin
            insert into Pizza.Pizza(name)
            values (@name)
 
            commit transaction
        end 
 
        else
        begin
            rollback transaction
        end 
end
