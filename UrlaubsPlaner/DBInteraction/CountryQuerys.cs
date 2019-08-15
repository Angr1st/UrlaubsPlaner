using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public static class CountryQuerys
    {
        public static readonly string GETCOUNTRYS = @"SELECT [CountryID]
      ,[Name]
      ,[Code]
  FROM [dbo].[Country]";
    }
}
