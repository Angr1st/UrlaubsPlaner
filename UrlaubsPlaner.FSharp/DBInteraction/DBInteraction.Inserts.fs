namespace UrlaubsPlaner.FSharp.DB
open FSharp.Data
open DBInteraction

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

    let insertAbsence (connectionString:string) = new InsertAbsence(connectionString)

    let insertAbsenceType (connectionString:string) = new InsertAbsenceType(connectionString)

    let insertEmployee (connectionString:string) = new InsertEmployee(connectionString)