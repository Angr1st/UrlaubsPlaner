namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms
open DB.Querys
open System.Windows.Forms

module Employee_FormLogic =

    type DataStorage_Employee =
        {
            Employees:DB.Querys.GetEmployeeView.Record array
            Countries:DB.Querys.GetCountrys.Record array
        }

    let toCountryRepr x = {Country=x}

    let mutable private IsInsert = true

    let mutable private Data = 
        let getCountries = DB.Querys.getCountrys DB.DBInteraction.ConnectionString
        let countryArray = getCountries.Execute() |> Seq.toArray
        {Employees=Array.empty;Countries=countryArray}

    let EmployeeForm = new Employee_Form()

    let UpdateData (form:Employee_Form) =
        match form.cbx_country.Items.Count = 0 with
        | false -> ()
        | true ->
            let countrieReprArray = Data.Countries |> Array.map (Common_Logic.UpcastToObj toCountryRepr)
            do form.cbx_country.Items.AddRange countrieReprArray

        do form.employeeListView.Items.Clear()
        
        let employees = DB.Querys.getEmployeeView DB.DBInteraction.ConnectionString

        Data <- {Data with Employees=employees.Execute() |> Seq.toArray}

        let transformEmployeeToListViewItem (employeeRecord:DB.Querys.GetEmployeeView.Record) =
            System.Windows.Forms.ListViewItem(
                [|
                    employeeRecord.EmployeeID.ToString()
                    employeeRecord.EmployeeNumber.ToString()
                    employeeRecord.Code
                    employeeRecord.Firstname
                    employeeRecord.Lastname
                    employeeRecord.Email
                |]
            )

        let listViewEmployeeArray = Data.Employees |> Array.map transformEmployeeToListViewItem

        form.employeeListView.Items.AddRange listViewEmployeeArray

    let ToggleInsertOrUpdate (form:Employee_Form) visible =
        IsInsert <- not visible

        form.txtbx_id.Visible <- visible
        form.lbl_ID.Visible <- visible
        form.btn_clear.Visible <- visible
        form.txtbx_number.Visible <- visible
        form.lbl_number.Visible <- visible

        form.btn_create.Text <- Common_Logic.ChangeButtonText <| not visible

        match visible with
        | true -> ()
        | false ->
            form.txtbx_id.Text <- System.String.Empty
            form.txtbx_city.Text <- System.String.Empty
            form.txtbx_email.Text <- System.String.Empty
            form.txtbx_firstname.Text <- System.String.Empty
            form.txtbx_lastname.Text <- System.String.Empty
            form.txtbx_number.Text <- System.String.Empty
            form.txtbx_postalcode.Text <- System.String.Empty
            form.txtbx_housenumber.Text <- System.String.Empty
            form.txtbx_telefonnumber.Text <- System.String.Empty
            form.txtbx_street.Text <- System.String.Empty
            form.dtm_birthday.Value <- System.DateTime.Now
            form.cbx_country.SelectedItem <- null

    let ListViewEmployeeSelectedIndexChanged (form:Employee_Form) =
        match form.employeeListView.SelectedIndices.Count = 1 with
        | false -> ()
        | true ->
            let index = form.employeeListView.SelectedIndices.[0]
            let selectedItem = Data.Employees.[index]
            form.txtbx_firstname.Text <- selectedItem.Firstname
            form.txtbx_city.Text <- selectedItem.City
            form.txtbx_email.Text <- selectedItem.Email
            form.txtbx_housenumber.Text <- selectedItem.Housenumber
            form.txtbx_id.Text <- selectedItem.EmployeeID.ToString()
            form.txtbx_lastname.Text <- selectedItem.Lastname
            form.txtbx_number.Text <- selectedItem.EmployeeNumber.ToString()
            form.txtbx_postalcode.Text <- selectedItem.Postalcode
            form.txtbx_street.Text <- selectedItem.Street
            form.txtbx_telefonnumber.Text <- selectedItem.Phonenumber
            form.dtm_birthday.Value <- selectedItem.Birthday |> Option.defaultValue System.DateTime.Now
            form.cbx_country.SelectedItem <- Data.Countries |> Array.find (fun x -> x.CountryID = selectedItem.CountryID) |> toCountryRepr

            ToggleInsertOrUpdate form true

    let cbxAsCountryRepr (box:ComboBox) =
        if (box.SelectedItem :? Country_Representation) then box.SelectedItem :?> Country_Representation
        else failwith "This Combobox should only contain AbsenceType_Representation Objects!"

    let UpsertData (form:Employee_Form) =
        let countryId = (cbxAsCountryRepr form.cbx_country).Country.CountryID

        let result =
            match IsInsert with
            | true ->
                let insertEmployee = DB.Inserts.insertEmployee DB.DBInteraction.ConnectionString
                insertEmployee.Execute(System.Guid.NewGuid(),Data.Employees.Length + 1,countryId,form.txtbx_firstname.Text,form.txtbx_lastname.Text,form.dtm_birthday.Value,form.txtbx_street.Text,form.txtbx_housenumber.Text,form.txtbx_postalcode.Text,form.txtbx_city.Text,form.txtbx_telefonnumber.Text,form.txtbx_email.Text)
            | false ->
                let updateEmployee = DB.Updates.updateEmployee DB.DBInteraction.ConnectionString
                updateEmployee.Execute(form.txtbx_number.Text |> int,countryId,form.txtbx_firstname.Text,form.txtbx_lastname.Text,form.dtm_birthday.Value,form.txtbx_street.Text,form.txtbx_housenumber.Text,form.txtbx_postalcode.Text,form.txtbx_city.Text,form.txtbx_telefonnumber.Text,form.txtbx_email.Text,System.Guid.Parse(form.txtbx_id.Text))

        UpdateData form

    let registerEvents (form:Employee_Form) =
        form.Load.Add(fun evenArgs -> UpdateData form)
        form.btn_clear.Click.Add(fun evenArgs -> ToggleInsertOrUpdate form false)
        form.btn_create.Click.Add(fun evenArgs -> UpsertData form)
        form.cancelbtn.Click.Add(fun evenArgs -> form.Hide())
        form.employeeListView.SelectedIndexChanged.Add(fun evenArgs -> ListViewEmployeeSelectedIndexChanged form)