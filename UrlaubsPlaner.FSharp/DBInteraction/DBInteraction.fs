namespace UrlaubsPlaner.FSharp

module DBInteraction =
    [<Literal>]
    let ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UrlaubsplanerDB;Integrated Security=True;"

    [<Literal>]
    let SqlScriptsFolder = "SqlScripts\\"

    [<Literal>]
    let DotSQL = ".sql"