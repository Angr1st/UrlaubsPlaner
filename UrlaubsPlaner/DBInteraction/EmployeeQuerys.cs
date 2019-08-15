using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public static class EmployeeQuerys
    {
        public static readonly string GETEMPLOYEES = @"SELECT [EmployeeID]
      ,[EmployeeNumber]
      ,[CountryID]
      ,[Firstname]
      ,[Lastname]
      ,[Birthday]
      ,[Street]
      ,[Housenumber]
      ,[Postalcode]
      ,[City]
      ,[Phonenumber]
      ,[Email]
  FROM [dbo].[Employee]";

        public static readonly string GETEMPLOYEEVIEW = @"SELECT [EmployeeID]
      ,[EmployeeNumber]
      ,[CountryID]
      ,[Code]
      ,[Name]
      ,[Firstname]
      ,[Lastname]
      ,[Birthday]
      ,[Street]
      ,[Housenumber]
      ,[Postalcode]
      ,[City]
      ,[Phonenumber]
      ,[Email]
  FROM [dbo].[EmployeesWithCountry]";

        public static readonly string INSERTEMPLOYEE =
            @"INSERT INTO [dbo].[Employee]
           ([EmployeeID]
           ,[EmployeeNumber]
           ,[CountryID]
           ,[Firstname]
           ,[Lastname]
           ,[Birthday]
           ,[Street]
           ,[Housenumber]
           ,[Postalcode]
           ,[City]
           ,[Phonenumber]
           ,[Email])
     VALUES
           (@EmployeeID
           ,@EmployeeNumber
           ,@Country
           ,@Firstname
           ,@Lastname
           ,@Birthday
           ,@Street
           ,@Housenumber
           ,@Postalcode
           ,@City
           ,@Phonenumber
           ,@Email)";

        public static readonly string UPDATEEMPLOYEE =
            @"UPDATE [dbo].[Employee]
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
             WHERE [EmployeeID] = @EmployeeID";
    }
}
