namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms

module AbsenceType_FormLogic =

    type DataStorage_AbsenceType = 
        {
            AbsenceTypes:DB.Querys.GetAbsenceTypes.Record array
        }
    
    let mutable private IsInsert = true

    let mutable private Data = {AbsenceTypes=Array.empty}

    let AbsenceTypeForm = new AbsenceType_Form()

    let UpdateData (form:AbsenceType_Form) =
        do form.absenceTypeListView.Items.Clear()

        let absenceTypes = DB.Querys.getAbsenceTypes DB.DBInteraction.ConnectionString

        Data <- {AbsenceTypes= absenceTypes.Execute() |> Seq.toArray}

        let transformAbsenceTypeToListViewItem (absenceTypeRecord:DB.Querys.GetAbsenceTypes.Record) =
            System.Windows.Forms.ListViewItem(
                [|
                    absenceTypeRecord.AbsenceTypeID.ToString()
                    absenceTypeRecord.Label
                |]
            )

        let listViewAbsenceTypeArray = Data.AbsenceTypes |> Array.map transformAbsenceTypeToListViewItem

        form.absenceTypeListView.Items.AddRange listViewAbsenceTypeArray

    let ToggleInsertOrUpdate (form:AbsenceType_Form) visible =
        IsInsert <- not visible

        form.txbx_id.Visible <- visible
        form.lb_Id.Visible <- visible
        form.btn_clear.Visible <- visible

        form.createButton.Text <- Common_Logic.ChangeButtonText <| not visible

        match not IsInsert with
        | true -> ()
        | false ->
            form.txbx_id.Text <- System.String.Empty
            form.absenceType_Label.Text <- System.String.Empty


    let AbsenceTypeListViewSelectedIndexChanged (form:AbsenceType_Form) =
        match form.absenceTypeListView.SelectedIndices.Count = 1 with
        | false -> ()
        | true ->
            let index = form.absenceTypeListView.SelectedIndices.[0]
            let selectedItem = form.absenceTypeListView.Items.[index]
            form.absenceType_Label.Text <- selectedItem.SubItems.[1].Text
            form.txbx_id.Text <- selectedItem.SubItems.[0].Text
            ToggleInsertOrUpdate form true

    let UpsertAbsenceType (form:AbsenceType_Form) =
        let result =
            match IsInsert with
            | true ->
                let insertAbsenceType = DB.Inserts.insertAbsenceType DB.DBInteraction.ConnectionString
                insertAbsenceType.Execute(System.Guid.NewGuid(),form.absenceType_Label.Text)
            | false ->
                let updateAbsenceType = DB.Updates.updateAbsenceType DB.DBInteraction.ConnectionString
                updateAbsenceType.Execute(form.absenceType_Label.Text,System.Guid.Parse(form.txbx_id.Text))
        
        UpdateData form

    let registerEvents (form:AbsenceType_Form) =
        form.absenceTypeListView.SelectedIndexChanged.Add(fun evenArgs -> AbsenceTypeListViewSelectedIndexChanged form)
        form.createButton.Click.Add(fun evenArgs -> UpsertAbsenceType form)
        form.cancelBtn.Click.Add(fun evenArgs -> form.Hide())
        form.btn_clear.Click.Add(fun evenArgs -> ToggleInsertOrUpdate form false)
        form.Load.Add(fun evenArgs -> UpdateData form)