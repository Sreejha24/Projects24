USE [sprathipati]
GO

/****** Object:  StoredProcedure [dbo].[EmployeeDetails11122020]    Script Date: 11-12-2020 13:17:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[EmployeeDetails11122020]
	-- Add the parameters for the stored procedure here
	@EmpID int

AS
BEGIN
	
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	SELECT EmpName,salary,Timing,Dateoftheday,EmpID from Employees11122020 WHERE EmpID > @EmpID
END
GO



 