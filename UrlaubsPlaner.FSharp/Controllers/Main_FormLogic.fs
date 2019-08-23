namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms
open System.Windows.Forms

module Main_FormLogic =

    let MainForm = new Main_Form()

    let registerEvents (form:Main_Form) =
        form.Load.Add(fun evenArgs -> System.Console.Beep())
        Application.Run(form)