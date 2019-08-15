using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner.DBInteraction
{
    public static class UpsertCommandSetups
    {
        public static SqlCommand SetupAbsenceTypeCommand(SqlCommand sqlCommand, AbsenceType absenceType)
        {
            sqlCommand.Parameters.AddWithValue(nameof(absenceType.AbsenceTypeId), absenceType.AbsenceTypeId);
            sqlCommand.Parameters.AddWithValue(nameof(absenceType.Label), absenceType.Label);
            return sqlCommand;
        }

        public static SqlCommand SetupAbsenceCommand(SqlCommand sqlCommand, Absence absence)
        {
            sqlCommand.Parameters.AddWithValue(nameof(absence.AbsenceID), absence.AbsenceID);
            sqlCommand.Parameters.AddWithValue(nameof(absence.AbsenceType), absence.AbsenceType.AbsenceTypeId);
            sqlCommand.Parameters.AddWithValue(nameof(absence.Employee), absence.Employee.EmployeeId);
            sqlCommand.Parameters.AddWithValue(nameof(absence.FromDate), absence.FromDate);
            sqlCommand.Parameters.AddWithValue(nameof(absence.Reason), absence.Reason);
            sqlCommand.Parameters.AddWithValue(nameof(absence.ToDate), absence.ToDate);
            return sqlCommand;
        }

        public static SqlCommand SetupEmployeeCommand(SqlCommand sqlCommand, Employee employee)
        {
            sqlCommand.Parameters.AddWithValue(nameof(employee.EmployeeId), employee.EmployeeId);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Country), employee.Country.CountryId);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Firstname), employee.Firstname);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Lastname), employee.Lastname);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Birthday), employee.Birthday);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Street), employee.Street);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Housenumber), employee.Housenumber);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Postalcode), employee.Postalcode);
            sqlCommand.Parameters.AddWithValue(nameof(employee.City), employee.City);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Phonenumber), employee.Phonenumber);
            sqlCommand.Parameters.AddWithValue(nameof(employee.Email), employee.Email);
            sqlCommand.Parameters.AddWithValue(nameof(employee.EmployeeNumber), employee.EmployeeNumber);
            return sqlCommand;
        }
    }
}
