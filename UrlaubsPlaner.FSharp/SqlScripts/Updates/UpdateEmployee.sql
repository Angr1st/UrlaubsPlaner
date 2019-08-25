UPDATE [dbo].[Employee]
               SET [EmployeeNumber] = @EmployeeNumber
                  ,[CountryID] = @Country
                  ,[Firstname] = @Firstname
                  ,[Lastname] = @Lastname
                  ,[Birthday] = @Birthday
                  ,[Street] = @Street
                  ,[Housenumber] = @Housenumber
                  ,[Postalcode] = @Postalcode
                  ,[City] = @City
                  ,[Phonenumber] = @Phonenumber
                  ,[Email] = @Email
             WHERE [EmployeeID] = @EmployeeID