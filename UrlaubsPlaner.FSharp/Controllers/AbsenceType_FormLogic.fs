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

    let registerEvents (form:AbsenceType_Form) =
        form.cancelBtn.Click.Add(fun evenArgs -> form.Hide())

        form.Load.Add(fun evenArgs -> UpdateData form)