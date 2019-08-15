﻿CREATE VIEW [dbo].[EmployeesWithCountry]
	AS SELECT [EmployeeID]
      ,[EmployeeNumber]
      ,e.[CountryID]
	  ,c.[Code]
	  ,c.[Name]
      ,[Firstname]
      ,[Lastname]
      ,[Birthday]
      ,[Street]
      ,[Housenumber]
      ,[Postalcode]
      ,[City]
      ,[Phonenumber]
      ,[Email]
  FROM [dbo].[Employee] as e
  join [dbo].[Country] as c on e.[CountryID] = c.[CountryID]
