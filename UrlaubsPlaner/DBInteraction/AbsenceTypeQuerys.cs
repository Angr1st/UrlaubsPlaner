using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public static class AbsenceTypeQuerys
    {
        public static readonly string GETABSENCETYPES = @"SELECT [AbsenceTypeID]
      ,[Label]
  FROM [dbo].[AbsenceType]";

        public static readonly string INSERTABSENCETYPES =
            @"INSERT INTO [dbo].[AbsenceType]
           ([AbsenceTypeID]
           ,[Label])
     VALUES
           (@AbsenceTypeID
           ,@Label)";

        public static readonly string UPDATEABSENCETYPES =
            @"UPDATE [dbo].[AbsenceType]
               SET [Label] = @Label
             WHERE [AbsenceTypeID] = @AbsenceTypeID";
    }
}
