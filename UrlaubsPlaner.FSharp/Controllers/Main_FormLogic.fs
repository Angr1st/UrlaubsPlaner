namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms

module Main_FormLogic =

    let MainForm = new Main_Form()



    let registerEvents (form:Main_Form) =
        form.Load.Add(fun evenArgs -> System.Console.Beep())