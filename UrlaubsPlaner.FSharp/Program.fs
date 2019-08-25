namespace UrlaubsPlaner.FSharp

open System
open System.Windows.Forms
// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
module Main =
    [<EntryPoint; STAThread>]
    let main argv = 
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(false)
        
        Main_FormLogic.registerEvents Main_FormLogic.MainForm
        AbsenceType_FormLogic.registerEvents AbsenceType_FormLogic.AbsenceTypeForm
        Employee_FormLogic.registerEvents Employee_FormLogic.EmployeeForm

        Application.Run(Main_FormLogic.MainForm)
        0 // return an integer exit code
