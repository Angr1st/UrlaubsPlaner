namespace UrlaubsPlaner.FSharp

module Common_Logic =
    let ChangeButtonText visible = if visible then "Erstellen" else "Aktualisieren"
    
    let UpcastToObj cast x = cast x :> obj