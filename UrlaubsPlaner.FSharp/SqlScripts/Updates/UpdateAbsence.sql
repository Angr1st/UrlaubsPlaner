UPDATE [dbo].[Absence]
               SET [AbsenceTypeID] = @AbsenceType
                  ,[EmployeeID] = @Employee
                  ,[FromDate] = @FromDate
                  ,[ToDate] = @ToDate
                  ,[Reason] = @Reason
             WHERE [AbsenceID] = @AbsenceID