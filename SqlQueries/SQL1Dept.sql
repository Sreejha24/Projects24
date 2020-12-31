create table Department11122020
(
DeptID INT NOT NULL Primary Key NONClustered,
DeptName nvarchar(50) not null,
EmpID int NOT NULL FOREIGN KEY REFERENCES Employees11122020(EmpID)
)
select * from Department11122020

INSERT INTO Department11122020 values(1501,'Technical',1001)
INSERT INTO Department11122020 values(1502,'HR',1002)
INSERT INTO Department11122020 values(1503,'TR',1003)
INSERT INTO Department11122020 values(1504,'IT',1004)
INSERT INTO Department11122020 values(1505,'Telecom',1005)
INSERT INTO Department11122020 values(1506,'Management',1006)
INSERT INTO Department11122020 values(1507,'Database',1008)
