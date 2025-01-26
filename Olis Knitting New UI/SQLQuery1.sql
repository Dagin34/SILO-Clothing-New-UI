create table Employees
(
	EmployeeId int primary key,
	FirstName varchar(40) not null,
	LastName varchar(40) not null,
	PhoneNumber varchar(13) not null,
	YarnCount int default 0,
	check (YarnCount >= 0)
)

--

alter table Employees 
add Salary int default 0

--

create table Customers
(
	CustomerId int primary key,
	FirstName varchar(40) not null,
	LastName varchar(40) not null,
	PhoneNumber varchar(13) not null unique
)

--

create table Items
(
	ItemId int primary key,
	Type varchar(20) not null,
	Color varchar(20) not null,
	Size varchar(5) not null,
	Quantity int default 1,
	Check (Quantity >=1)
)

--

create table Orders
(
	OrderId int primary key,
	CustomerId int not null,
	ItemId int not null,
	OrderDate date not null,
	DeliveryDate date not null,
	DeliveryLocation varchar(100) not null,
	Status varchar(10) default 'Pending',
	Check (Status IN ('Pending', 'Delivered', 'Finished')),
	Progress int default 0,
	Check (Progress in (0,25,50,100)),
	Paid varchar(10) default 'Not Paid',
	Check (Paid in ('Paid', 'Not Paid')),
	constraint fk_customerId
		foreign key (CustomerId) references Customers(CustomerId),
	constraint fk_itemId
		foreign key (ItemId) references Items(ItemId)
)

--

create table Commissions
(
	ComId int primary key,
	EmployeeId int not null,
	OrderId int not null,
	Commission int,
	constraint fk_empId
		foreign key (EmployeeId) references Employees(EmployeeId),
	constraint fk_orderId
		foreign key (OrderId) references Orders(OrderId)
)

-- Some Fixes

alter table Commissions
drop constraint uniqueForEmp					-- dropped the constraint (wasnt dropped in the previous versions)
    --unique(EmployeeId)

alter table Employees
add PhoneNumber varchar(13) 

alter table Employees 
add constraint uniqueForNumber
	unique(PhoneNumber)

alter table Items 
alter column Price int

alter table Items 
drop constraint DF__Items__Price__14270015

alter table Items
add Name varchar(50)

alter table Orders
add Quantity int default 0 check(Quantity >= 0)

alter table Orders
add constraint CK__Orders__Progress__440B1D61
Check (Progress in(0,25,50,75,100))



-- ============================ EMPLOYEES MANIPULATION ============================

go

create or alter proc GetAllEmplopyee
as
begin
	select * from Employees
end

go

create or alter proc EmployeeByName
    @NameChecker varchar(20)
as
begin
    select EmployeeId, FirstName, LastName, PhoneNumber, YarnCount , Salary
    from Employees as E
    where E.FirstName like '%' + @NameChecker + '%' OR E.LastName like '%' + @NameChecker + '%'
end

go

create or alter proc EmployeeByYarnCount
    @YarnCount int
as
begin
    select EmployeeId, FirstName, LastName, PhoneNumber, YarnCount, Salary
    from Employees as E
    where @YarnCount = YarnCount
end

go

create or alter proc EmployeeByNumber 
    @Number varchar(13)
as
begin
    select EmployeeId, FirstName, LastName, PhoneNumber, YarnCount, Salary
    from Employees as E
    where PhoneNumber like '%'+ @Number + '%'
end

go
  
create or alter proc InsertEmployee
    @FirstName varchar(40),
    @LastName varchar(40),
    @PhoneNumber varchar(13),
    @YarnCount int,
	@Salary int
as
begin
    if @YarnCount >= 0
    begin
        DECLARE @EmployeeId int
        SELECT @EmployeeId = ISNULL(MAX(EmployeeId), 0) + 1 FROM Employees
        INSERT INTO Employees (EmployeeId, FirstName, LastName, PhoneNumber, YarnCount, Salary)
        VALUES (@EmployeeId, @FirstName, @LastName, @PhoneNumber, @YarnCount, @Salary)
    end
end

go

create or alter proc updateEmployee
	@EmployeeId int,
	@FirstName varchar(40),
	@LastName varchar(40),
	@PhoneNumber varchar(13),
	@YarnCount int,
	@Salary int
as
begin
	if @YarnCount >= 0
		begin
		update Employees
		set FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, YarnCount = @YarnCount, Salary = @Salary
		where EmployeeId = @EmployeeId
	end
end

go

create or alter proc deleteEmployee
	@EmployeeId int
as
begin
	delete from Employees 
	where EmployeeId = @EmployeeId
end

go

create or alter proc EmployeeExists
	@EmpId int
as
begin
	select * from Commissions where EmployeeId = @EmpId
end

go
-- ============================ ITEMS MANIPULATION ============================

go

select * from Items

go

create or alter proc GetAllItems
as
begin
	select ItemId, Name, Type, Color, Size, Quantity, Price from Items
end

update Items set Size = 'XL' where Size = 'O/S'

go

create or alter proc SearchItemByType
	@Type varchar(30)
as
begin
	select ItemId, Name, Type, Color, Size, Quantity, Price from Items
	where Type like '%' + @Type + '%'
end

go

create or alter proc SearchItemByColor
	@Color varchar(30)
as
begin
	select ItemId, Name, Type, Color, Size, Quantity, Price from Items
	where Color like '%' + @Color + '%'
end

go

create or alter proc SearchItemByName
	@Name varchar(30)
as
begin
	select ItemId, Name, Type, Color, Size, Quantity, Price from Items
	where Name like '%' + @Name + '%'
end

go

create or alter proc InsertItems
	@Name varchar(50),
	@Type varchar(30),
	@Color varchar(30),
	@Size varchar(5),
	@Quantity int,
	@Price int
as
begin
	if @Quantity >= 0 and @Price >= 0
    begin
        DECLARE @ItemId int
        SELECT @ItemId = ISNULL(MAX(ItemId), 0) + 1 FROM Items
        INSERT INTO Items (ItemId, Name, Type, Color, Size, Quantity, Price)
        VALUES (@ItemId, @Name, @Type, @Color, @Size, @Quantity, @Price)
    end
end

go


create or alter proc UpdateItems
	@ItemId int,
	@Name varchar(50),
	@Type varchar(30),
	@Color varchar(30),
	@Size varchar(5),
	@Quantity int,
	@Price int
as
begin
	if @Quantity >= 0 and @Price >= 0
    begin
        update Items
		set Name = @Name, Type = @Type, Color = @Color, Size = @Size, Quantity = @Quantity, Price = @Price
		where @ItemId = ItemId
    end
end

go

create or alter proc DeleteItems
	@ItemId int
as
begin
    delete from Items
	where @ItemId = ItemId
end

go

create or alter proc ItemExists
	@ItemId int
as
begin
	select * from Orders where ItemId = @ItemId
end

go

-- ============================ CUSTOMERS MANIPULATION ============================
go

create or alter proc GetCustomers
as
begin
	select CustomerId, FirstName, LastName, PhoneNumber from Customers
end

go

create or alter proc SearchCustomersByName
	@NameChecker varchar(40)
as
begin
	select CustomerId, FirstName, LastName, PhoneNumber from Customers
	where FirstName like '%' + @NameChecker + '%' or LastName like '%' + @NameChecker + '%'
end

go

create or alter proc SearchCustomersByNumber
	@Number varchar(13)
as
begin
	select CustomerId, FirstName, LastName, PhoneNumber from Customers
	where PhoneNumber like '%' + @Number + '%' 
end

go
  
create or alter proc InsertCustomer
    @FirstName varchar(40),
    @LastName varchar(40),
    @PhoneNumber varchar(13)
as
begin
    DECLARE @CustomerId int
    SELECT @CustomerId = ISNULL(MAX(CustomerId), 0) + 1 FROM Customers
    INSERT INTO Customers (CustomerId, FirstName, LastName, PhoneNumber)
    VALUES (@CustomerId, @FirstName, @LastName, @PhoneNumber)
end

go


create or alter proc updateCustomer
	@CustomerId int,
	@FirstName varchar(40),
	@LastName varchar(40),
	@PhoneNumber varchar(13)
as
begin
	update Customers
	set FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber 
	where CustomerId = @CustomerId
end

go

create or alter proc deleteCustomer
	@CustomerId int
as
begin
	delete from Customers 
	where CustomerId = @CustomerId
end

go

create or alter proc CustomerExists
	@CustId int
as
begin
	select * from Orders where CustomerId = @CustId
end

go

-- ============================ ORDERS MANIPULATION ============================

go

create or alter proc AllOrders
as
begin
	select O.OrderId, C.FirstName, C.LastName, I.Type, I.Color, I.Size, O.Quantity, O.OrderDate,
	O.DeliveryDate, O.DeliveryLocation, O.Status, O.Progress, O.Paid
	from Orders as O
	inner join Customers as C
		on O.CustomerId = C.CustomerId
	inner join Items as I
		on I.ItemId = O.ItemId
end

go

create or alter proc OrderByName
	@NameChecker varchar(40)
as
begin
	select O.OrderId, C.FirstName, C.LastName, I.Type, I.Color, I.Size, O.Quantity, O.OrderDate,
	O.DeliveryDate, O.DeliveryLocation, O.Status, O.Progress, O.Paid
	from Orders as O
	inner join Customers as C
		on O.CustomerId = C.CustomerId
	inner join Items as I
		on I.ItemId = O.ItemId
	where C.FirstName like '%'+@NameChecker+'%' or C.LastName like '%'+@NameChecker+'%'
end

go

create or alter proc SendBackCustomerId
	@firstname varchar(40),
	@lastname varchar(40)
as
begin
	select CustomerId from Customers where FirstName = @firstname and LastName = @lastname
end

go

create or alter proc SendBackItemId
	@type varchar(40),
	@color varchar(40),
	@size varchar(5)
as
begin
	select ItemId from Items where Type = @type and Color = @color and Size = @size
end

go

create or alter proc insertOrder
	@CustomerId int,
	@ItemId int,
	@OrderDate date,
	@DeliveryDate date,
	@Location varchar(50),
	@Status varchar(30),
	@Progress varchar(30),
	@Paid varchar(30),
	@Quantity int
as
begin
	DECLARE @OrderId int
    SELECT @OrderId = ISNULL(MAX(OrderId), 0) + 1 FROM Orders

	insert into Orders (OrderId, CustomerId, ItemId, OrderDate, DeliveryDate, DeliveryLocation, Status, Progress, Paid, Quantity) values
	(@OrderId, @CustomerId, @ItemId, @OrderDate, @DeliveryDate, @Location, @Status, @Progress, @Paid, @Quantity)
end

go

create or alter proc updateOrder
	@OrderId int,
	@CustomerId int,
	@ItemId int,
	@OrderDate date,
	@DeliveryDate date,
	@Location varchar(50),
	@Status varchar(30),
	@Progress varchar(30),
	@Paid varchar(30),
	@Quantity int
as
begin
	update Orders
	set CustomerId = @CustomerId, ItemId = @ItemId, OrderDate = @OrderDate, DeliveryDate = @DeliveryDate, DeliveryLocation = @Location,
		Status = @Status, Progress = @Progress, Paid = @Paid, Quantity = @Quantity 
	where OrderId = @OrderId

end
select * from Items
go

create or alter proc deleteOrder
	@OrderId int
as
begin
	delete from Orders 
	where OrderId = @OrderId 
end

go

create or alter proc AllOrdersByStatusProgress
	@stat varchar(20),
	@prog int
as
begin
	select O.OrderId, C.FirstName, C.LastName, I.Type, I.Color, I.Size, O.Quantity, O.OrderDate,
	O.DeliveryDate, O.DeliveryLocation, O.Status, O.Progress, O.Paid
	from Orders as O
	inner join Customers as C
		on O.CustomerId = C.CustomerId
	inner join Items as I
		on I.ItemId = O.ItemId
	where O.Status = @stat and O.Progress = @prog
end

go

create or alter proc AllOrdersByStatus
	@stat varchar(20)
as
begin
	select O.OrderId, C.FirstName, C.LastName, I.Type, I.Color, I.Size, O.Quantity, O.OrderDate,
	O.DeliveryDate, O.DeliveryLocation, O.Status, O.Progress, O.Paid
	from Orders as O
	inner join Customers as C
		on O.CustomerId = C.CustomerId
	inner join Items as I
		on I.ItemId = O.ItemId
	where O.Status = @stat
end

go

create or alter proc AllOrdersByProgress
	@prog int
as
begin
	select O.OrderId, C.FirstName, C.LastName, I.Type, I.Color, I.Size, O.Quantity, O.OrderDate,
	O.DeliveryDate, O.DeliveryLocation, O.Status, O.Progress, O.Paid
	from Orders as O
	inner join Customers as C
		on O.CustomerId = C.CustomerId
	inner join Items as I
		on I.ItemId = O.ItemId
	where O.Progress = @prog
end

go

create or alter proc SearchOrderByCustomerName
	@NameChecker varchar(40)
as
begin
	select O.OrderId, C.FirstName, C.LastName, I.Type, I.Color, I.Size, O.Quantity, O.OrderDate,
	O.DeliveryDate, O.DeliveryLocation, O.Status, O.Progress, O.Paid
	from Orders as O
	inner join Customers as C
		on O.CustomerId = C.CustomerId
	inner join Items as I
		on I.ItemId = O.ItemId
	where C.FirstName like '%' + @NameChecker + '%' or C.LastName like '%' + @NameChecker + '%'
end

go

create or alter proc SearchOrdersByItemType
	@Type varchar(30)
as
begin
	select O.OrderId, C.FirstName, C.LastName, I.Type, I.Color, I.Size, O.Quantity, O.OrderDate,
	O.DeliveryDate, O.DeliveryLocation, O.Status, O.Progress, O.Paid
	from Orders as O
	inner join Customers as C
		on O.CustomerId = C.CustomerId
	inner join Items as I
		on I.ItemId = O.ItemId
	where I.Type like '%' + @Type + '%'
end



-- ============================ COMMISSIONS MANIPULATION ============================

go

create or alter proc GetAllCommissions
as
begin
	select Co.ComId as [Commission ID], O.OrderId as [Order ID], I.Name + ' to ' + C.FirstName + ' ' + C.LastName as [Order], E.EmployeeId, 
		E.FirstName + ' ' + E.LastName as [Employee]
	from Commissions as Co
	inner join Orders as O
		on O.OrderId = Co.OrderId
	inner join Items as I
		on O.ItemId = I.ItemId
	inner join Customers as C
		on C.CustomerId = O.CustomerId
	inner join Employees as E
		on E.EmployeeId = Co.EmployeeId
end

go

create or alter proc SearchCommissionByOrder 
	@ItemName varchar(50)
as
begin
	select Co.ComId as [Commission ID], O.OrderId as [Order ID], I.Name + ' to ' + C.FirstName + ' ' + C.LastName as [Order], E.EmployeeId, 
		E.FirstName + ' ' + E.LastName as [Employee]
	from Commissions as Co
	inner join Orders as O
		on O.OrderId = Co.OrderId
	inner join Items as I
		on O.ItemId = I.ItemId
	inner join Customers as C
		on C.CustomerId = O.CustomerId
	inner join Employees as E
		on E.EmployeeId = Co.EmployeeId
	where I.Name like '%' + @ItemName + '%'
end

go

create or alter proc SearchCommissionByEmployee
	@EmployeeName varchar(50)
as
begin
	select Co.ComId as [Commission ID], O.OrderId as [Order ID], I.Name + ' to ' + C.FirstName + ' ' + C.LastName as [Order], E.EmployeeId, 
		E.FirstName + ' ' + E.LastName as [Employee]
	from Commissions as Co
	inner join Orders as O
		on O.OrderId = Co.OrderId
	inner join Items as I
		on O.ItemId = I.ItemId
	inner join Customers as C
		on C.CustomerId = O.CustomerId
	inner join Employees as E
		on E.EmployeeId = Co.EmployeeId
	where E.FirstName like '%' + @EmployeeName + '%' or E.LastName like '%' + @EmployeeName + '%'
end

go

create or alter proc SearchCommissionByCustomer
	@CustomerName varchar(50)
as
begin
	select Co.ComId as [Commission ID], O.OrderId as [Order ID], I.Name + ' to ' + C.FirstName + ' ' + C.LastName as [Order], E.EmployeeId, 
		E.FirstName + ' ' + E.LastName as [Employee]
	from Commissions as Co
	inner join Orders as O
		on O.OrderId = Co.OrderId
	inner join Items as I
		on O.ItemId = I.ItemId
	inner join Customers as C
		on C.CustomerId = O.CustomerId
	inner join Employees as E
		on E.EmployeeId = Co.EmployeeId
	where C.FirstName like '%' + @CustomerName + '%' or C.LastName like '%' + @CustomerName + '%'
end

go

create or alter proc FilteredOrderByStatus
	@StatusCheck varchar(10)
as
begin
	select Co.ComId as [Commission ID], O.OrderId as [Order ID], I.Name + ' to ' + C.FirstName + ' ' + C.LastName as [Order], E.EmployeeId, 
		E.FirstName + ' ' + E.LastName as [Employee]
	from Commissions as Co
	inner join Orders as O
		on O.OrderId = Co.OrderId
	inner join Items as I
		on O.ItemId = I.ItemId
	inner join Customers as C
		on C.CustomerId = O.CustomerId
	inner join Employees as E
		on E.EmployeeId = Co.EmployeeId
	where O.Status = @StatusCheck
end

go

create or alter proc FilteredOrderByProgress
	@ProgressCheck int
as
begin
	select Co.ComId as [Commission ID], O.OrderId as [Order ID], I.Name + ' to ' + C.FirstName + ' ' + C.LastName as [Order], E.EmployeeId, 
		E.FirstName + ' ' + E.LastName as [Employee]
	from Commissions as Co
	inner join Orders as O
		on O.OrderId = Co.OrderId
	inner join Items as I
		on O.ItemId = I.ItemId
	inner join Customers as C
		on C.CustomerId = O.CustomerId
	inner join Employees as E
		on E.EmployeeId = Co.EmployeeId
	where O.Progress = @ProgressCheck
end

go

create or alter proc insertCommission
	@EmployeeId int,
	@OrderId int
as
begin
	DECLARE @ComId int
    SELECT @ComId = ISNULL(MAX(ComId), 0) + 1 FROM Commissions

	IF NOT EXISTS (
        SELECT * FROM Commissions WHERE EmployeeId = @EmployeeId AND OrderId = @OrderId
    ) begin
        INSERT INTO Commissions (ComId, EmployeeId, OrderId) VALUES (@ComId, @EmployeeId, @OrderId);
    END

	--insert into Commissions values
	--(@ComId, @EmployeeId, @OrderId, @Commission)
end

go

create or alter proc updateCommission
	@ComId int,
	@EmployeeId int,
	@OrderId int
as
begin
	update Commissions
	set EmployeeId = @EmployeeId, OrderId = @OrderId
	where  ComId = @ComId
end

go

create or alter proc deleteCommission
	@ComId int
as
begin
	delete from Commissions
	where ComId = @ComId
end


-- ============================ DEMO DATA INSERTING ============================

--INSERT INTO Items (ItemId, Type, Color, Size, Quantity)
--VALUES
--  (1, 'Sweater', 'Red', 'M', 10),
--  (2, 'Scarf', 'Green', 'O/S', 5),
--  (3, 'Hat', 'Blue', 'S', 8),
--  (4, 'Gloves', 'Black', 'L', 3),
--  (5, 'Cardigan', 'Purple', 'M', 6),
--  (6, 'Beanie', 'Yellow', 'O/S', 4),
--  (7, 'Socks', 'Gray', 'L', 2);

 
--INSERT INTO Employees (EmployeeId, FirstName, LastName, PhoneNumber, YarnCount)
--VALUES
--	(1, 'John', 'Doe', '+251912345678', 50),
--	(2, 'Jane', 'Doe', '+251712345678', 100),
--	(3, 'Bob', 'Smith', '+251912345679', 0),
--	(4, 'Alice', 'Johnson', '+251712345679', 75),
--	(5, 'David', 'Brown', '+251912345680', 0),
--	(6, 'Mary', 'Davis', '+251712345680', 25),
--	(7, 'Tom', 'Wilson', '+251912345681', 150),
--	(8, 'Sara', 'Taylor', '+251712345681', 0);

	SELECT * FROM Commissions

--INSERT INTO Customers (CustomerId, FirstName, LastName, PhoneNumber)
--VALUES
--	(1, 'John', 'Doe', '+251912345678'),
--	(2, 'Jane', 'Doe', '+251712345678'),
--	(3, 'Bob', 'Smith', '+251912345679'),
--	(4, 'Alice', 'Johnson', '+251712345679'),
--	(5, 'David', 'Brown', '+251912345680'),
--	(6, 'Mary', 'Davis', '+251712345680'),
--	(7, 'Tom', 'Wilson', '+251912345681'),
--	(8, 'Sara', 'Taylor', '+251712345681');

	select * from Orders

--INSERT INTO Orders (OrderId, CustomerId, ItemId, OrderDate, DeliveryDate, DeliveryLocation, Status, Progress, Paid)
--VALUES
--	(1, 1, 1, '2022-01-01', '2022-01-05', 'Addis Ababa', 'Delivered', 100, 'Paid'),
--	(2, 2, 2, '2022-02-01', '2022-07', 'Dire Dawa', 'Finished', 100, 'Paid'),
--	(3, 3, 3, '2022-03-01', '2022-03-10', 'Bahir Dar', 'Delivered', 50, 'Paid'),
--	(4, 4, 4, '2022-04-01', '2022-04-15', 'Gonder', 'Pending', 0, 'Not Paid'),
--	(5, 5, 5, '2022-05-01', '2022-05-07', 'Hawassa', 'Finished', 100, 'Paid'),
--	(6, 6, 6, '2022-06-01', '2022-06-09', 'Jimma', 'Delivered', 25, 'Not Paid'),
--	(7, 7, 7, '2022-07-01', '2022-07-12', 'Mekelle', 'Pending', 0, 'Not Paid'),
--	(8, 8, 1, '2022-08-01', '2022-08-20', 'Adama', 'Pending', 0, 'Not Paid');

