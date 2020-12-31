USE [sprathipati]
GO

/****** Object:  StoredProcedure [dbo].[InsertEmployeeDetails11122020AndDepartment11122020]    Script Date: 11-12-2020 13:45:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsertEmployeeDetails11122020AndDepartment11122020]
	-- Add the parameters for the stored procedure here
	@EmpName nvarchar(50),
	@salary money,
	@Timing time(7),
	@Dateoftheday date,
	@EmpID int,
	@DeptID int,
	@DeptName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRAN 
		BEGIN TRY 
			INSERT INTO Employees11122020(EmpName,salary,Timing,Dateoftheday,EmpID) VALUES (@EmpName,@salary,@Timing,@Dateoftheday,@EmpID)
			DECLARE @ID int SET @ID =  SCOPE_IDENTITY() 
			 INSERT INTO Department11122020(DeptID, DeptName, EmpID)     VALUES     (@DeptID, @DeptName, @EmpID) 
	  COMMIT TRANSACTION   
	END TRY 
	BEGIN CATCH
		ROLLBACK TRANSACTION  
	END CATCH 
    -- Insert statements for procedure here
	--SELECT EmpName,salary,Timing,Dateoftheday,EmpID from Employees11122020 WHERE EmpID > @EmpID
	--SELECT DeptID,DeptName,EmpID from Department11122020 WHERE EmpID > @EmpID
END
GO


