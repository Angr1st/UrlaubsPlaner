INSERT into [dbo].[Absence]
           ([AbsenceID]
           ,[AbsenceTypeID]
           ,[EmployeeID]
           ,[FromDate]
           ,[ToDate]
           ,[Reason])
     VALUES
           (@AbsenceID
           ,@AbsenceType
           ,@Employee
           ,@FromDate
           ,@ToDate
           ,@Reason)