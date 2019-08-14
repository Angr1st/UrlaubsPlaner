﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner.DBInteraction
{
    public static class DataBaseConnection
    {
        private static readonly string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=UrlaubsPlanerDB;Trusted_Connection=True;";

        private static SqlConnection SqlConnection = new SqlConnection(ConnectionString);

        private static bool IsConnectionOpen
        {
            get
            {
                return SqlConnection.State == System.Data.ConnectionState.Open
                    || SqlConnection.State == System.Data.ConnectionState.Connecting;
            }
        }

        public static List<Absence> GetAbsences()
        {
            return GetValuesSynchronously(GetAbsenceAsync);
        }

        public static async Task<List<Absence>> GetAbsenceAsync()
        {
            return await QueryData(GetSqlCommand(Querys.GetAbsences), EntityTransformations.TransformAbsence);
        }

        public static List<Absence> GetFullAbsences()
        {
            return GetValuesSynchronously(GetFullAbsencesAsync);
        }

        public static async Task<List<Absence>> GetFullAbsencesAsync()
        {
            return await QueryDataAsync(GetSqlCommand(Querys.GetAbsenceView), EntityTransformations.TransformAbsenceView);
        }

        public static List<AbsenceType> GetAbsenceTypes()
        {
            return GetValuesSynchronously(GetAbsenceTypesAsync);
        }

        public static async Task<List<AbsenceType>> GetAbsenceTypesAsync()
        {
            return await QueryData(GetSqlCommand(Querys.GetAbsenceTypes), EntityTransformations.TransformAbsenceType);
        }

        public static List<Country> GetCountries()
        {
            return GetValuesSynchronously(GetCountriesAsync);
        }

        public static async Task<List<Country>> GetCountriesAsync()
        {
            return await QueryData(GetSqlCommand(Querys.GetCountrys), EntityTransformations.TransformCountry);
        }

        public static List<Employee> GetEmployees()
        {
            return GetValuesSynchronously(GetEmployeesAsync);
        }

        public static async Task<List<Employee>> GetEmployeesAsync()
        {
            return await QueryDataAsync(GetSqlCommand(Querys.GetEmployees), EntityTransformations.TransformEmployee);
        }

        public static List<Employee> GetFullEmployees()
        {
            return GetValuesSynchronously(GetFullEmployeesAsync);
        }

        public static async Task<List<Employee>> GetFullEmployeesAsync()
        {
            return await QueryDataAsync(GetSqlCommand(Querys.GetEmployeeView), EntityTransformations.TransformEmployeeView);
        }

        private static List<T> GetValuesSynchronously<T>(Func<Task<List<T>>> func)
            where T : IEntity
        {
            var task = Task.Run(async () => await func());
            task.Wait();
            return task.Result;
        }

        private static SqlCommand GetSqlCommand(Querys query)
        {
            switch (query)
            {
                case Querys.GetAbsences:
                    return new SqlCommand(AbsenceQuerys.GETABSENCES);

                case Querys.GetAbsencesWhereEmployee:
                    return new SqlCommand(AbsenceQuerys.GETABSENCESWHEREEMPLOYEE);

                case Querys.GetEmployees:
                    return new SqlCommand(EmployeeQuerys.GETEMPLOYEES);

                case Querys.GetCountrys:
                    return new SqlCommand(CountryQuerys.GETCOUNTRYS);

                case Querys.GetAbsenceTypes:
                    return new SqlCommand(AbsenceTypeQuerys.GETABSENCETYPES);

                case Querys.GetAbsenceView:
                    return new SqlCommand(AbsenceQuerys.GETABSENCEVIEW);

                case Querys.GetEmployeeView:
                    return new SqlCommand(EmployeeQuerys.GETEMPLOYEEVIEW);

                case Querys.InsertAbsence:
                    return new SqlCommand(AbsenceQuerys.INSERTABSENCE);

                case Querys.UpdateAbsence:
                    return new SqlCommand(AbsenceQuerys.UPDATEABSENCE);

                case Querys.InsertAbsenceType:
                    return new SqlCommand(AbsenceTypeQuerys.INSERTABSENCETYPES);

                case Querys.UpdateAbsenceType:
                    return new SqlCommand(AbsenceTypeQuerys.UPDATEABSENCETYPES);

                case Querys.InsertEmployee:
                    return new SqlCommand(EmployeeQuerys.INSERTEMPLOYEE);

                case Querys.UpdateEmployee:
                    return new SqlCommand(EmployeeQuerys.UPDATEEMPLOYEE);

                default:
                    throw new NotImplementedException($"This enum value is not implemented! {query}");
            }
        }

        private static async Task<List<T>> QueryData<T>(SqlCommand sqlCommand, Func<SqlDataReader, T> transformData)
            where T : IEntity
        {
            var resultList = new List<T>();
            sqlCommand.Connection = SqlConnection;
            if (!IsConnectionOpen)
            {
                SqlConnection.Open();
            }
            using (var dataReader = await sqlCommand.ExecuteReaderAsync())
            {

                if (dataReader.HasRows)
                {
                    while (await dataReader.ReadAsync())
                    {
                        resultList.Add(transformData(dataReader));
                    }
                }
            }
            return resultList;
        }

        private static async Task<List<T>> QueryDataAsync<T>(SqlCommand sqlCommand, Func<SqlDataReader, Task<T>> transformData)
            where T : IEntity
        {
            var resultList = new List<T>();
            sqlCommand.Connection = SqlConnection;
            if (!IsConnectionOpen)
            {
                SqlConnection.Open();
            }
            using (var dataReader = await sqlCommand.ExecuteReaderAsync())
            {

                if (dataReader.HasRows)
                {
                    while (await dataReader.ReadAsync())
                    {
                        resultList.Add(await transformData(dataReader));
                    }
                }
            }

            return resultList;
        }
    }
}