namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms
open System.Windows.Forms

type DataStorage_Main = 
    {
        Absences:DB.Querys.GetAbsenceView.Record seq
        AbsenceTypes:DB.Querys.GetAbsenceTypes.Record seq
        Employees:DB.Querys.GetEmployees.Record seq
    }

module Main_FormLogic =

    let MainForm = new Main_Form()

    let UpdateAllData (form:Main_Form) =
        do form.listview_event.Items.Clear()
        do form.cbx_absencetype.Items.Clear()
        do form.cbx_employee.Items.Clear()

        let absences = DB.Querys.getAbsenceView DB.DBInteraction.ConnectionString
        let absenceTypes = DB.Querys.getAbsenceTypes DB.DBInteraction.ConnectionString
        let employees = DB.Querys.getEmployees DB.DBInteraction.ConnectionString

        let newData = {Absences = absences.Execute();AbsenceTypes = absenceTypes.Execute(); Employees = employees.Execute()}

        let transformAbsenceToListViewItem (absenceRecord:DB.Querys.GetAbsenceView.Record) = 
            ListViewItem(
                [|
                    absenceRecord.AbsenceID.ToString()
                    absenceRecord.EmployeeNumber.ToString()
                    absenceRecord.Firstname
                    absenceRecord.Lastname
                    absenceRecord.Label
                    absenceRecord.FromDate.ToString()
                    absenceRecord.ToDate.ToString()
                |]
            )

        let listViewAbsenceArray = newData.Absences |> Seq.map transformAbsenceToListViewItem |> Seq.toArray

        form.listview_event.Items.AddRange listViewAbsenceArray

        let upcastToObj x = x :> obj

        let absenceArray = newData.AbsenceTypes |> Seq.map upcastToObj |> Seq.toArray

        let employeeArray = newData.Employees |> Seq.map upcastToObj |> Seq.toArray

        form.cbx_absencetype.Items.AddRange absenceArray

        form.cbx_employee.Items.AddRange employeeArray



    let registerEvents (form:Main_Form) =
        form.Load.Add(fun evenArgs -> UpdateAllData form )
        Application.Run(form)