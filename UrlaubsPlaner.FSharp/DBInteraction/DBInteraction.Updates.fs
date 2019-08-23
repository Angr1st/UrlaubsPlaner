namespace UrlaubsPlaner.FSharp.DB
open FSharp.Data
open DBInteraction

module Updates =

    [<Literal>]
    let UpdatesFolder = SqlScriptsFolder + "Updates\\"

    [<Literal>]
    let UpdateAbsenceLocation = UpdatesFolder + "UpdateAbsence" + DotSQL

    [<Literal>]
    let UpdateAbsenceTypeLocation = UpdatesFolder + "UpdateAbsenceType" + DotSQL

    [<Literal>]
    let UpdateEmployeeLocation = UpdatesFolder + "UpdateEmployee" + DotSQL

    type UpdateAbsence = SqlCommandProvider<const SqlFile<UpdateAbsenceLocation>.Text,ConnectionString>

    type UpdateAbsenceType = SqlCommandProvider<const SqlFile<UpdateAbsenceTypeLocation>.Text,ConnectionString>

    type UpdateEmployee = SqlCommandProvider<const SqlFile<UpdateEmployeeLocation>.Text,ConnectionString>