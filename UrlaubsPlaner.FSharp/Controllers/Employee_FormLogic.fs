namespace UrlaubsPlaner.FSharp

open UrlaubsPlanerForms
open DB.Querys

module Employee_FormLogic =

    type DataStorage_Employee =
        {
            Employees:DB.Querys.GetEmployeeView.Record array
            Countries:DB.Querys.GetCountrys.Record array
        }

    let toCountryRepr x = {Country=x}

    let mutable private IsInsert = false

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

    let registerEvents (form:Employee_Form) =
        form.Load.Add(fun evenArgs -> UpdateData form)
        //form.btn_clear.Click.Add(fun evenArgs -> )
        //form.btn_create.Click.Add(fun evenArgs -> )
        form.cancelbtn.Click.Add(fun evenArgs -> form.Hide())
        //form.employeeListView.SelectedIndexChanged.Add(fun evenArgs ->)