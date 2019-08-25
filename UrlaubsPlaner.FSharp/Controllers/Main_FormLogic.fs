namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms
open System.Windows.Forms
open DB.Querys

module Main_FormLogic =

    type DataStorage_Main = 
        {
            Absences:DB.Querys.GetAbsenceView.Record array
            AbsenceTypes:DB.Querys.GetAbsenceTypes.Record array
            Employees:DB.Querys.GetEmployees.Record array
        }

    let mutable private IsInsert = true

    let mutable private Data = {Absences=Array.empty;AbsenceTypes=Array.empty;Employees=Array.empty}

    let MainForm = new Main_Form()

    let toAbsenceTypeRepr x = {AbsenceType=x}

    let toEmployeeRepr x = {Employee=x}

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

        let upcastToObj cast x = cast x :> obj

        let absenceArray = Data.AbsenceTypes |> Array.map (upcastToObj toAbsenceTypeRepr)

        let employeeArray = Data.Employees |> Array.map (upcastToObj toEmployeeRepr)

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
            form.cbx_employee.SelectedItem <- Data.Employees |> Array.find (fun x -> x.EmployeeID = selectedItem.EmployeeID) |> toEmployeeRepr
            form.cbx_absencetype.SelectedItem <- Data.AbsenceTypes |> Array.find (fun x -> x.AbsenceTypeID = selectedItem.AbsenceTypeID) |> toAbsenceTypeRepr
            form.dtp_from.Value <- selectedItem.FromDate
            form.dtp_to.Value <- selectedItem.ToDate
            form.richtextbox_reason.Text <- selectedItem.Reason

            ToggleInsertOrUpdate form true

    let showForm (form:Main_Form) eventArgs = ShowFormAgain form

    let stopProgram (form:Main_Form) eventArgs = StopProgram form

    let cbxAsEmployeeRepr (box:ComboBox) =
        if (box.SelectedItem :? Employee_Representation) then box.SelectedItem :?> Employee_Representation
        else failwith "This Combobox should only contain Employee_Representation Objects!"

    let cbxAsAbsenceTypeRepr (box:ComboBox) =
        if (box.SelectedItem :? AbsenceType_Representation) then box.SelectedItem :?> AbsenceType_Representation
        else failwith "This Combobox should only contain AbsenceType_Representation Objects!"

    let CbxEmployeeSelectedValueChanged (form:Main_Form) =
        match isNull form.cbx_employee.SelectedItem with
        | true -> 
            form.textbox_firstname.Text <- System.String.Empty
            form.textbox_lastname.Text <- System.String.Empty
        | false ->
            let employee = cbxAsEmployeeRepr form.cbx_employee
            form.textbox_firstname.Text <- employee.Employee.Firstname
            form.textbox_lastname.Text <- employee.Employee.Lastname

    let UpsertAbsence (form:Main_Form) =
        let absenceTypeId = (cbxAsAbsenceTypeRepr form.cbx_absencetype).AbsenceType.AbsenceTypeID
        let employeeId = (cbxAsEmployeeRepr form.cbx_employee).Employee.EmployeeID

        let result =
            match IsInsert with
            | true ->
                let insertAbsence = DB.Inserts.insertAbsence DB.DBInteraction.ConnectionString
                insertAbsence.Execute(System.Guid.NewGuid(), absenceTypeId, employeeId, form.dtp_from.Value, form.dtp_to.Value, form.richtextbox_reason.Text)
            | false ->
                let updateAbsence = DB.Updates.updateAbsence DB.DBInteraction.ConnectionString
                updateAbsence.Execute(absenceTypeId,employeeId,form.dtp_from.Value,form.dtp_to.Value,form.richtextbox_reason.Text,System.Guid.Parse(form.txtbx_id.Text))
        UpdateAllData form

    let registerEvents (form:Main_Form) =
        form.Load.Add(fun evenArgs -> UpdateAllData form )
        form.listview_event.SelectedIndexChanged.Add(fun evenArgs -> ListViewEventIndexChange form)
        form.btn_clear.Click.Add(fun evenArgs -> ToggleInsertOrUpdate form false)
        form.cbx_employee.SelectedValueChanged.Add(fun evenArgs -> CbxEmployeeSelectedValueChanged form)
        form.employeebtn.Click.Add(fun evenArgs -> Employee_FormLogic.EmployeeForm.Show())
        form.absenceTypebtn.Click.Add(fun evenArgs -> AbsenceType_FormLogic.AbsenceTypeForm.Show())
        form.button_cancel.Click.Add(fun evenArgs -> StopProgram form)
        form.button_save.Click.Add(fun evenArgs -> UpsertAbsence form)

        let showFormAppl = showForm form

        AbsenceType_FormLogic.AbsenceTypeForm.VisibleChanged.Add showFormAppl
        Employee_FormLogic.EmployeeForm.VisibleChanged.Add showFormAppl
        
        let stopProgramAppl = stopProgram form

        AbsenceType_FormLogic.AbsenceTypeForm.FormClosed.Add stopProgramAppl
        Employee_FormLogic.EmployeeForm.FormClosed.Add stopProgramAppl

        AbsenceType_FormLogic.registerEvents AbsenceType_FormLogic.AbsenceTypeForm

        Application.Run(form)