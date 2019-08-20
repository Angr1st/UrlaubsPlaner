namespace UrlaubsPlaner.FSharp.DBInteraction

open FSharp.Data

module Inserts =

    [<Literal>]
    let InsertsFolder = SqlScriptsFolder + "Inserts\\"

    [<Literal>]
    let InsertAbsenceLocation = InsertsFolder + "InsertAbsence" + DotSQL

    [<Literal>]
    let InsertAbsenceTypeLocation = InsertsFolder + "InsertAbsenceType" + DotSQL

    [<Literal>]
    let InsertEmployeeLocation = InsertsFolder + "InsertEmployee" + DotSQL

    type InsertAbsence = SqlCommandProvider<const SqlFile<InsertAbsenceLocation>.Text,ConnectionString>

    type InsertAbsenceType = SqlCommandProvider<const SqlFile<InsertAbsenceTypeLocation>.Text,ConnectionString>

    type InsertEmployee = SqlCommandProvider<const SqlFile<InsertEmployeeLocation>.Text,ConnectionString>