CREATE TABLE Employee11122020
(
EmpID INT NOT NULL Primary Key NONClustered,
EmpName nvarchar(50) NOT NULL,
salary money ,
Timing time(7) not null,
LoginId nchar(50),
DataCheck text ,
Dateoftheday date not null,
AutoId int Identity(1,1) not null
)