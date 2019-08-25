SELECT [AbsenceID]
      ,[AbsenceTypeID]
      ,[EmployeeID]
      ,[FromDate]
      ,[ToDate]
      ,[Reason]
  FROM [dbo].[Absence]
  WHERE [EmployeeID] = @EmployeeID