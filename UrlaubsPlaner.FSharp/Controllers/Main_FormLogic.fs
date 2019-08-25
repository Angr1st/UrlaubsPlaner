namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms
open System.Windows.Forms

type DataStorage_Main = 
    {
        Absences:DB.Querys.GetAbsenceView.Record array
        AbsenceTypes:DB.Querys.GetAbsenceTypes.Record array
        Employees:DB.Querys.GetEmployees.Record array
    }

module Main_FormLogic =

    let mutable private IsInsert = true

    let mutable private Data = {Absences=Array.empty;AbsenceTypes=Array.empty;Employees=Array.empty}

    let MainForm = new Main_Form()

    let UpdateAllData (form:Main_Form) =
        do form.listview_event.Items.Clear()
        do form.cbx_absencetype.Items.Clear()
        do form.cbx_employee.Items.Clear()

        let absences = DB.Querys.getAbsenceView DB.DBInteraction.ConnectionString
        let absenceTypes = DB.Querys.getAbsenceTypes DB.DBInteraction.ConnectionString
        let employees = DB.Querys.getEmployees DB.DBInteraction.ConnectionString

        Data <- {Absences = absences.Execute() |> Seq.toArray;AbsenceTypes = absenceTypes.Execute() |> Seq.toArray; Employees = employees.Execute() |> Seq.toArray}

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

        let listViewAbsenceArray = Data.Absences |> Array.map transformAbsenceToListViewItem

        form.listview_event.Items.AddRange listViewAbsenceArray

        let upcastToObj x = x :> obj

        let absenceArray = Data.AbsenceTypes |> Array.map upcastToObj

        let employeeArray = Data.Employees |> Array.map upcastToObj

        form.cbx_absencetype.Items.AddRange absenceArray

        form.cbx_employee.Items.AddRange employeeArray

    let ShowFormAgain (form:Main_Form) =
        match form.Visible with
        | true -> form.Hide()
        | false -> 
            do UpdateAllData form
            form.Show()

    let StopProgram (form:'a:>Form) = form.Close() 

    let ToggleInsertOrUpdate (form:Main_Form) visible =
        IsInsert <- not visible

        form.txtbx_id.Visible <- visible
        form.lbl_id.Visible <- visible
        form.btn_clear.Visible <- visible

        match visible with
        | true -> ()
        | false ->
            form.txtbx_id.Text <- System.String.Empty
            form.cbx_employee.SelectedItem <- null
            form.cbx_employee.Text <- System.String.Empty

            form.textbox_firstname.Text <- System.String.Empty
            form.textbox_lastname.Text <- System.String.Empty

            form.cbx_absencetype.SelectedItem <- null
            form.cbx_absencetype.Text <- System.String.Empty
            form.richtextbox_reason.Text <- System.String.Empty
            form.dtp_from.Value <- System.DateTime.Now
            form.dtp_to.Value <- System.DateTime.Now
            form.listview_event.SelectedItems.Clear()

    let ListViewEventIndexChange (form:Main_Form) =
        match form.listview_event.SelectedIndices.Count = 1 with
        | false -> ()
        | true ->
            let index = form.listview_event.SelectedIndices.[0]

            let selectedItem = Data.Absences.[index]

            form.txtbx_id.Text <- selectedItem.AbsenceID.ToString()
            form.cbx_employee.SelectedItem <- Data.Employees |> Array.find (fun x -> x.EmployeeID = selectedItem.EmployeeID)
            form.cbx_absencetype.SelectedItem <- Data.AbsenceTypes |> Array.find (fun x -> x.AbsenceTypeID = selectedItem.AbsenceTypeID)
            form.dtp_from.Value <- selectedItem.FromDate
            form.dtp_to.Value <- selectedItem.ToDate

            ToggleInsertOrUpdate form true


    let registerEvents (form:Main_Form) =
        form.Load.Add(fun evenArgs -> UpdateAllData form )
        form.button_cancel.Click.Add(fun evenArgs -> StopProgram form)
        form.btn_clear.Click.Add(fun evenArgs -> ToggleInsertOrUpdate form false)
        form.listview_event.SelectedIndexChanged.Add(fun evenArgs -> ListViewEventIndexChange form)
        Application.Run(form)