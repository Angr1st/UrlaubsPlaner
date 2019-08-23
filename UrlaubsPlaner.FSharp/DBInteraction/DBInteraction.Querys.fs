namespace UrlaubsPlaner.FSharp.DB
open FSharp.Data
open DBInteraction

module Querys =
    [<Literal>]
    let QueryFolder = SqlScriptsFolder + "Querys\\"

    [<Literal>]
    let GetAbsencesLocation = QueryFolder + "GetAbsences" + DotSQL

    [<Literal>]
    let GetAbsenceViewLocation = QueryFolder + "GetAbsenceView" + DotSQL

    [<Literal>]
    let GetAbsenceTypesLocation = QueryFolder + "GetAbsenceTypes" + DotSQL

    [<Literal>]
    let GetCountrysLocation = QueryFolder + "GetCountrys" + DotSQL

    [<Literal>]
    let GetEmployeesLocation = QueryFolder + "GetEmployees" + DotSQL

    [<Literal>]
    let GetEmployeeViewLocation = QueryFolder + "GetEmployeeView" + DotSQL

    type GetAbsences = SqlCommandProvider<const SqlFile<GetAbsencesLocation>.Text,ConnectionString>

    type GetAbsenceView = SqlCommandProvider<const SqlFile<GetAbsenceViewLocation>.Text,ConnectionString>

    type GetAbsenceTypes = SqlCommandProvider<const SqlFile<GetAbsenceTypesLocation>.Text,ConnectionString>

    type GetCountrys = SqlCommandProvider<const SqlFile<GetCountrysLocation>.Text,ConnectionString>

    type GetEmployees = SqlCommandProvider<const SqlFile<GetEmployeesLocation>.Text,ConnectionString>

    type GetEmployeeView = SqlCommandProvider<const SqlFile<GetEmployeeViewLocation>.Text,ConnectionString>