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

    type AbsenceType_Representation = {AbsenceType:GetAbsenceTypes.Record} with
        override this.ToString() =
            this.AbsenceType.Label

    type GetCountrys = SqlCommandProvider<const SqlFile<GetCountrysLocation>.Text,ConnectionString>

    type Country_Representation = {Country:GetCountrys.Record} with
        override this.ToString() =
            sprintf "%s - %s" this.Country.Name this.Country.Code

    type GetEmployees = SqlCommandProvider<const SqlFile<GetEmployeesLocation>.Text,ConnectionString>

    type Employee_Representation ={Employee:GetEmployees.Record} with
        override this.ToString() =
            sprintf "%i - %s" this.Employee.EmployeeNumber this.Employee.Lastname

    type GetEmployeeView = SqlCommandProvider<const SqlFile<GetEmployeeViewLocation>.Text,ConnectionString>

    let getAbsences (connectionString:string) = new GetAbsences(connectionString)

    let getAbsenceView (connectionString:string) = new GetAbsenceView(connectionString)

    let getAbsenceTypes (connectionString:string) = new GetAbsenceTypes(connectionString)

    let getCountrys (connectionString:string) = new GetCountrys(connectionString)

    let getEmployees (connectionString:string) = new GetEmployees(connectionString)

    let getEmployeeView (connectionString:string) = new GetEmployeeView(connectionString)