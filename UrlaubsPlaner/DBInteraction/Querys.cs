using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public enum Querys
    {
        GetAbsences,
        GetAbsencesWhereEmployee,
        GetEmployees,
        GetCountrys,
        GetAbsenceTypes,
        GetAbsenceView,
        GetEmployeeView,
        InsertAbsence,
        UpdateAbsence,
        InsertAbsenceType,
        UpdateAbsenceType,
        InsertEmployee,
        UpdateEmployee
    }
}
