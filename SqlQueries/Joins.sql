/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [DeptID]
      ,[DeptName]
      ,[EmpID]
  FROM [sprathipati].[dbo].[Department11122020]

  select Employees11122020.EmpID,Employees11122020.EmpName,
	  Employees11122020.Salary,Employees11122020.LoginId,
	  Employees11122020.Timing,Department11122020.DeptID,Department11122020.DeptName 
	  from Employees11122020  Left JOIN 
	  Department11122020 on Employees11122020.EmpID = Department11122020.EmpID;

	  
  select Employees11122020.EmpID,Employees11122020.EmpName,
	  Employees11122020.Salary,Employees11122020.LoginId,
	  Employees11122020.Timing,Department11122020.DeptID,Department11122020.DeptName 
	  from Employees11122020  INNER JOIN 
	  Department11122020 on Employees11122020.EmpID = Department11122020.EmpID;

	  
  select Employees11122020.EmpID,Employees11122020.EmpName,
	  Employees11122020.Salary,Employees11122020.LoginId,
	  Employees11122020.Timing,Department11122020.DeptID,Department11122020.DeptName 
	  from Employees11122020  Right JOIN 
	  Department11122020 on Employees11122020.EmpID = Department11122020.EmpID;
  
  select EmpName [EmpName],
	  Salary [Salary]
	  FROM Employees11122020 [Department11122020]
	  WHERE EmpID IN (select EmpID[EmpID] 
	  FROM Employees11122020 [Department11122020]
	  WHERE EmpID>1009);

 select EmpName,
	  COUNT(Salary) As NetSalary  
	  from Employees11122020 GROUP BY EmpName Having EmpName Like '%a' 


SELECT  SUM(Salary) TotalSalary, 
AVG(Salary) AverageSalary,
MIN(Salary) LowestSalary,
MAX(Salary) HighestSalary  FROM  Employees11122020

