USE [sprathipati]
GO

/****** Object:  StoredProcedure [dbo].[DepartmentDetails11122020]    Script Date: 11-12-2020 13:44:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[DepartmentDetails11122020]
	-- Add the parameters for the stored procedure here
	@DeptID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DeptID, DeptName, EmpID from Department11122020 WHERE DeptID > @DeptID
END
GO


