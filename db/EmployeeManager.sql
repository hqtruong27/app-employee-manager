Create database EmployeeManager
go

use EmployeeManager
go

Create table Admin(
	Id int identity primary key,
	UserName varchar(50),
	Checkpasswordagain varchar(50),
	Passwords varchar(50),
	FullName nvarchar(200),
	GroupName bit default 0,
	Status bit default(0),
)
go

Create table Department(
	DepartmentId int identity Primary key,
	DepartmentName nvarchar(200),
	Status bit default (0)
)
go

Create table Position(
	PositionId int identity primary key,
	PositionName nvarchar(200),
	Status bit default (0)
)
go

Create table Employee(
	EmployeeId int identity primary key,
	EmployeeName nvarchar(200),
	Email nvarchar(200),
	Phone nvarchar(100),
	[Address] nvarchar(100),
	BirthDay datetime,
	/* số chứng minh nhân dân */
	identitycardnumber nvarchar(200),
	Gender bit,
	PositionId int references Position(PositionId),
	DepartmentId int references Department(DepartmentId),
	Status bit default(0)
)
go

Create table Salary(
	SalaryId int identity primary key,
	Position int references Position(PositionId),
	BasicSalary float
)
