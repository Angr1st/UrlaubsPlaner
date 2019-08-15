using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public static class AbsenceQuerys
    {
        public static readonly string GETABSENCES = @"SELECT [AbsenceID]
      ,[AbsenceTypeID]
      ,[EmployeeID]
      ,[FromDate]
      ,[ToDate]
      ,[Reason]
  FROM [dbo].[Absence]";

        public static readonly string GETABSENCESWHEREEMPLOYEE =
            GETABSENCES + @" WHERE [EmployeeID] = @EmployeeID";

        public static readonly string GETABSENCEVIEW = @"SELECT [AbsenceID]
      ,[FromDate]
      ,[ToDate]
      ,[Reason]
      ,[EmployeeID]
      ,[EmployeeNumber]
      ,[CountryID]
      ,[Name]
      ,[Code]
      ,[Firstname]
      ,[Lastname]
      ,[Birthday]
      ,[Street]
      ,[Housenumber]
      ,[Postalcode]
      ,[City]
      ,[Phonenumber]
      ,[Email]
      ,[AbsenceTypeID]
      ,[Label]
  FROM [dbo].[AbsencesWithEmployeeAndAbsenceType]";

        public static readonly string INSERTABSENCE =
            @"INSERT into [dbo].[Absence]
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
           ,@Reason)";

        public static readonly string UPDATEABSENCE =
            @"UPDATE [dbo].[Absence]
               SET [AbsenceTypeID] = @AbsenceType
                  ,[EmployeeID] = @Employee
                  ,[FromDate] = @FromDate
                  ,[ToDate] = @ToDate
                  ,[Reason] = @Reason
             WHERE [AbsenceID] = @AbsenceID";
    }
}