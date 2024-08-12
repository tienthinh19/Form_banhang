USE Master
GO
create database LoveStore2
GO
USE LoveStore2
GO
create table Account(
	Id [int] identity primary key,
	Email [varchar](50) NOT NULL,
	FullName [nvarchar](50) NOT NULL,
	RoleId [char](2) NOT NULL,
	Password [char](64) NOT NULL
)
GO
create table Employee
(
	Id int identity primary key,
	Position nvarchar(50),
	AccountId int references Account(Id),
	FullName [nvarchar](50) NOT NULL,
	DiaChi [nvarchar](50) NOT NULL,
	DateofBirth date ,
	[Picture] [varbinary] (MAX) 
)
go
create table Customer
(
	Id int identity primary key,
	FullName nvarchar(50)
)
go

CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL primary key,
	[Date] [datetime] NOT NULL,
	[Status] [varchar](30) NULL,
	[EmployeeId] [int] NOT NULL references Employee(Id)
)
GO
CREATE TABLE [dbo].Category(
	[Id] [int] IDENTITY(1,1) NOT NULL primary key,
	Name [varchar](50) NOT NULL,
	[Picture] [varbinary] (MAX) 
)
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL primary key,
	[Description] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[CategoryId] [int] NOT NULL references Category(Id),
	[Picture] [varbinary] (MAX) 
)
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL primary key,
	[OrderId] [int] NOT NULL references [Order](Id),
	[ProductId] [int] NOT NULL references [Product](Id),
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Discount] [float] NOT NULL
)
GO
insert into Account values
('admin@gmail.com','David Smith','AM','1'),
('user@gmail.com', 'Thinh', 'US', '1'),
('user2@gmail.com', 'Thinh2', 'US', '1'),
('user3@gmail.com', 'Thinh3', 'US', '1'),
('user4@gmail.com', 'Thinh4', 'US', '1')


--INSERT INTO [dbo].[Order] ([Date], [Status], [CustomerId], [EmployeeId])
--VALUES (GETDATE(), 'example', 2, 1);  -- CustomerId và EmployeeId là ID từ các bảng tương ứng



GO
INSERT INTO Employee (Position, AccountId, FullName, DiaChi, DateofBirth, Picture)
SELECT 
    'Position1',  
    1,            
    'Full Name 1',
    'Address 1',  
    '1990-01-01', 
    BulkColumn
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\New folder\0a16c0e9-7123-4bd9-a1e2-36aab2190393.jpg', SINGLE_BLOB) AS img;

INSERT INTO Employee (Position, AccountId, FullName, DiaChi, DateofBirth, Picture)
SELECT 
    'Position2',  -- Thay thế bằng vị trí thực tế
    2,            -- Thay thế bằng AccountId thực tế
    'Full Name 2',-- Thay thế bằng tên đầy đủ thực tế
    'Address 2',  -- Thay thế bằng địa chỉ thực tế
    '1991-02-02', -- Thay thế bằng ngày sinh thực tế
    BulkColumn
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\New folder\0fbac511ddccc3ffdc7abaa01a40db08.jpg', SINGLE_BLOB) AS img;

INSERT INTO Employee (Position, AccountId, FullName, DiaChi, DateofBirth, Picture)
SELECT 
    'Position3',  -- Thay thế bằng vị trí thực tế
    3,            -- Thay thế bằng AccountId thực tế
    'Full Name 3',-- Thay thế bằng tên đầy đủ thực tế
    'Address 3',  -- Thay thế bằng địa chỉ thực tế
    '1992-03-03', -- Thay thế bằng ngày sinh thực tế
    BulkColumn
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\New folder\4f1b761e99684b4b16015af01396f00d.jpg', SINGLE_BLOB) AS img;

INSERT INTO Employee (Position, AccountId, FullName, DiaChi, DateofBirth, Picture)
SELECT 
    'Position4',  -- Thay thế bằng vị trí thực tế
    4,            -- Thay thế bằng AccountId thực tế
    'Full Name 4',-- Thay thế bằng tên đầy đủ thực tế
    'Address 4',  -- Thay thế bằng địa chỉ thực tế
    '1993-04-04', -- Thay thế bằng ngày sinh thực tế
    BulkColumn
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\New folder\435000928_825156832985441_692707697083143427_n.jpg', SINGLE_BLOB) AS img;

INSERT INTO Employee (Position, AccountId, FullName, DiaChi, DateofBirth, Picture)
SELECT 
    'Position5',  -- Thay thế bằng vị trí thực tế
    5,            -- Thay thế bằng AccountId thực tế
    'Full Name 5',-- Thay thế bằng tên đầy đủ thực tế
    'Address 5',  -- Thay thế bằng địa chỉ thực tế
    '1994-05-05', -- Thay thế bằng ngày sinh thực tế
    BulkColumn
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\New folder\740d668618c011650fdc301edf08c0f3.jpg', SINGLE_BLOB) AS img;

SET IDENTITY_INSERT [dbo].[Category] ON 
-- Insert a ring category with an image
INSERT INTO [dbo].[Category] (Name, Picture)
SELECT 'Ring', BulkColumn FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\nhan9.png', SINGLE_BLOB) AS img;

-- Insert a bracelet category with an image
INSERT INTO [dbo].[Category] (Name, Picture)
SELECT 'Bracelet', BulkColumn FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\lactay7.png', SINGLE_BLOB) AS img;

-- Insert an earring category with an image
INSERT INTO [dbo].[Category] (Name, Picture)
SELECT 'Earring', BulkColumn FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\bongtai1.png', SINGLE_BLOB) AS img;

-- Insert a necklace category with an image
INSERT INTO [dbo].[Category] (Name, Picture)
SELECT 'Necklace', BulkColumn FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\vongco6.png', SINGLE_BLOB) AS img;

SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Product] OFF
-- Insert products with images



INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT N'14K White Gold Diamond Ring', 73.94, 0.05, 1, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\nhan2.png', SINGLE_BLOB) AS img;

INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT N'Silver Ring with stones', 74.11, 0.05, 1, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\nhan3.png', SINGLE_BLOB) AS img;



INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT N'White Gold Diamond Bracelet', 20.31, 0.05, 2, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\lactay2.png', SINGLE_BLOB) AS img;

INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT N'10K Gold bracelet with synthetic stones', 96.47, 0.15, 2, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\lactay3.png', SINGLE_BLOB) AS img;



INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT  N'Rose Dior Couture Earrings', 165.89, 0.05, 3, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\bongtai2.png', SINGLE_BLOB) AS img;

INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT  N'Rose des Vents Single Earring', 80.16, 0.05, 3, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\bongtai3.png', SINGLE_BLOB) AS img;

INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT  N'18K Gold pendant with CZ stone', 35.08, 0.05, 4, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\vongco9.png', SINGLE_BLOB) AS img;

INSERT INTO [dbo].[Product] (Description, Price, Discount, CategoryId, Picture)
SELECT  N'10K White Gold pendant with ECZ stone', 57.92, 0.05, 4, BulkColumn 
FROM OPENROWSET(BULK N'C:\Users\Administrator\OneDrive\Pictures\Camera Roll\data\vongco9.png', SINGLE_BLOB) AS img;




SET IDENTITY_INSERT [dbo].[Product] OFF
GO
raiserror('The LoveStore database in now ready for use....',0,1)