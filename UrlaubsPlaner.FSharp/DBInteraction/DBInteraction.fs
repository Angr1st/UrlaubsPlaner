namespace UrlaubsPlaner.FSharp

open FSharp.Data

module DBInteraction =
    [<Literal>]
    let ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UrlaubsplanerDB;Integrated Security=True;"

    type Sql = SqlCommandProvider<,ConnectionString
